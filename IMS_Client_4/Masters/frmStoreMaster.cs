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
    public partial class frmStoreMaster : KryptonForm
    {
        public frmStoreMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        //this.BackgroundImage = Properties.Resources.back_green;

        private void ClearAll()
        {
            txtStoreName.Clear();
            txtPhoneNo.Clear();
            cmbStoreCategory.SelectedIndex = -1;
            txtPlace.Clear();
            txtFaxNo.Clear();
            cmbActiveStatus.SelectedIndex = -1;
            txtStoreName.Focus();
        }

        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtStoreName))
            {
                clsUtility.ShowInfoMessage("Enter Store Name           ", clsUtility.strProjectTitle);
                txtStoreName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtPlace))
            {
                clsUtility.ShowInfoMessage("Enter Place for " + txtStoreName.Text + " Store", clsUtility.strProjectTitle);
                txtPlace.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(cmbStoreCategory))
            {
                clsUtility.ShowInfoMessage("Select store category.", clsUtility.strProjectTitle);
                cmbStoreCategory.Focus();
                return false;
            }
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
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreName='" + txtStoreName.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreName='" + txtStoreName.Text + "' AND StoreID !=" + i);
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
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreID,StoreName,Tel,Place,Fax,(CASE ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus,(CASE StoreCategory WHEN 0 THEN 'Normal Store' WHEN 1 THEN 'Warehouse' END) StoreCategory,StoreCategory [StoreCategoryID] ", "StoreName");
            if (ObjUtil.ValidateTable(dt))
            {
                dgvStore.DataSource = dt;
            }
            else
            {
                dgvStore.DataSource = null;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpStore.Enabled = true;
            txtStoreName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetColumnData("StoreName", SqlDbType.NVarChar, txtStoreName.Text.Trim());
                        ObjDAL.SetColumnData("Tel", SqlDbType.VarChar, txtPhoneNo.Text.Trim());
                        ObjDAL.SetColumnData("Fax", SqlDbType.VarChar, txtFaxNo.Text.Trim());
                        ObjDAL.SetColumnData("Place", SqlDbType.NVarChar, txtPlace.Text.Trim());
                        ObjDAL.SetColumnData("StoreCategory", SqlDbType.Int, cmbStoreCategory.SelectedIndex);
                        ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                        if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblStoreMaster", true) > 0)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);

                            clsUtility.ShowInfoMessage("Store : '" + txtStoreName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            grpStore.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Store : '" + txtStoreName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("Store : '" + txtStoreName.Text + "' is already exist..", clsUtility.strProjectTitle);
                        txtStoreName.Focus();
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
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpStore.Enabled = true;
                txtStoreName.Focus();
                txtStoreName.SelectionStart = txtStoreName.MaxLength;
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(ID))
                    {
                        ObjDAL.UpdateColumnData("StoreName", SqlDbType.NVarChar, txtStoreName.Text.Trim());
                        ObjDAL.UpdateColumnData("Tel", SqlDbType.VarChar, txtPhoneNo.Text.Trim());
                        ObjDAL.UpdateColumnData("Fax", SqlDbType.VarChar, txtFaxNo.Text.Trim());
                        ObjDAL.UpdateColumnData("Place", SqlDbType.NVarChar, txtPlace.Text.Trim());
                        ObjDAL.UpdateColumnData("StoreCategory", SqlDbType.Int, cmbStoreCategory.SelectedIndex);
                        ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test
                        ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreID = " + ID + "") > 0)
                        {
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);
                            clsUtility.ShowInfoMessage("'" + txtStoreName.Text + "' Store is Updated", clsUtility.strProjectTitle);
                            LoadData();
                            ClearAll();
                            grpStore.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtStoreName.Text + "' Store is not Updated", clsUtility.strProjectTitle);
                            ObjDAL.ResetData();
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtStoreName.Text + "' Store is already exist..", clsUtility.strProjectTitle);
                        txtStoreName.Focus();
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
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Store_Master, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtStoreName.Text + "' Store ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreID=" + ID) > 0)
                    {
                        clsUtility.ShowInfoMessage("'" + txtStoreName.Text + "' Store is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpStore.Enabled = false;
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtStoreName.Text + "' Store is not deleted  ", clsUtility.strProjectTitle);
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
                grpStore.Enabled = false;
            }
        }

        private void dgvStore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ClearAll();
                    //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, clsUtility.IsAdmin);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);

                    ID = Convert.ToInt32(dgvStore.SelectedRows[0].Cells["StoreID"].Value);
                    txtStoreName.Text = dgvStore.SelectedRows[0].Cells["StoreName"].Value.ToString();
                    txtPhoneNo.Text = dgvStore.SelectedRows[0].Cells["Tel"].Value.ToString();
                    txtFaxNo.Text = dgvStore.SelectedRows[0].Cells["Fax"].Value.ToString();
                    txtPlace.Text = dgvStore.SelectedRows[0].Cells["Place"].Value.ToString();
                    cmbActiveStatus.SelectedItem = dgvStore.SelectedRows[0].Cells["ActiveStatus"].Value.ToString();
                    cmbStoreCategory.SelectedIndex = Convert.ToInt32(dgvStore.SelectedRows[0].Cells["StoreCategoryID"].Value);

                    grpStore.Enabled = false;
                    txtStoreName.Focus();
                }
                catch { }
            }
        }

        private void txtStoreName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPlace.Focus();
                return;
            }
        }

        private void txtPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPhoneNo.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtStoreName.Focus();
                txtStoreName.SelectionStart = txtStoreName.MaxLength;
                return;
            }
        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtFaxNo.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtPlace.Focus();
                txtPlace.SelectionStart = txtPlace.MaxLength;
                return;
            }
        }

        private void txtFaxNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbStoreCategory.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtPhoneNo.Focus();
                txtPhoneNo.SelectionStart = txtPhoneNo.Text.Length;
                return;
            }
        }

        private void cmbStoreCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbActiveStatus.Focus();
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtFaxNo.Focus();
                txtFaxNo.SelectionStart = txtFaxNo.MaxLength;
                return;
            }
        }

        private void cmbActiveStatus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                cmbStoreCategory.Focus();
                return;
            }
        }

        private void frmStoreMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);
            grpStore.Enabled = false;
            txtSearchByStoreName.Enabled = false;
            LoadData();
        }

        private void rdSearchByStoreName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByStoreName.Checked)
            {
                txtSearchByStoreName.Enabled = true;
                txtSearchByStoreName.Focus();
            }
            else
            {
                txtSearchByStoreName.Enabled = false;
                txtSearchByStoreName.Clear();
            }
        }

        private void rdShowAllOfStores_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllOfStores.Checked)
            {
                txtSearchByStoreName.Enabled = false;
                txtSearchByStoreName.Clear();
                LoadData();
            }
        }

        private void txtSearchByStoreName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByStoreName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblStoreMaster", "StoreID, StoreName, Tel, Fax, Place, (CASE ActiveStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'InActive' END) ActiveStatus,(CASE StoreCategory WHEN 0 THEN 'Normal Store' WHEN 1 THEN 'Warehouse' END) StoreCategory,StoreCategory [StoreCategoryID] ", "StoreName LIKE '%" + txtSearchByStoreName.Text + "%'", "StoreName");

            if (ObjUtil.ValidateTable(dt))
            {
                dgvStore.DataSource = dt;
            }
            else
            {
                dgvStore.DataSource = null;
            }
        }

        private void dgvStore_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGridStyle(dgvStore);
            dgvStore.Columns["StoreID"].Visible = false;
            dgvStore.Columns["StoreCategoryID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvStore.Rows.Count.ToString();
        }

        private void txtStoreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ObjUtil.IsString(e);
            if (e.Handled == true)
            {
                clsUtility.ShowInfoMessage("Enter Only Charactors...", clsUtility.strProjectTitle);
                txtStoreName.Focus();
            }
        }
    }
}
