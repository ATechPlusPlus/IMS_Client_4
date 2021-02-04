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
    public partial class frmCountryMaster : KryptonForm
    {
        public frmCountryMaster()
        {
            InitializeComponent();
        }

        clsUtility ObjUtil = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);


        int ID = 0;

        private void ClearAll()
        {
            txtCountryCode.Clear();
            txtCountryName.Clear();
            txtSearchByCountryName.Clear();
            cmbActiveStatus.SelectedIndex = -1;

            txtCountryCode.Focus();
        }


        private bool Validateform()
        {
            if (ObjUtil.IsControlTextEmpty(txtCountryCode))
            {
                clsUtility.ShowInfoMessage("Enter Country Code           ", clsUtility.strProjectTitle);
                txtCountryCode.Focus();
                return false;
            }
            else if (ObjUtil.IsControlTextEmpty(txtCountryName))
            {
                clsUtility.ShowInfoMessage("Enter Country Name            ", clsUtility.strProjectTitle);
                txtCountryName.Focus();
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
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryName='" + txtCountryName.Text.Trim() + "'");
                if (a == 0)
                {
                    a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryCode='" + txtCountryCode.Text + "'");
                }
            }
            else
            {
                a = ObjDAL.CountRecords(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryID !=" + i + " AND (CountryName ='" + txtCountryName.Text + "' OR CountryCode = '" + txtCountryCode.Text + "')");
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.StateCommon.DataCell.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
            dgv.StateCommon.HeaderColumn.Content.Font = new Font("Times New Roman", 11.00f, FontStyle.Regular);
        }

        private void LoadData()
        {
            DataTable dt = null;
            dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryID,CountryCode,CountryName,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "CountryName");

            if (ObjUtil.ValidateTable(dt))
            {
                dgvCountry.DataSource = dt;
            }
            else
            {
                dgvCountry.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew, clsUtility.IsAdmin);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterNew);
            grpCountryDetails.Enabled = true;
            txtCountryCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Country_Master, clsFormRights.Operation.Save) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(0))
                    {
                        ObjDAL.SetColumnData("CountryCode", SqlDbType.NVarChar, txtCountryCode.Text.Trim());
                        ObjDAL.SetColumnData("CountryName", SqlDbType.NVarChar, txtCountryName.Text);
                        ObjDAL.SetColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.SetColumnData("CreatedBy", SqlDbType.Int, clsUtility.LoginID); //if LoginID=0 then Test Admin else user
                        if (ObjDAL.InsertData(clsUtility.DBName + ".dbo.tblCountryMaster", true) > 0)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterSave);
                            clsUtility.ShowInfoMessage("Country Name : '" + txtCountryName.Text + "' is Saved Successfully..", clsUtility.strProjectTitle);
                            ClearAll();
                            LoadData();
                            grpCountryDetails.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowInfoMessage("Country Name : '" + txtCountryName.Text + "' is not Saved Successfully..", clsUtility.strProjectTitle);
                        }
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCountryName.Text + "' Country Name OR Country Code is already exist..", clsUtility.strProjectTitle);
                        txtCountryName.Focus();
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
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Country_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit, clsUtility.IsAdmin);
                ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterEdit);
                grpCountryDetails.Enabled = true;
                txtCountryCode.Focus();
                txtCountryCode.SelectionStart = txtCountryCode.MaxLength;
            //}
            //else
            //{
            //    clsUtility.ShowInfoMessage("You have no rights to perform this task", clsUtility.strProjectTitle);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Country_Master, clsFormRights.Operation.Update) || clsUtility.IsAdmin)
            //{
                if (Validateform())
                {
                    if (DuplicateUser(ID))
                    {
                        ObjDAL.UpdateColumnData("CountryCode", SqlDbType.NVarChar, txtCountryCode.Text.Trim());
                        ObjDAL.UpdateColumnData("CountryName", SqlDbType.NVarChar, txtCountryName.Text);
                        ObjDAL.UpdateColumnData("ActiveStatus", SqlDbType.Bit, cmbActiveStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        ObjDAL.UpdateColumnData("UpdatedBy", SqlDbType.Int, clsUtility.LoginID);
                        ObjDAL.UpdateColumnData("UpdatedOn", SqlDbType.DateTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        if (ObjDAL.UpdateData(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryID = " + ID + "") > 0)
                        {
                            //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate, clsUtility.IsAdmin);
                            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterUpdate);

                            clsUtility.ShowInfoMessage("'" + txtCountryName.Text + "' Country Name is Updated", clsUtility.strProjectTitle);
                            LoadData();
                            ClearAll();
                            grpCountryDetails.Enabled = false;
                        }
                        else
                        {
                            clsUtility.ShowErrorMessage("'" + txtCountryName.Text + "' Country Name is not Updated", clsUtility.strProjectTitle);
                        }
                        ObjDAL.ResetData();
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCountryName.Text + "' Country Name is already exist..", clsUtility.strProjectTitle);
                        txtCountryName.Focus();
                        ObjDAL.ResetData();
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
            //if (clsFormRights.HasFormRight(clsFormRights.Forms.Country_Master, clsFormRights.Operation.Delete) || clsUtility.IsAdmin)
            //{
                DialogResult d = MessageBox.Show("Are you sure want to delete '" + txtCountryName.Text + "' Country ", clsUtility.strProjectTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    if (ObjDAL.DeleteData(clsUtility.DBName + ".dbo.CountryMaster", "CountryID = " + ID + "") > 0)
                    {
                        clsUtility.ShowInfoMessage("'" + txtCountryName.Text + "' Country Name is deleted  ", clsUtility.strProjectTitle);
                        ClearAll();
                        LoadData();
                        grpCountryDetails.Enabled = false;
                        //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete, clsUtility.IsAdmin);
                        ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterDelete);
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("'" + txtCountryName.Text + "' Country Name is not deleted  ", clsUtility.strProjectTitle);
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
                grpCountryDetails.Enabled = false;
            }
        }

        private void dgvCountry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
            {
                try
                {
                    ID = Convert.ToInt32(dgvCountry.SelectedRows[0].Cells["CountryID"].Value);
                    //ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick, clsUtility.IsAdmin);
                    ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.AfterGridClick);

                    txtCountryCode.Text = dgvCountry.SelectedRows[0].Cells["CountryCode"].Value.ToString();
                    txtCountryName.Text = dgvCountry.SelectedRows[0].Cells["CountryName"].Value.ToString();
                    cmbActiveStatus.SelectedItem = dgvCountry.SelectedRows[0].Cells["ActiveStatus"].Value.ToString();

                    grpCountryDetails.Enabled = false;
                    txtCountryCode.Focus();
                }
                catch { }
            }
        }

        private void frmCountryMaster_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
            ObjUtil.RegisterCommandButtons(btnAdd, btnSave, btnEdit, btnUpdate, btnDelete, btnCancel);
            ObjUtil.SetCommandButtonStatus(clsCommon.ButtonStatus.Beginning);
            dgvCountry.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            dgvCountry.RowHeadersVisible = false;
            txtSearchByCountryName.Enabled = false;

            LoadData();

            grpCountryDetails.Enabled = false;

        }

        private void txtSearchByCountryName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCountryName.Text.Trim().Length == 0)
            {
                LoadData();
                return;
            }
            DataTable dt = ObjDAL.GetDataCol(clsUtility.DBName + ".dbo.tblCountryMaster", "CountryID,CountryCode,CountryName,(CASE WHEN ActiveStatus =1 THEN 'Active' WHEN ActiveStatus =0 THEN 'InActive' END) ActiveStatus", "CountryName LIKE '%" + txtSearchByCountryName.Text + "%'", "CountryName");
            if (ObjUtil.ValidateTable(dt))
            {
                dgvCountry.DataSource = dt;
            }
            else
            {
                dgvCountry.DataSource = null;
            }
        }

        private void rdShowAllOfCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowAllOfCountry.Checked)
            {
                txtSearchByCountryName.Enabled = false;
                txtSearchByCountryName.Clear();
                LoadData();
            }
        }

        private void rdSearchByCountryName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSearchByCountryName.Checked)
            {
                txtSearchByCountryName.Enabled = true;
                txtSearchByCountryName.Focus();
            }
            else
            {
                txtSearchByCountryName.Enabled = false;
                txtSearchByCountryName.Clear();
                rdShowAllOfCountry.Checked = true;
            }
        }

        private void dgvCountry_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGridStyle(dgvCountry);
            dgvCountry.Columns["CountryID"].Visible = false;
            kryptonHeaderGroup2.ValuesSecondary.Description = "Total Records : " + dgvCountry.Rows.Count.ToString();
        }
    }
}
