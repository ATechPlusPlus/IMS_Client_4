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
    public partial class frmMerchandiserMaster : KryptonForm
    {
        public frmMerchandiserMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        private void ClearAll()
        {
            txtMerchandiserName.Clear();
            txtMerchandiserName.Focus();
            checkBox1.Checked = false;
            for (int i = 0; i < dgvAccounts.Rows.Count; i++)
            {
                dgvAccounts.Rows[i].Cells["colCheck"].Value = false;
            }

        }

        private void frmMerchandiserMaster_Load(object sender, EventArgs e)
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

            dgvAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvAccounts.RowHeadersVisible = false; // set it to false if not needed
            LoadData();
            LoadAccountsData();

            grpMerchandiserDetails.Enabled = false;
        }
        private bool ValidateForm()
        {
            return true;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int MID = SaveMerchandiserMasterData();
                if (MID>0)
                {
                    SaveMerchandiserAccountdata(MID);

                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                    clsUtility.ShowInfoMessage("Merchandiser : '" + txtMerchandiserName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadAccountsData();
                    LoadData();
                    grpMerchandiserDetails.Enabled = false;

                }

            }

        }
        int MerchanniderID = 0;
        int Merchandiser_AccountID = 0;
        private void SetGridStyle(KryptonDataGridView dgv)
        {
            ObjUtil.SetRowNumber(dgv);

            //lblTotalRecords.Text = "Total Records : " + dgvCustomerMaster.Rows.Count;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
            dgv.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
        }
        private void dgvAccounts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // dgvAccounts.Columns["CustomerID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvAccounts.Rows.Count.ToString();


            //  ObjUtil.SetDataGridProperty(dgvAccounts, DataGridViewAutoSizeColumnsMode.Fill);
            dgvAccounts.Columns["CustomerID"].Visible = false;
            dgvAccounts.Columns["PhoneNo"].Visible = false;
            dgvAccounts.Columns["EmailID"].Visible = false;
            dgvAccounts.Columns["Address"].Visible = false;

            //kryptonHeaderGroup1.ValuesPrimary.Heading= "Total Records : " + dgvCustomerMaster.Rows.Count;
            SetGridStyle(dgvAccounts);
        }

        private int SaveMerchandiserMasterData()
        {
            ObjDAL.SetColumnData("MerchandiserName", SqlDbType.NVarChar, txtMerchandiserName.Text.Trim());
            ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
            MerchanniderID = ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblMerchandiserMaster", true);
            
            return MerchanniderID;
        }
        private void SaveMerchandiserAccountdata(int MerchandiserID)
        {
            dgvAccounts.EndEdit();

            for (int i = 0; i < dgvAccounts.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvAccounts.Rows[i].Cells["colCheck"].Value))
                {
                    int accountID = Convert.ToInt32(dgvAccounts.Rows[i].Cells["CustomerID"].Value);

                    ObjDAL.SetColumnData("MerchandiserID", SqlDbType.Int, MerchanniderID);
                    ObjDAL.SetColumnData("AccountID", SqlDbType.Int, accountID);
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
                    Merchandiser_AccountID = ObjDAL.InsertData("tblMerchandiser_Account", true);
                }

            } 
        }

        private void UpdateMerchandiserMasterData()
        {
            ObjDAL.UpdateColumnData("MerchandiserName", SqlDbType.NVarChar, txtMerchandiserName.Text.Trim());
            ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID);
            ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now);
            if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblMerchandiserMaster", "MerchandiserID = " + MerchanniderID + "") > 0)
            {
                //ClearAll();
                grpMerchandiserDetails.Enabled = false;
                //ObjDAL.ResetData();
            }
            else
            {
                clsUtility.ShowErrorMessage("Failed to update the User Login Data.", clsUtility.strProjectTitle);
                ObjDAL.ResetData();
            }
        }

        private void UpdateMerchandiserAccountdata(int MerchandiserID)
        {

            ObjDAL.ExecuteNonQuery("delete tblMerchandiser_Account where MerchandiserID=" + MerchanniderID);

            dgvAccounts.EndEdit();

            for (int i = 0; i < dgvAccounts.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvAccounts.Rows[i].Cells["colCheck"].Value))
                {
                    int accountID = Convert.ToInt32(dgvAccounts.Rows[i].Cells["CustomerID"].Value);

                    ObjDAL.SetColumnData("MerchandiserID", SqlDbType.Int, MerchanniderID);
                    ObjDAL.SetColumnData("AccountID", SqlDbType.Int, accountID);
                    ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
                    Merchandiser_AccountID = ObjDAL.InsertData("tblMerchandiser_Account", true);
                }

            }
        }

        private void LoadAccountsData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.spr_Get_CustomerMaster");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvAccounts.DataSource = dt;
                }
                else
                {
                    dgvAccounts.DataSource = null;
                }
            }
            else
            {
                dgvAccounts.DataSource = null;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpMerchandiserDetails.Enabled = true;
            txtMerchandiserName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
            grpMerchandiserDetails.Enabled = true;
            txtMerchandiserName.Focus();
            txtMerchandiserName.SelectionStart = txtMerchandiserName.MaxLength;
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Customer_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{

            if (ValidateForm())
            {
                if (MerchanniderID > 0)
                {
                    UpdateMerchandiserMasterData();
                    UpdateMerchandiserAccountdata(MerchanniderID);

                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                    clsUtility.ShowInfoMessage("Merchandiser Data '" + txtMerchandiserName.Text + "' is Updated Successfully..", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadAccountsData();
                    LoadData();
                    grpMerchandiserDetails.Enabled = false;

                }
                else
                {
                    UpdateMerchandiserAccountdata(MerchanniderID);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                    clsUtility.ShowInfoMessage("Merchandiser Data '" + txtMerchandiserName.Text + "' is not Updated..", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadAccountsData();
                    LoadData();
                    grpMerchandiserDetails.Enabled = false;
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
                LoadAccountsData();
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterCancel);
                grpMerchandiserDetails.Enabled = false;
            }
        }
        private void LoadData()
        {
            string strQ = "select MerchandiserID,MerchandiserName,(select count(*) from "+clsUtility.DBName+ ".[dbo].[tblMerchandiser_Account] where MerchandiserID=m1.MerchandiserID)" +
                            "as Total_Account, 'View Details' as ViewDetails" +
                            " from "+clsUtility.DBName+".[dbo].[tblMerchandiserMaster] m1";

           DataTable dtMerchandiser= ObjDAL.ExecuteSelectStatement(strQ);
            if(ObjUtil.ValidateTable(dtMerchandiser))
            {
                dgvMerchandiserList.DataSource = dtMerchandiser;
            }
            else
            {
                dgvMerchandiserList.DataSource = null;

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < dgvAccounts.Rows.Count; i++)
                {
                    dgvAccounts.Rows[i].Cells["colCheck"].Value = true;
                }
                
            }
            else
            {
                for (int i = 0; i < dgvAccounts.Rows.Count; i++)
                {
                    dgvAccounts.Rows[i].Cells["colCheck"].Value = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
            DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtMerchandiserName.Text + "' Merchandiser ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblMerchandiserMaster", "MerchandiserID=" + MerchanniderID) > 0)
                {
                    ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblMerchandiser_Account", "MerchandiserID=" + MerchanniderID);
                    clsUtility.ShowInfoMessage("'" + txtMerchandiserName.Text + "' Merchandiser is deleted  ", clsUtility.strProjectTitle);
                    ClearAll();
                    LoadData();
                    grpMerchandiserDetails.Enabled = false;
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtMerchandiserName.Text + "' Merchandiser is not deleted  ", clsUtility.strProjectTitle);
                    ObjDAL.ResetData();
                }
            }
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void dgvMerchandiserList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMerchandiserList.Columns["MerchandiserID"].Visible = false;
            dgvMerchandiserList.Columns["colView"].Visible = false;
            SetGridStyle(dgvMerchandiserList);

        }

        private void dgvMerchandiserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    MerchanniderID = Convert.ToInt32(dgvMerchandiserList.SelectedRows[0].Cells["MerchandiserID"].Value);
                    txtMerchandiserName.Text = dgvMerchandiserList.SelectedRows[0].Cells["MerchandiserName"].Value.ToString();

                    for (int i = 0; i < dgvAccounts.Rows.Count; i++)
                    {
                        dgvAccounts.Rows[i].Cells["colCheck"].Value = false;
                    }
                    
                    string strAccounts = "SELECT cm.CustomerID,cm.CustomerName FROM " + clsUtility.DBName + ".dbo.tblCustomerMaster cm join " + clsUtility.DBName + ".dbo.tblMerchandiser_Account ma on cm.CustomerID=ma.AccountID where ma.MerchandiserID=" + MerchanniderID + "";

                    DataTable dtAccounts = ObjDAL.ExecuteSelectStatement(strAccounts);


                    for (int i = 0; i < dgvAccounts.Rows.Count; i++)
                    {
                        int _MainCustomerID =Convert.ToInt32(dgvAccounts.Rows[i].Cells["CustomerID"].Value);
                         for (int b = 0; b < dtAccounts.Rows.Count; b++)
                        {
                            int CustomerID = Convert.ToInt32(dtAccounts.Rows[b]["CustomerID"].ToString());

                            if (_MainCustomerID==CustomerID)
                            {
                                dgvAccounts.Rows[i].Cells["colCheck"].Value = true;
                            }
                            
                        }
                       
                    }
                    dgvAccounts.EndEdit();


                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    grpMerchandiserDetails.Enabled = false;
                    txtMerchandiserName.Focus();

                    //txtBarcode.Text = dgvMerchandiserList.SelectedRows[0].Cells["Barcodes"].Value.ToString();
                    //txtWeight.Text = dgvMerchandiserList.SelectedRows[0].Cells["Weight"].Value.ToString();
                    //txtPack.Text = dgvMerchandiserList.SelectedRows[0].Cells["Packs"].Value.ToString();
                    //txtUnitPrice.Text = dgvMerchandiserList.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
                    //txtCartonPrice.Text = dgvMerchandiserList.SelectedRows[0].Cells["CartonPrice"].Value.ToString();
                    //cmbActiveStatus.SelectedItem = dgvMerchandiserList.SelectedRows[0].Cells["ActiveStatus"].Value.ToString();
                    //grpProduct.Enabled = false;
                    //txtProductName.Focus();
                }
                catch { }
            }
        }
    }
}
