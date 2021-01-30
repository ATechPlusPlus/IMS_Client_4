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
        }

        private void frmMerchandiserMaster_Load(object sender, EventArgs e)
        {


            
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("CustomerName");

            //DataRow dRow=  dt.NewRow();
            //dRow["ID"] = 12;
            //dRow["CustomerName"] = "MacD";

            //DataRow dRow2 = dt.NewRow();
            //dRow2["ID"] = 13;
            //dRow2["CustomerName"] = "MALL A";

            //DataRow dRow3 = dt.NewRow();
            //dRow3["ID"] = 14;
            //dRow3["CustomerName"] = "Demart";

            //dt.Rows.Add(dRow);
            //dt.Rows.Add(dRow2);
            //dt.Rows.Add(dRow3);
            //dt.AcceptChanges();
            //dgvAccounts.DataSource = dt;







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

            grpMerchandiserDetails.Enabled = false;
        }
        CoreApp.clsConnection_DAL bjDAL = new CoreApp.clsConnection_DAL(true);
        private void btnSave_Click(object sender, EventArgs e)
        {
            //dgvAccounts.EndEdit();

            //List<int> lstSelectedAccount = new List<int>();

            //for (int i = 0; i < dgvAccounts.Rows.Count; i++)
            //{
            //    if (Convert.ToBoolean(dgvAccounts.Rows[i].Cells["colCheck"].Value))
            //    {
            //        lstSelectedAccount.Add(Convert.ToInt32(dgvAccounts.Rows[i].Cells["ID"].Value));
            //    }

            //}


            //for (int i = 0; i < lstSelectedAccount.Count; i++)
            //{
                
            //    bjDAL.SetColumnData("MerchanniderID", SqlDbType.Int, MerchanniderID);
            //    bjDAL.SetColumnData("AccountiD", SqlDbType.Int, lstSelectedAccount[i]);
            //    bjDAL.InsertData("tblMerchanser_Account", false);
            //}


        }
        int MerchanniderID = 0;
        private void dgvAccounts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // dgvAccounts.Columns["CustomerID"].Visible = false;


            ObjUtil.SetRowNumber(dgvAccounts);
            ObjUtil.SetDataGridProperty(dgvAccounts, DataGridViewAutoSizeColumnsMode.Fill);
            dgvAccounts.Columns["CustomerID"].Visible = false;
            dgvAccounts.Columns["PhoneNo"].Visible = false;
            dgvAccounts.Columns["EmailID"].Visible = false;
            dgvAccounts.Columns["Address"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = Convert.ToString((dgvAccounts.Rows.Count));
            //lblTotalRecords.Text = "Total Records : " + dgvCustomerMaster.Rows.Count;
        }


        private void LoadData()
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
    }
}
