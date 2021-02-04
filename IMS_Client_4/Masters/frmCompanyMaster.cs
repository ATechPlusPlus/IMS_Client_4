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
    public partial class frmCompanyMaster : KryptonForm
    {
        public frmCompanyMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);

        int ID = 0;

        private void frmCompanyMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);
            txtSearchByCompanyName.Enabled = false;
            txtSearchByCompanyMobileNo.Enabled = false;
            dgvCompanyMaster.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            //Most time consumption enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgvCompanyMaster.RowHeadersVisible = false; // set it to false if not needed

            LoadData();

            grpCompany.Enabled = false;
        }

        private void ClearAll()
        {
            txtCompanyName.Clear();
            txtCompanyAddress.Clear();
            txtCompanyMobileNo.Clear();
            txtCompanyEmailID.Clear();
            chkDefaultCompany.Checked = false;
            PicCompanyLogo.Image = null;
            txtCompanyName.Focus();
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
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_CompanyMaster");
            if (ObjUtil.ValidateDataSet(ds))
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCompanyMaster.DataSource = dt;
                }
                else
                {
                    dgvCompanyMaster.DataSource = null;
                }
            }
            else
            {
                dgvCompanyMaster.DataSource = null;
            }
        }

        private bool ValidateForm()
        {
            if (ObjUtil.IsControlTextEmpty(txtCompanyName))
            {
                clsUtility.ShowInfoMessage("Enter Company Name       ", clsUtility.strProjectTitle);
                txtCompanyName.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Company Mobile No.      ", clsUtility.strProjectTitle);
                txtCompanyMobileNo.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyEmailID))
            {
                clsUtility.ShowInfoMessage("Enter Company Email ID.      ", clsUtility.strProjectTitle);
                txtCompanyEmailID.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCompanyAddress))
            {
                clsUtility.ShowInfoMessage("Enter Company Address.      ", clsUtility.strProjectTitle);
                txtCompanyAddress.Focus();
                return false;
            }
            else if (chkDefaultCompany.Checked)
            {
                int a = ObjDAL.ExecuteScalarInt("SELECT COUNT(1) FROM " + clsUtility.DBName + ".dbo.tblCompanyMaster WITH(NOLOCK) WHERE ISNULL(IsDefault,0)=1");
                if (a > 0 && ID == 0)
                {
                    clsUtility.ShowInfoMessage("Already Default Company is presnet..");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private bool DuplicateUser(int i)
        {
            int a = 0;
            if (i == 0)
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCompanyMaster", "MobileNo='" + txtCompanyMobileNo.Text.Trim() + "'");
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCompanyMaster", "MobileNo='" + txtCompanyMobileNo.Text + "' AND CompanyID !=" + i);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpCompany.Enabled = true;
            txtCompanyName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.frmCompanyMaster, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
                if (ValidateForm())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, txtCompanyName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCompanyMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCompanyEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCompanyAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("IsDefault", SqlDbType.Bit, chkDefaultCompany.Checked, clsConnection_DAL.ParamType.Input);
                        if (PicCompanyLogo.Image != null)
                        {
                            ObjDAL.SetStoreProcedureData("CompanyLogo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicCompanyLogo.Image), clsConnection_DAL.ParamType.Input);
                        }
                        else
                        {
                           ObjDAL.SetStoreProcedureData("CompanyLogo", SqlDbType.VarBinary,DBNull.Value);
                        }
                        ObjDAL.SetStoreProcedureData("CreatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Insert_CompanyMaster");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Company Name : '" + txtCompanyName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            grpCompany.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Company Name : '" + txtCompanyName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is already exist..", clsUtility.strProjectTitle);
                        txtCompanyName.Focus();
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
                grpCompany.Enabled = true;
                txtCompanyName.Focus();
                txtCompanyName.SelectionStart = txtCompanyName.MaxLength;
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
                        ObjDAL.SetStoreProcedureData("CompanyID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, txtCompanyName.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("Address", SqlDbType.NVarChar, txtCompanyAddress.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.VarChar, txtCompanyMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("EmailID", SqlDbType.VarChar, txtCompanyEmailID.Text.Trim(), clsConnection_DAL.ParamType.Input);
                        ObjDAL.SetStoreProcedureData("IsDefault", SqlDbType.Bit, chkDefaultCompany.Checked, clsConnection_DAL.ParamType.Input);
                        if (PicCompanyLogo.Image != null)
                        {
                            ObjDAL.SetStoreProcedureData("CompanyLogo", SqlDbType.VarBinary, ObjUtil.GetImageBytes(PicCompanyLogo.Image), clsConnection_DAL.ParamType.Input);
                        }
                        else
                        {
                            ObjDAL.SetStoreProcedureData("CompanyLogo", SqlDbType.VarBinary, DBNull.Value);
                        }
                        ObjDAL.SetStoreProcedureData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID, clsConnection_DAL.ParamType.Input);

                        bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Update_CompanyMaster");
                        if (b)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                            clsUtility.ShowInfoMessage("'" + txtCompanyName.Text + "' Company is Updated", clsUtility.strProjectTitle);
                            ID = 0;
                            LoadData();
                            ClearAll();
                            grpCompany.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is not Updated", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is already exist..", clsUtility.strProjectTitle);
                        txtCompanyName.Focus();
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
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCompanyName.Text + "' Company ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    ObjDAL.SetStoreProcedureData("CompanyID", SqlDbType.Int, ID, clsConnection_DAL.ParamType.Input);
                    bool b = ObjDAL.ExecuteStoreProcedure_DML(clsUtility.DBName + ".dbo.sp_Delete_CompanyMaster");
                    if (b)
                    {
                        clsUtility.ShowInfoMessage("'" + txtCompanyName.Text + "' Company is deleted  ", clsUtility.strProjectTitle);
                        ID = 0;
                        ClearAll();
                        LoadData();
                        grpCompany.Enabled = false;
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCompanyName.Text + "' Company is not deleted  ", clsUtility.strProjectTitle);
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
                grpCompany.Enabled = false;
            }
        }

        private void dgvCompanyMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);
                    ID = Convert.ToInt32(dgvCompanyMaster.SelectedRows[0].Cells["CompanyID"].Value);
                    txtCompanyName.Text = dgvCompanyMaster.SelectedRows[0].Cells["CompanyName"].Value.ToString();
                    txtCompanyAddress.Text = dgvCompanyMaster.SelectedRows[0].Cells["Address"].Value.ToString();
                    txtCompanyMobileNo.Text = dgvCompanyMaster.SelectedRows[0].Cells["MobileNo"].Value.ToString();
                    txtCompanyEmailID.Text = dgvCompanyMaster.SelectedRows[0].Cells["EmailID"].Value.ToString();
                    chkDefaultCompany.Checked = Convert.ToBoolean(dgvCompanyMaster.SelectedRows[0].Cells["DefaultValue"].Value);
                    if (dgvCompanyMaster.SelectedRows[0].Cells["CompanyLogo"].Value != DBNull.Value)
                    {
                        PicCompanyLogo.Image = ObjUtil.GetImage((byte[])dgvCompanyMaster.SelectedRows[0].Cells["CompanyLogo"].Value);
                    }
                    else
                    {
                        PicCompanyLogo.Image = null;
                    }
                    
                    grpCompany.Enabled = false;
                    txtCompanyName.Focus();
                }
                catch { }
            }
        }

        private void dgvCompanyMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGridStyle(dgvCompanyMaster);
            dgvCompanyMaster.Columns["CompanyID"].Visible = false;
            dgvCompanyMaster.Columns["IsDefault"].Visible = false;
            dgvCompanyMaster.Columns["CompanyLogo"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvCompanyMaster.Rows.Count.ToString();
        }

        private void rdSearchByCompanyName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCompanyName.Checked)
            {
                txtSearchByCompanyName.Enabled = true;
                txtSearchByCompanyName.Focus();
            }
            else
            {
                txtSearchByCompanyName.Enabled = false;
                txtSearchByCompanyName.Clear();
            }
        }

        private void rdSearchByCompanyMobileNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCompanyMobileNo.Checked)
            {
                txtSearchByCompanyMobileNo.Enabled = true;
                txtSearchByCompanyMobileNo.Focus();
            }
            else
            {
                txtSearchByCompanyMobileNo.Enabled = false;
                txtSearchByCompanyMobileNo.Clear();
            }
        }

        private void txtSearchByCompanyMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCompanyMobileNo.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, 0, clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.NVarChar, txtSearchByCompanyMobileNo.Text.Trim(), clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_CompanyMaster");
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCompanyMaster.DataSource = dt;
                }
                else
                {
                    dgvCompanyMaster.DataSource = null;
                }
            }
            else
            {
                dgvCompanyMaster.DataSource = null;
            }
        }

        private void lklBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicCompanyLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void lklCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicCompanyLogo.Image = null;
        }

        private void txtSearchByCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCompanyName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            ObjDAL.SetStoreProcedureData("CompanyName", SqlDbType.NVarChar, txtSearchByCompanyName.Text.Trim(), clsConnection_DAL.ParamType.Input);
            ObjDAL.SetStoreProcedureData("MobileNo", SqlDbType.NVarChar, 0, clsConnection_DAL.ParamType.Input);
            DataSet ds = ObjDAL.ExecuteStoreProcedure_Get(clsUtility.DBName + ".dbo.sp_Get_CompanyMaster");
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (ObjUtil.ValidateTable(dt))
                {
                    dgvCompanyMaster.DataSource = dt;
                }
                else
                {
                    dgvCompanyMaster.DataSource = null;
                }
            }
            else
            {
                dgvCompanyMaster.DataSource = null;
            }
        }
        
    }
}
