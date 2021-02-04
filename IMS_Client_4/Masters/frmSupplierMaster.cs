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
    public partial class frmSupplierMaster : KryptonForm
    {
        public frmSupplierMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private void ClearAll()
        {
            txtSupplierName.Clear();
            cmbCountry.SelectedIndex = -1;
            txtPhoneNo.Clear();
            txtEmailID.Clear();
            txtFaxNo.Clear();
            txtBankAddress.Clear();
            txtBankName.Clear();
            txtBankAccountNo.Clear();
            cmbActiveStatus.SelectedIndex = -1;

            txtSupplierName.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtSupplierName))
            {
                clsUtility.ShowInfoMessage("Enter Supplier Name           ", clsUtility.strProjectTitle);
                txtSupplierName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbCountry))
            {
                clsUtility.ShowInfoMessage("Select Country for " + txtSupplierName.Text, clsUtility.strProjectTitle);
                cmbCountry.Focus();
                return false;
            }
            //else if (ObjUtil.IsControlTextEmpty(txtPhone))
            //{
            //    clsUtility.ShowInfoMessage("Enter Phone Number          ", clsUtility.strProjectTitle);
            //    txtPhone.Focus();
            //    return false;
            //}
            //else if (ObjUtil.IsControlTextEmpty(txtEmail))
            //{
            //    clsUtility.ShowInfoMessage("Enter E-Mail ID          ", clsUtility.strProjectTitle);
            //    txtEmail.Focus();
            //    return false;
            //}
            else if (ObjUtil.IsControlTextEmpty(cmbActiveStatus))
            {
                clsUtility.ShowInfoMessage("Select Active Status.", clsUtility.strProjectTitle);
                cmbActiveStatus.Focus();
                return false;
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblSupplierMaster", "SupplierName='" + txtSupplierName.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblSupplierMaster", "SupplierName='" + txtSupplierName.Text + "' AND SupplierID !=" + i);
            }
            if (a > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
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

        private void LoadData()
        {
            DataTable dt = null;
            dt = ObjDAL.ExecuteSelectStatement("SELECT S.SupplierID,S.SupplierName,S.CountryID,C.CountryName,(CASE S.ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus,S.Phone,S.EmailID,S.BankName,S.BankAccountNo,S.BankAddress " +
              "FROM " + clsUtility.DBName + ".[dbo].[tblSupplierMaster] S " +
              "LEFT OUTER JOIN " + clsUtility.DBName + ".[dbo].[tblCountryMaster] C ON S.CountryID = C.CountryID");

            if (ObjUtil.ValidateTable(dt))
            {
                dgvSupplier.DataSource = dt;
            }
            else
            {
                dgvSupplier.DataSource = null;
            }
        }

        private void FillCountryData()
        {
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryID,CountryName", "ISNULL(ActiveStatus,1)=1", "CountryName ASC");
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";

            cmbCountry.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpSupplier.Enabled = true;
            txtSupplierName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Supplier_Details, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetColumnData("SupplierName", SqlDbType.NVarChar, txtSupplierName.Text.Trim());
                        ObjDAL.SetColumnData("CountryID", SqlDbType.Int, cmbCountry.SelectedValue);
                        ObjDAL.SetColumnData("Phone", SqlDbType.VarChar, txtPhoneNo.Text.Trim());
                        ObjDAL.SetColumnData("EmailID", SqlDbType.VarChar, txtEmailID.Text.Trim());
                        ObjDAL.SetColumnData("BankName", SqlDbType.NVarChar, txtBankName.Text.Trim());
                        ObjDAL.SetColumnData("BankAccountNo", SqlDbType.VarChar, txtBankAccountNo.Text.Trim());
                        ObjDAL.SetColumnData("BankAddress", SqlDbType.NVarChar, txtBankAddress.Text.Trim());
                        ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                        if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblSupplierMaster", true) > 0)
                        {
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Supplier Name : '" + txtSupplierName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            grpSupplier.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Supplier : '" + txtSupplierName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtSupplierName.Text + "' Supplier is already exist..", clsUtility.strProjectTitle);
                        txtSupplierName.Focus();
                    }
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Supplier_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpSupplier.Enabled = true;
                txtSupplierName.Focus();
                txtSupplierName.SelectionStart = txtSupplierName.MaxLength;
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Supplier_Details, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(ID))
                    {
                        ObjDAL.UpdateColumnData("SupplierName", SqlDbType.NVarChar, txtSupplierName.Text.Trim());
                        ObjDAL.UpdateColumnData("CountryID", SqlDbType.Int, cmbCountry.SelectedValue);
                        ObjDAL.UpdateColumnData("Phone", SqlDbType.VarChar, txtPhoneNo.Text.Trim());
                        ObjDAL.UpdateColumnData("EmailID", SqlDbType.VarChar, txtEmailID.Text.Trim());
                        ObjDAL.UpdateColumnData("BankName", SqlDbType.NVarChar, txtBankName.Text.Trim());
                        ObjDAL.UpdateColumnData("BankAccountNo", SqlDbType.VarChar, txtBankAccountNo.Text.Trim());
                        ObjDAL.UpdateColumnData("BankAddress", SqlDbType.NVarChar, txtBankAddress.Text.Trim());
                        ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                        ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblSupplierMaster", "SupplierID = " + ID) > 0)
                        {
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                            clsUtility.ShowInfoMessage("'" + txtSupplierName.Text + "' Supplier is Updated", clsUtility.strProjectTitle);
                            LoadData();
                            ClearAll();
                            grpSupplier.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtSupplierName.Text + "' Supplier is not Updated", clsUtility.strProjectTitle);
                        }
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtSupplierName.Text + "' Supplier is already exist..", clsUtility.strProjectTitle);
                        txtSupplierName.Focus();
                    }
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Supplier_Details, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtSupplierName.Text + "' Supplier ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblSupplierMaster", "SupplierID = " + ID) > 0)
                    {
                        clsUtility.ShowInfoMessage("'" + txtSupplierName.Text + "' Supplier is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpSupplier.Enabled = false;
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtSupplierName.Text + "' Supplier is not deleted  ", clsUtility.strProjectTitle);
                        ObjDAL.ResetData();
                    }
                }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = clsUtility.ShowQuestionMessage(clsUtility.MsgActionCancel, clsUtility.strProjectTitle);
            if (b)
            {
                ClearAll();
                LoadData();
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpSupplier.Enabled = false;
            }
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);

                    ID = Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells["SupplierID"].Value);
                    txtSupplierName.Text = dgvSupplier.SelectedRows[0].Cells["SupplierName"].Value.ToString();
                    cmbCountry.SelectedValue = dgvSupplier.SelectedRows[0].Cells["CountryID"].Value.ToString();
                    txtPhoneNo.Text = dgvSupplier.SelectedRows[0].Cells["Phone"].Value.ToString();
                    txtEmailID.Text = dgvSupplier.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    txtBankName.Text = dgvSupplier.SelectedRows[0].Cells["BankName"].Value.ToString();
                    txtBankAccountNo.Text = dgvSupplier.SelectedRows[0].Cells["BankAccountNo"].Value.ToString();
                    txtBankAddress.Text = dgvSupplier.SelectedRows[0].Cells["BankAddress"].Value.ToString();
                    cmbActiveStatus.SelectedItem = dgvSupplier.SelectedRows[0].Cells["ActiveStatus"].Value.ToString();

                    grpSupplier.Enabled = false;
                    txtSupplierName.Focus();
                }
                catch (Exception ex) { clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle); }
            }
        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbCountry.Focus();
                return;
            }
        }

        private void cmbCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPhoneNo.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtSupplierName.Focus();
                return;
            }
        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBankName.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                cmbCountry.Focus();
                return;
            }
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtFaxNo.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtPhoneNo.Focus();
                return;
            }
        }

        private void txtFaxNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBankAccountNo.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtBankName.Focus();
                return;
            }
        }

        private void txtBankAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtEmailID.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtFaxNo.Focus();
                return;
            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBankAddress.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtBankAccountNo.Focus();
                return;
            }
        }

        private void txtBankAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbActiveStatus.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtEmailID.Focus();
                return;
            }
        }

        private void cmbActiveStatus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtBankAddress.Focus();
                return;
            }
        }

        private void frmSupplierMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);
            grpSupplier.Enabled = false;
            txtSearchBySupplierName.Enabled = false;

            LoadData();

            FillCountryData();
        }

        private void rdSearchBySupplierName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchBySupplierName.Checked)
            {
                txtSearchBySupplierName.Enabled = true;
                txtSearchBySupplierName.Focus();
            }
            else
            {
                txtSearchBySupplierName.Enabled = false;
                txtSearchBySupplierName.Clear();
                rdShowAllSuppliers.Checked = true;
            }
        }

        private void rdShowAllSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllSuppliers.Checked)
            {
                txtSearchBySupplierName.Enabled = false;
                txtSearchBySupplierName.Clear();
                LoadData();
            }
        }

        private void txtSearchBySupplierName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBySupplierName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            DataTable dt = null;
            dt = ObjDAL.ExecuteSelectStatement("SELECT S.SupplierID,S.SupplierName,S.CountryID,C.CountryName,(CASE S.ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus,S.Phone,S.EmailID,S.BankName,S.BankAccountNo,S.BankAddress " +
              "FROM " + clsUtility.DBName + ".[dbo].[tblSupplierMaster] S " +
              "LEFT OUTER JOIN " + clsUtility.DBName + ".[dbo].[tblCountryMaster] C ON S.CountryID = C.CountryID " +
              "WHERE S.SupplierName LIKE '%" + txtSearchBySupplierName.Text + "%'");

            if (ObjUtil.ValidateTable(dt))
            {
                dgvSupplier.DataSource = dt;
            }
            else
            {
                dgvSupplier.DataSource = null;
            }
        }

        private void dgvSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGridStyle(dgvSupplier);
            ObjUtil.SetRowNumber(dgvSupplier);
            ObjUtil.SetDataGridProperty(dgvSupplier, DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dgvSupplier.Columns["SupplierID"].Visible = false;
            dgvSupplier.Columns["CountryID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvSupplier.Rows.Count.ToString();
        }

        private void btnSupplierCountryPopup_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (cmbCountry.SelectedIndex >= 0)
            {
                a = Convert.ToInt32(cmbCountry.SelectedValue);
            }
            Masters.frmCountryMaster Obj = new frmCountryMaster();
            Obj.ShowDialog();
            FillCountryData();
            if (a > 0)
            {
                cmbCountry.SelectedValue = a;
            }
        }

        private void txtBankAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsNumeric(e);
            if (e.Handled == true)
            {
                clsUtility.ShowInfoMessage("Enter Only Number...", clsUtility.strProjectTitle);
            }
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsString(e);
            if (e.Handled == true)
            {
                clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                txtSupplierName.Focus();
            }
        }
    }
}
