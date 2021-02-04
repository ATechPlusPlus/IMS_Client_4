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
    public partial class frmProduct_ItemMaster : KryptonForm
    {
        public frmProduct_ItemMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblProductMaster", "Barcodes='" + txtBarcode.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblProductMaster", "Barcodes='" + txtBarcode.Text + "' AND ProductID !=" + i);
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

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtProductName))
            {
                clsUtility.ShowInfoMessage("Enter Product Name.       ", clsUtility.strProjectTitle);
                txtProductName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtBarcode))
            {
                clsUtility.ShowInfoMessage("Enter Barcode.      ", clsUtility.strProjectTitle);
                txtBarcode.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtWeight))
            {
                clsUtility.ShowInfoMessage("Enter Product Weight.      ", clsUtility.strProjectTitle);
                txtWeight.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtPack))
            {
                clsUtility.ShowInfoMessage("Enter Package.      ", clsUtility.strProjectTitle);
                txtPack.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtUnitPrice))
            {
                clsUtility.ShowInfoMessage("Enter Unit Price.      ", clsUtility.strProjectTitle);
                txtUnitPrice.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCartonPrice))
            {
                clsUtility.ShowInfoMessage("Enter Carton Price.      ", clsUtility.strProjectTitle);
                txtCartonPrice.Focus();
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

        private void ClearAll()
        {
            txtProductName.Clear();
            txtBarcode.Clear();
            txtWeight.Clear();
            txtPack.Clear();
            txtUnitPrice.Clear();
            txtCartonPrice.Clear();
            cmbActiveStatus.SelectedIndex = -1;
            ID = 0;
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
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_Product_Master");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvProducts.DataSource = dt;
                }
                else
                {
                    dgvProducts.DataSource = null;
                }
            }
            else
            {
                dgvProducts.DataSource = null;
            }
        }

        private void frmProduct_ItemMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);

            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvProducts.RowHeadersVisible = false; // set it to false if not needed

            LoadData();

            grpProduct.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpProduct.Enabled = true;
            txtProductName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
            if (ValidateForm())
            {
                if (DuplicateUser(0))
                {
                    ObjDAL.SetStoreProcedureData("Barcodes", SqlDbType.NVarChar, txtBarcode.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("ProductName", SqlDbType.NVarChar, txtProductName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Weight", SqlDbType.NVarChar, txtWeight.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Packs", SqlDbType.Int, txtPack.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("UnitPrice", SqlDbType.Decimal, txtUnitPrice.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CartonPrice", SqlDbType.Decimal, txtCartonPrice.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedValue, clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Insert_Product_Master");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                        clsUtility.ShowInfoMessage("Product Name : '" + txtProductName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpProduct.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("Product Name : '" + txtProductName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtProductName.Text + "' Barcode is already exist..", clsUtility.strProjectTitle);
                    txtProductName.Focus();
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
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
            grpProduct.Enabled = true;
            txtProductName.Focus();
            txtProductName.SelectionStart = txtProductName.MaxLength;
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
                    ObjDAL.SetStoreProcedureData("ProductID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);

                    ObjDAL.SetStoreProcedureData("Barcodes", SqlDbType.NVarChar, txtBarcode.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("ProductName", SqlDbType.NVarChar, txtProductName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Weight", SqlDbType.NVarChar, txtWeight.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("Packs", SqlDbType.Int, txtPack.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("UnitPrice", SqlDbType.Decimal, txtUnitPrice.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("CartonPrice", SqlDbType.Decimal, txtCartonPrice.Text.Trim(), clsConnection_DAL.ParamType.Input);
                    ObjDAL.SetStoreProcedureData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0, clsConnection_DAL.ParamType.Input);
                    //ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);


                    ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Update_Product_Master");
                    if (b)
                    {
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                        clsUtility.ShowInfoMessage("'" + txtProductName.Text + "' Product is Updated", clsUtility.strProjectTitle);
                        ID = 0;
                        LoadData();
                        ClearAll();
                        grpProduct.Enabled = false;
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtProductName.Text + "' Product is not Updated", clsUtility.strProjectTitle);
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtProductName.Text + "' Barcode is already exist..", clsUtility.strProjectTitle);
                    txtProductName.Focus();
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
            DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtProductName.Text + "' Product ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                ObjDAL.SetStoreProcedureData("ProductID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Delete_Product_Master");
                if (b)
                {
                    clsUtility.ShowInfoMessage("'" + txtProductName.Text + "' Product is deleted  ", clsUtility.strProjectTitle);
                    ID = 0;
                    ClearAll();
                    LoadData();
                    grpProduct.Enabled = false;
                    //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                }
                else
                {
                    clsUtility.ShowErrorMessage("'" + txtProductName.Text + "' Product is not deleted  ", clsUtility.strProjectTitle);
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
                grpProduct.Enabled = false;
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
                    txtProductName.Text = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                    txtBarcode.Text = dgvProducts.SelectedRows[0].Cells["Barcodes"].Value.ToString();
                    txtWeight.Text = dgvProducts.SelectedRows[0].Cells["Weight"].Value.ToString();
                    txtPack.Text = dgvProducts.SelectedRows[0].Cells["Packs"].Value.ToString();
                    txtUnitPrice.Text = dgvProducts.SelectedRows[0].Cells["UnitPrice"].Value.ToString();
                    txtCartonPrice.Text = dgvProducts.SelectedRows[0].Cells["CartonPrice"].Value.ToString();
                    cmbActiveStatus.SelectedItem = dgvProducts.SelectedRows[0].Cells["ActiveStatus"].Value.ToString();
                    grpProduct.Enabled = false;
                    txtProductName.Focus();
                }
                catch { }
            }
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGridStyle(dgvProducts);
            dgvProducts.Columns["ProductID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvProducts.Rows.Count.ToString();
        }

        private void rdSearchByProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByProductName.Checked)
            {
                txtSearchByProductName.Enabled = true;
                txtSearchByProductName.Focus();
                txtSearchByBarcode.Enabled = false;
                txtSearchByBarcode.Clear();
                rdShowAllOfProducts.Checked = false;
            }
            else
            {

            }
        }

        private void txtSearchByProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByProductName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblProductMaster", "ProductID,ProductName,Barcodes,Weight,Packs,UnitPrice,CartonPrice,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "CountryName LIKE '%" + txtSearchByProductName.Text + "%'", "ProductName");
            if (ObjUtil.ValidateTable(dt))
            {
                dgvProducts.DataSource = dt;
            }
            else
            {
                dgvProducts.DataSource = null;
            }
        }

        private void rdSearchByBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByBarcode.Checked)
            {
                txtSearchByBarcode.Enabled = true;
                txtSearchByBarcode.Focus();
                txtSearchByProductName.Enabled = false;
                txtSearchByProductName.Clear();
                rdShowAllOfProducts.Checked = false;
            }
            else
            {
                
            }
        }

        private void rdShowAllOfProducts_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchByProductName.Enabled = false;
            txtSearchByProductName.Clear();
            txtSearchByBarcode.Enabled = false;
            txtSearchByBarcode.Clear();
            rdSearchByProductName.Checked = false;
            rdSearchByBarcode.Checked = false;
        }
    }
}
