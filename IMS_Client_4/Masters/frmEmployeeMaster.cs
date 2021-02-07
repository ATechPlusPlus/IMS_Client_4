using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreApp;

namespace IMS_Client_4.Masters
{
    public partial class frmEmployeeMaster : KryptonForm
    {
        public frmEmployeeMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int EmployeeID = 0;

        private void lklBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicEmployee.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void lklClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicEmployee.Image = null;
        }

        private void FillStoreDetails()
        {
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreID,StoreName", "ISNULL(ActiveStatus,1)=1", " StoreID");
            cmbShop.DataSource = dt;
            cmbShop.DisplayMember = "StoreName";
            cmbShop.ValueMember = "StoreID";

            cmbShop.SelectedIndex = -1;
        }

        private void LoadData()
        {
            string q = "SELECT e1.EmpID,EmployeeCode,Name,ShopID,(CASE e1.Gender WHEN 1 THEN 'Male' WHEN 0 THEN 'Female' END) Gender,DOB,[Address],Photo, s1.StoreName,(CASE e1.ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus FROM " + clsUtility.DBName + ".dbo.tblEmployeeMaster e1 JOIN " + clsUtility.DBName + ".dbo.tblStoreMaster s1" +
              " ON e1.ShopID=s1.StoreID ORDER BY EmpID DESC";
            DataTable dataTable = ObjDAL.ExecuteSelectStatement(q);
            if (ObjUtil.ValidateTable(dataTable))
            {
                dgvEmployee.DataSource = dataTable;
                kryptonHeaderGroup2.ValuesSecondary.Description = dgvEmployee.Rows.Count.ToString();
            }
            else
            {
                dgvEmployee.DataSource = null;
                kryptonHeaderGroup2.ValuesSecondary.Description = "Total Employee Count : 0";
            }
            
        }

        private void ClearAll()
        {
            txtEmployeeName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
            txtEmployeeCode.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            txtEmployeeAddress.Clear();
            PicEmployee.Image = null;
            cmbShop.SelectedIndex = -1;
            cmbActiveStatus.SelectedIndex = -1;
            EmployeeID = 0;
            txtEmailID.Clear();
            dtpDOB.Value = DateTime.Now;
            dtpDOB.Checked = false;
        }

