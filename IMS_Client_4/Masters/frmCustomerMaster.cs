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
    public partial class frmCustomerMaster : KryptonForm
    {
        public frmCustomerMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private void ClearAll()
        {
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtMobileNo.Clear();
            txtEmailID.Clear();

            txtCustomerName.Focus();
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtCustomerName))
            {
                clsUtility.ShowInfoMessage("Enter Customer Name       ", clsUtility.strProjectTitle);
                txtCustomerName.Focus();
                return false;
            }

            else if (ObjUtil.IsControlTextEmpty(txtMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Customer Phone No.      ", clsUtility.strProjectTitle);
                txtMobileNo.Focus();
                return false;
            }

            //else if (ObjUtil.IsControlTextEmpty(txtEmailID))
            //{
            //    clsUtility.ShowInfoMessage("Enter Email ID.", clsUtility.strProjectTitle);
            //    txtEmailID.Focus();
            //    return false;
            //}
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCustomerMaster", "CustomerName='" + txtCustomerName.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCustomerMaster", "CustomerName='" + txtCustomerName.Text + "' AND CustomerID !=" + i);
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

        private void LoadData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_CustomerMaster");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCustomerMaster.DataSource = dt;
                }
                else
                {
                    dgvCustomerMaster.DataSource = null;
                }
            }
            else
            {
                dgvCustomerMaster.DataSource = null;
            }
        }

        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;

            //btnAdd.BackgroundImage = B_Leave;
            //btnSave.BackgroundImage = B_Leave;
            //btnEdit.BackgroundImage = B_Leave;
            //btnUpdate.BackgroundImage = B_Leave;
            //btnDelete.BackgroundImage = B_Leave;
            //btnCancel.BackgroundImage = B_Leave;

            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dgvCustomerMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvCustomerMaster.RowHeadersVisible = false; // set it to false if not needed

            LoadData();

            grpCustomer.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpCustomer.Enabled = true;
            txtCustomerName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
            if (ValidateForm())
            {
                if (DuplicateUser(0))
                {
                    ObjDAL.SetStoreProcedureData("CustomerName", SqlDbType.NVarChar, txtCustomerName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("PhoneNo", SqlDbType.NVarChar, txtMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.NVarChar, txtEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Insert_CustomerMaster");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                        clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpCustomer.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Customer Name : '" + txtCustomerName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is already exist..", clsUtility.strProjectTitle);
                    txtCustomerName.Focus();
                }
                ObjDAL.ResetData();
            }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpCustomer.Enabled = true;
                txtCustomerName.Focus();
                txtCustomerName.SelectionStart = txtCustomerName.MaxLength;
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
            if (ValidateForm())
            {
                if (DuplicateUser(ID))
                {
                    ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CustomerName", SqlDbType.NVarChar, txtCustomerName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("PhoneNo", SqlDbType.NVarChar, txtMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.NVarChar, txtEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Address", SqlDbType.VarChar, txtAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Update_CustomerMaster");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                        clsUtility.ShowInfoMessage("'" + txtCustomerName.Text + "' Customer Name is Updated", clsUtility.strProjectTitle);
                        ID = 0;
                        LoadData();
                        ClearAll();
                        grpCustomer.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer Name is not Updated", clsUtility.strProjectTitle);
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer Name is already exist..", clsUtility.strProjectTitle);
                    txtCustomerName.Focus();
                }
                ObjDAL.ResetData();
            }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
            DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCustomerName.Text + "' Customer ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                ObjDAL.SetStoreProcedureData("CustomerID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Delete_CustomerMaster");
                if (b)
                {
                    clsUtility.ShowInfoMessage("'" + txtCustomerName.Text + "' Customer is deleted  ", clsUtility.strProjectTitle);
                    ID = 0;
                    ClearAll();
                    LoadData();
                    grpCustomer.Enabled = false;
                    //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtCustomerName.Text + "' Customer is not deleted  ", clsUtility.strProjectTitle);
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
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpCustomer.Enabled = false;
            }
        }

        private void dgvCustomerMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvCustomerMaster.SelectedRows[0].Cells["CustomerID"].Value);
                    txtCustomerName.Text = dgvCustomerMaster.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                    txtMobileNo.Text = dgvCustomerMaster.SelectedRows[0].Cells["PhoneNo"].Value.ToString();
                    txtEmailID.Text = dgvCustomerMaster.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    txtAddress.Text = dgvCustomerMaster.SelectedRows[0].Cells["Address"].Value.ToString();
                    grpCustomer.Enabled = false;
                    txtCustomerName.Focus();
                }
                catch { }
            }
        }

        private void rdSearchByCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCustomerName.Checked)
            {
                txtSearchByCustomerName.Enabled = true;
                txtSearchByCustomerName.Focus();
            }
            else
            {
                txtSearchByCustomerName.Enabled = false;
                txtSearchByCustomerName.Clear();
            }
        }

        private void rdSearchByMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByMobileNo.Checked)
            {
                txtSearchByMobileNo.Enabled = true;
                txtSearchByMobileNo.Focus();
            }
            else
            {
                txtSearchByMobileNo.Enabled = false;
                txtSearchByMobileNo.Clear();
            }
        }

        private void rdShowAllOfCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllOfCustomer.Checked)
            {
                txtSearchByCustomerName.Enabled = false;
                txtSearchByCustomerName.Clear();
                LoadData();
            }
        }

        private void txtSearchByCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCustomerName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }

            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblCustomerMaster", "CustomerID,CustomerName,Address,PhoneNo,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "Name LIKE '%" + txtSearchByCustomerName.Text + "%'", "Name");
            if (ObjUtil.ValidateTable(dt))
            {
                dgvCustomerMaster.DataSource = dt;
            }
            else
            {
                dgvCustomerMaster.DataSource = null;
            }
        }

        private void txtSearchByMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByMobileNo.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }

            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.CustomerMaster", "CustomerID,CustomerName,Address,PhoneNo,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "Name LIKE '%" + txtSearchByMobileNo.Text + "%'", "MobileNo");
            if (ObjUtil.ValidateTable(dt))
            {
                dgvCustomerMaster.DataSource = dt;
            }
            else
            {
                dgvCustomerMaster.DataSource = null;
            }
        }

        private void dgvCustomerMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ObjUtil.SetRowNumber(dgvCustomerMaster);
            ObjUtil.SetDataGridProperty(dgvCustomerMaster, DataGridViewAutoSizeColumnsMode.Fill);
            dgvCustomerMaster.Columns["CustomerID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvCustomerMaster.Rows.Count.ToString();
        }
    }
}
