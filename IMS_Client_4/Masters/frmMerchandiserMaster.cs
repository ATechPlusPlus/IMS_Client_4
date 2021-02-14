﻿using ComponentFactory.Krypton.Toolkit;
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
                    Merchandiser_AccountID = ObjDAL.InsertData("tblMerchandiser_Account", true);
                }

            } 
        }

        private int UpdateMerchandiserMasterData()
        {
            ObjDAL.UpdateColumnData("MerchandiserName", SqlDbType.NVarChar, txtMerchandiserName.Text.Trim());
            ObjDAL.UpdateColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID);
            MerchanniderID = ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblMerchandiserMaster", "MerchandiserID = " + MerchanniderID + "");

            return MerchanniderID;
        }

        private void UpdateMerchandiserAccountdata(int MerchandiserID)
        {
            dgvAccounts.EndEdit();

            for (int i = 0; i < dgvAccounts.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvAccounts.Rows[i].Cells["colCheck"].Value))
                {
                    int accountID = Convert.ToInt32(dgvAccounts.Rows[i].Cells["CustomerID"].Value);

                    ObjDAL.UpdateColumnData("MerchandiserID", SqlDbType.Int, MerchanniderID);
                    ObjDAL.UpdateColumnData("AccountID", SqlDbType.Int, accountID);
                    ObjDAL.UpdateData("tblMerchandiser_Account", "Merchandiser_AccountID = " + Merchandiser_AccountID + "");
                    ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                    ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                }

            }
        }

        private void LoadAccountsData()
        {
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_CustomerMaster");
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
                int MID = UpdateMerchandiserMasterData();
                if (MID > 0)
                {
                    UpdateMerchandiserAccountdata(MID);

                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                    clsUtility.ShowInfoMessage("Merchandiser : '" + txtMerchandiserName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
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
            string strQ = "select MerchandiserID,MerchandiserName,(select count(*) from "+clsUtility.DBName+"[dbo].[tblMerchandiser_Account] where MerchandiserID=m1.MerchandiserID)" +
                            "as Total_Account, 'View Details' as ViewDetails" +
                            " from "+clsUtility.DBName+"[dbo].[tblMerchandiserMaster] m1";

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

        }

        private void dgvMerchandiserList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMerchandiserList.Columns["MerchandiserID"].Visible = false;
            SetGridStyle(dgvMerchandiserList);
        }
    }
}