        private void SetGridStyle(KryptonDataGridView dgv)
        {
            ObjUtil.SetRowNumber(dgv);

            //lblTotalRecords.Text = "Total Records : " + dgvCustomerMaster.Rows.Count;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
            dgv.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
        }
        private void frmEmployeeMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            dtpDOB.ShowCheckBox = true;
            dtpDOB.Checked = false;
            txtSearchByEmployeeCode.Enabled = false;
            txtSearchByEmployeeName.Enabled = false;
            //btnAdd.BackgroundImage = B_Leave;
            //btnSave.BackgroundImage = B_Leave;
            //btnEdit.BackgroundImage = B_Leave;
            //btnUpdate.BackgroundImage = B_Leave;
            //btnDelete.BackgroundImage = B_Leave;
            //btnCancel.BackgroundImage = B_Leave;

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);
            grpEmployeeDetails.Enabled = false;
            FillStoreDetails();
            LoadData();
        }

        private bool ValidateEmployee()
        {
            if (ObjUtil.IsControlTextEmpty(txtEmployeeCode))
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Code.", clsUtility.strProjectTitle);
                txtEmployeeCode.Focus();
                return false;
            }

            else if (ObjUtil.IsControlTextEmpty(txtEmployeeName))
            {
                clsUtility.ShowInfoMessage("Please Enter Employee Name.", clsUtility.strProjectTitle);
                txtEmployeeName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbActiveStatus))
            {
                clsUtility.ShowInfoMessage("Please Select ActiveStatus.", clsUtility.strProjectTitle);
                cmbActiveStatus.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbShop))
            {
                clsUtility.ShowInfoMessage("Please Select Shop.", clsUtility.strProjectTitle);
                cmbShop.Focus();
                return false;
            }

            else if (radFemale.Checked == false && radMale.Checked == false)
            {
                clsUtility.ShowInfoMessage("Please Select Gender.", clsUtility.strProjectTitle);
                radMale.Focus();
                radMale.Checked = false;
                radFemale.Checked = false;
                return false;
            }

            int result = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.tblEmployeeMaster WHERE EmployeeCode='" + txtEmployeeCode.Text + "' AND EMPID<>" + EmployeeID);
            if (result > 0)
            {
                clsUtility.ShowInfoMessage("The Employee already exist with the given employee code. Please Enter different employee code.", clsUtility.strProjectTitle);
                txtEmployeeCode.Focus();
                return false;
            }

            if (txtUserName.Text.Trim().Length > 0) // if user name is entered
            {
                if (ObjUtil.IsControlTextEmpty(txtPassword))
                {
                    clsUtility.ShowInfoMessage("Please Enter Password.", clsUtility.strProjectTitle);
                    txtPassword.Focus();
                    return false;
                }

                int countuser = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.UserManagement WHERE UserName='" + txtUserName.Text + "' AND EmployeeID<>" + EmployeeID);
                if (countuser > 0)
                {
                    clsUtility.ShowInfoMessage("The user name already exist.Please enter different user name.", clsUtility.strProjectTitle);
                    txtUserName.Focus();
                    return false;
                }
            }
            return true;
        }

        private void CreateNewUser(int EmployeeID)
        {
            ObjDAL.SetColumnData("UserName", SqlDbType.NVarChar, txtUserName.Text.Trim());
            ObjDAL.SetColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPassword.Text.Trim(), true));
            ObjDAL.SetColumnData("EmailID", SqlDbType.NVarChar, txtEmailID.Text.Trim());
            ObjDAL.SetColumnData("IsAdmin", SqlDbType.Bit, false);
            ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
            ObjDAL.SetColumnData("EmployeeID", SqlDbType.Int, EmployeeID);

            if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.UserManagement", true) > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                clsUtility.ShowInfoMessage("User has been added Successfully.", clsUtility.strProjectTitle);
                ClearAll();
                LoadData();
                grpEmployeeDetails.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the User.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void SaveEmployee()
        {
            ObjDAL.SetColumnData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim());
            ObjDAL.SetColumnData("Name", SqlDbType.NVarChar, txtEmployeeName.Text.Trim());
            ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
            ObjDAL.SetColumnData("ShopID", SqlDbType.Int, cmbShop.SelectedValue);
            if (radMale.Checked)
            {
                ObjDAL.SetColumnData("Gender", SqlDbType.Bit, true);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.SetColumnData("Gender", SqlDbType.Bit, false);
            }
            if (dtpDOB.Checked)
            {
                ObjDAL.SetColumnData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                ObjDAL.SetColumnData("DOB", SqlDbType.DateTime, DBNull.Value);
            }

            ObjDAL.SetColumnData("Address", SqlDbType.NVarChar, txtEmployeeAddress.Text.Trim());

            if (PicEmployee.Image != null)
            {
                ObjDAL.SetColumnData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image));
            }
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            EmployeeID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblEmployeeMaster", true);

            if (EmployeeID > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                clsUtility.ShowInfoMessage("Employee has been added Successfully.", clsUtility.strProjectTitle);

                if (txtUserName.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
                {
                    CreateNewUser(EmployeeID);
                }
                ClearAll();
                LoadData();
                grpEmployeeDetails.Enabled = false;
            }
            else
            {
                clsUtility.ShowInfoMessage("Failed to add the employee.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void BindUserDetails()
        {
            DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM " + clsUtility.DBName + ".[dbo].[UserManagement] WHERE EmployeeID=" + EmployeeID);
            if (ObjUtil.ValidateTable(dt))
            {
                txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                txtPassword.Text = ObjUtil.Decrypt(dt.Rows[0]["Password"].ToString(), true);
                txtEmailID.Text = dt.Rows[0]["EmailID"].ToString();
            }
        }

        private void UpdateUserDetails()
        {
            ObjDAL.UpdateColumnData("UserName", SqlDbType.NVarChar, txtUserName.Text.Trim());
            ObjDAL.UpdateColumnData("Password", SqlDbType.NVarChar, ObjUtil.Encrypt(txtPassword.Text.Trim(), true));
            ObjDAL.UpdateColumnData("EmailID", SqlDbType.NVarChar, txtEmailID.Text.Trim());
            ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //ObjDAL.UpdateColumnData("IsAdmin", SqlDbType.Bit, false); 
            //if user is blocked then if his details will update from this form then could be auto unblock

            //ObjDAL.UpdateColumnData("IsBlock", SqlDbType.Bit, false);
            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.UserManagement", "EmployeeID = " + EmployeeID + "") > 0)
            {
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                clsUtility.ShowInfoMessage("User Login Record has been updated.", clsUtility.strProjectTitle);
                LoadData();
                ClearAll();
                grpEmployeeDetails.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the User Login Data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void UpdateEmployee()
        {
            ObjDAL.UpdateColumnData("EmployeeCode", SqlDbType.NVarChar, txtEmployeeCode.Text.Trim());
            ObjDAL.UpdateColumnData("Name", SqlDbType.NVarChar, txtEmployeeName.Text.Trim());
            ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
            ObjDAL.UpdateColumnData("ShopID", SqlDbType.Int, cmbShop.SelectedValue);
            if (radMale.Checked)
            {
                ObjDAL.UpdateColumnData("Gender", SqlDbType.Bit, true);
            }
            else if (radFemale.Checked)
            {
                ObjDAL.UpdateColumnData("Gender", SqlDbType.Bit, false);
            }
            if (dtpDOB.Checked)
            {
                ObjDAL.UpdateColumnData("DOB", SqlDbType.DateTime, dtpDOB.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                ObjDAL.UpdateColumnData("DOB", SqlDbType.DateTime, DBNull.Value);
            }

            ObjDAL.UpdateColumnData("Address", SqlDbType.NVarChar, txtEmployeeAddress.Text.Trim());

            if (PicEmployee.Image != null)
            {
                ObjDAL.UpdateColumnData("Photo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicEmployee.Image));
            }
            else
            {
                ObjDAL.UpdateColumnData("Photo", SqlDbType.VarBinary, DBNull.Value);
                //ObjDAL.SetStoreProcedureData("Photo", SqlDbType.VarBinary, DBNull.Value);
            }

            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblEmployeeMaster", "EMPID = " + EmployeeID + "") > 0)
            {
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                clsUtility.ShowInfoMessage("Employee Record has been updated.", clsUtility.strProjectTitle);

                if (txtUserName.Text.Trim().Length != 0 && txtPassword.Text.Trim().Length != 0)
                {
                    int countuser = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.UserManagement WITH(NOLOCK) WHERE UserName='" + txtUserName.Text + "'");

                    if (countuser > 0)
                    {
                        UpdateUserDetails();
                    }
                    else
                    {
                        CreateNewUser(EmployeeID);
                    }
                }
                LoadData();
                ClearAll();
                grpEmployeeDetails.Enabled = false;
                ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the employee data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpEmployeeDetails.Enabled = true;
            txtEmployeeCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
                if (ValidateEmployee())
                {
                    SaveEmployee();
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void dgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvEmployee);
            SetGridStyle(dgvEmployee);
            dgvEmployee.Columns["ShopID"].Visible = false;
            dgvEmployee.Columns["Photo"].Visible = false;
            dgvEmployee.Columns["EmpID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvEmployee.Rows.Count.ToString(); ;
        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpEmployeeDetails.Enabled = true;
                txtEmployeeCode.Focus();
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
            //    if (ValidateEmployee())
                {
                    UpdateEmployee();
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Employee_Details, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtEmployeeName.Text + "' ? ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblEmployeeMaster", "EmpID='" + EmployeeID + "'") > 0)
                    {
                        clsUtility.ShowInfoMessage("'" + txtEmployeeName.Text + "' Employee has been deleted.  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpEmployeeDetails.Enabled = false;
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("Failed to delete the employee. ", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnShopPopup_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master) || clsUtility.IsAdmin)
            //{
                int a = 0;
                if (cmbShop.SelectedIndex >= 0)
                {
                    a = Convert.ToInt32(cmbShop.SelectedValue);
                }
                Masters.frmStoreMaster Obj = new frmStoreMaster();
                Obj.ShowDialog();
                FillStoreDetails();
                if (a > 0)
                {
                    cmbShop.SelectedValue = a;
                }
            }

        private void rdSearchByEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByEmployeeName.Checked)
            {
                txtSearchByEmployeeName.Enabled = true;
                txtSearchByEmployeeName.Focus();
            }
            else
            {
                txtSearchByEmployeeName.Enabled = false;
                txtSearchByEmployeeName.Clear();
            }
        }

        private void rdSearchByEmployeeID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByEmployeeID.Checked)
            {
                txtSearchByEmployeeCode.Enabled = true;
                txtSearchByEmployeeCode.Focus();
            }
            else
            {
                txtSearchByEmployeeCode.Enabled = false;
                txtSearchByEmployeeCode.Clear();
            }
        }

        private void rdShowAllEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllEmployee.Checked)
            {
                txtSearchByEmployeeName.Enabled = false;
                txtSearchByEmployeeName.Clear();
                txtSearchByEmployeeCode.Enabled = false;
                txtSearchByEmployeeCode.Clear();
                LoadData();
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ClearAll();
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    EmployeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmpID"].Value);
                    txtEmployeeCode.Text = dgvEmployee.SelectedRows[0].Cells["EmployeeCode"].Value.ToString();
                    txtEmployeeName.Text = dgvEmployee.SelectedRows[0].Cells["Name"].Value.ToString();
                    cmbShop.SelectedValue = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ShopID"].Value);

                    if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && dgvEmployee.SelectedRows[0].Cells["Gender"].Value.ToString() == "Male")
                    {
                        radMale.Checked = true;
                    }
                    else if (dgvEmployee.SelectedRows[0].Cells["Gender"].Value != DBNull.Value && dgvEmployee.SelectedRows[0].Cells["Gender"].Value.ToString() == "Female")
                    {
                        radFemale.Checked = true;
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["DOB"].Value != DBNull.Value)
                    {
                        dtpDOB.Value = Convert.ToDateTime(dgvEmployee.SelectedRows[0].Cells["DOB"].Value);
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Address"].Value != DBNull.Value)
                    {
                        txtEmployeeAddress.Text = dgvEmployee.SelectedRows[0].Cells["Address"].Value.ToString();
                    }

                    if (dgvEmployee.SelectedRows[0].Cells["Photo"].Value != DBNull.Value)
                    {
                        PicEmployee.Image = ObjUtil.GetImage((byte[])dgvEmployee.SelectedRows[0].Cells["Photo"].Value);
                    }
                    cmbActiveStatus.SelectedItem = dgvEmployee.SelectedRows[0].Cells["ActiveStatus"].Value;

                    grpEmployeeDetails.Enabled = false;
                    BindUserDetails();
                }
                catch { }
            }
        }

        private void txtSearchByEmployeeName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByEmployeeName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            else
            {
                string q = "SELECT e1.EmpID,EmployeeCode,Name,ShopID,(CASE e1.Gender WHEN 1 THEN 'Male' WHEN 0 THEN 'Female' END) Gender,DOB,[Address],Photo, s1.StoreName,(CASE e1.ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus FROM " + clsUtility.DBName + ".dbo.tblEmployeeMaster e1 JOIN " + clsUtility.DBName + ".dbo.tblStoreMaster s1" +
                  " ON e1.ShopID=s1.StoreID where e1.Name LIKE '" + txtSearchByEmployeeName.Text + "%'";
                DataTable dt = ObjDAL.ExecuteSelectStatement(q);
                
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvEmployee.DataSource = dt;
                }
                else
                {
                    dgvEmployee.DataSource = null;
                }
            }
        }

        private void txtSearchByEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByEmployeeCode.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            else
            {
                string q = "SELECT e1.EmpID,EmployeeCode,Name,ShopID,(CASE e1.Gender WHEN 1 THEN 'Male' WHEN 0 THEN 'Female' END) Gender,DOB,[Address],Photo, s1.StoreName,(CASE e1.ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus FROM " + clsUtility.DBName + ".dbo.tblEmployeeMaster e1 JOIN " + clsUtility.DBName + ".dbo.tblStoreMaster s1" +
                  " ON e1.ShopID=s1.StoreID where e1.EmployeeCode LIKE '" + txtSearchByEmployeeCode.Text + "%'";
                DataTable dt = ObjDAL.ExecuteSelectStatement(q);

                if (ObjUtil.ValidateTable(dt))
                {
                    dgvEmployee.DataSource = dt;
                }
                else
                {
                    dgvEmployee.DataSource = null;
                }
            }
        }
    }
    }

