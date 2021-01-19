
namespace IMS_Client_4.Settings
{
    partial class frmCurrencyValueSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyValueSetting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grpCustomer = new gGlowBox.gGlowGroupBox();
            this.cmbCountry = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCurrencyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCurrencyCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCurrencyRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCurrencyRate = new System.Windows.Forms.Label();
            this.btnStorePopup = new System.Windows.Forms.Button();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gGlowGroupBox2 = new gGlowBox.gGlowGroupBox();
            this.dataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.gGlowGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IMS_Client_4.Properties.Resources.titlebg_green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 49);
            this.panel1.TabIndex = 384;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Value Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(617, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnCancel.Size = new System.Drawing.Size(93, 35);
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 12;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 390;
            this.btnCancel.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(499, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 12;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 389;
            this.btnDelete.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(381, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnUpdate.Size = new System.Drawing.Size(93, 35);
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 12;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 388;
            this.btnUpdate.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnUpdate.Values.Text = "Update";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(263, 67);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 12;
            this.btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.TabIndex = 387;
            this.btnEdit.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnEdit.Values.Text = "Edit";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(145, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnSave.Size = new System.Drawing.Size(93, 35);
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 12;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 386;
            this.btnSave.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnSave.Values.Text = "Save";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(27, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 12;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 385;
            this.btnAdd.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnAdd.Values.Text = "+ New";
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(12, 119);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(712, 245);
            this.kryptonHeaderGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.kryptonHeaderGroup3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup3.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Back.Image = global::IMS_Client_4.Properties.Resources.titlebg_green;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.TabIndex = 391;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Currency Value Settings";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.currencysm;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.grpCustomer);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(704, 206);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.btnStorePopup);
            this.grpCustomer.Controls.Add(this.txtCurrencyRate);
            this.grpCustomer.Controls.Add(this.lblCurrencyRate);
            this.grpCustomer.Controls.Add(this.cmbCountry);
            this.grpCustomer.Controls.Add(this.txtCurrencyName);
            this.grpCustomer.Controls.Add(this.txtCurrencyCode);
            this.grpCustomer.Controls.Add(this.lblCountry);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.lblCurrencyName);
            this.grpCustomer.Controls.Add(this.lblCurrencyCode);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.ForeColor = System.Drawing.Color.Black;
            this.grpCustomer.GlowAmount = 20;
            this.grpCustomer.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.grpCustomer.GlowFeather = 70;
            this.grpCustomer.GlowOn = true;
            this.grpCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(704, 206);
            this.grpCustomer.TabIndex = 287;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownWidth = 313;
            this.cmbCountry.Location = new System.Drawing.Point(235, 17);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(313, 31);
            this.cmbCountry.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCountry.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbCountry.StateCommon.ComboBox.Border.Width = 1;
            this.cmbCountry.StateCommon.Item.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCountry.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCountry.TabIndex = 383;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(235, 109);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(313, 35);
            this.txtCurrencyName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCurrencyName.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrencyName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyName.StateCommon.Border.Rounding = 10;
            this.txtCurrencyName.StateCommon.Border.Width = 1;
            this.txtCurrencyName.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyName.StateNormal.Border.Rounding = 20;
            this.txtCurrencyName.TabIndex = 380;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Location = new System.Drawing.Point(235, 61);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(313, 35);
            this.txtCurrencyCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCurrencyCode.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrencyCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyCode.StateCommon.Border.Rounding = 10;
            this.txtCurrencyCode.StateCommon.Border.Width = 1;
            this.txtCurrencyCode.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyCode.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyCode.StateNormal.Border.Rounding = 20;
            this.txtCurrencyCode.TabIndex = 379;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(80, 24);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(80, 21);
            this.lblCountry.TabIndex = 286;
            this.lblCountry.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(553, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 282;
            this.label8.Text = "*";
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrencyName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.lblCurrencyName.Location = new System.Drawing.Point(80, 118);
            this.lblCurrencyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(136, 21);
            this.lblCurrencyName.TabIndex = 2;
            this.lblCurrencyName.Text = "Currency Name :";
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.AutoSize = true;
            this.lblCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrencyCode.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyCode.ForeColor = System.Drawing.Color.Black;
            this.lblCurrencyCode.Location = new System.Drawing.Point(80, 71);
            this.lblCurrencyCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(134, 21);
            this.lblCurrencyCode.TabIndex = 0;
            this.lblCurrencyCode.Text = "Currency Code :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IMS_Client_4.Properties.Resources.currencywhite;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtCurrencyRate
            // 
            this.txtCurrencyRate.Location = new System.Drawing.Point(235, 157);
            this.txtCurrencyRate.Name = "txtCurrencyRate";
            this.txtCurrencyRate.Size = new System.Drawing.Size(313, 35);
            this.txtCurrencyRate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCurrencyRate.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrencyRate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyRate.StateCommon.Border.Rounding = 10;
            this.txtCurrencyRate.StateCommon.Border.Width = 1;
            this.txtCurrencyRate.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyRate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrencyRate.StateNormal.Border.Rounding = 20;
            this.txtCurrencyRate.TabIndex = 385;
            // 
            // lblCurrencyRate
            // 
            this.lblCurrencyRate.AutoSize = true;
            this.lblCurrencyRate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrencyRate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRate.ForeColor = System.Drawing.Color.Black;
            this.lblCurrencyRate.Location = new System.Drawing.Point(80, 165);
            this.lblCurrencyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrencyRate.Name = "lblCurrencyRate";
            this.lblCurrencyRate.Size = new System.Drawing.Size(127, 21);
            this.lblCurrencyRate.TabIndex = 384;
            this.lblCurrencyRate.Text = "Currency Rate :";
            // 
            // btnStorePopup
            // 
            this.btnStorePopup.BackColor = System.Drawing.Color.Transparent;
            this.btnStorePopup.BackgroundImage = global::IMS_Client_4.Properties.Resources.AddButton;
            this.btnStorePopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorePopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpCustomer.SetEffectType(this.btnStorePopup, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnStorePopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStorePopup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorePopup.Location = new System.Drawing.Point(580, 18);
            this.btnStorePopup.Margin = new System.Windows.Forms.Padding(4);
            this.btnStorePopup.Name = "btnStorePopup";
            this.grpCustomer.SetsGlowColor(this.btnStorePopup, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnStorePopup.sGlowColor"))));
            this.btnStorePopup.Size = new System.Drawing.Size(36, 30);
            this.btnStorePopup.TabIndex = 392;
            this.btnStorePopup.UseVisualStyleBackColor = false;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(12, 370);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonPanel3);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(712, 254);
            this.kryptonHeaderGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup2.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.Image = global::IMS_Client_4.Properties.Resources.titlebg_green;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.TabIndex = 392;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Currency Rate Details";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.Grid;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.gGlowGroupBox2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(710, 193);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.TabIndex = 0;
            // 
            // gGlowGroupBox2
            // 
            this.gGlowGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox2.Controls.Add(this.dataGridView1);
            this.gGlowGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGlowGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.gGlowGroupBox2.GlowAmount = 20;
            this.gGlowGroupBox2.GlowColorDefault = System.Drawing.Color.White;
            this.gGlowGroupBox2.GlowFeather = 70;
            this.gGlowGroupBox2.GlowOn = true;
            this.gGlowGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.gGlowGroupBox2.Name = "gGlowGroupBox2";
            this.gGlowGroupBox2.Size = new System.Drawing.Size(710, 193);
            this.gGlowGroupBox2.TabIndex = 287;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox2.SetEffectType(this.dataGridView1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.gGlowGroupBox2.SetsGlowColor(this.dataGridView1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dataGridView1.sGlowColor"))));
            this.dataGridView1.Size = new System.Drawing.Size(710, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmCurrencyValueSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 624);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCurrencyValueSetting";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Value Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.gGlowGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private gGlowBox.gGlowGroupBox grpCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCountry;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrencyName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrencyCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrencyRate;
        private System.Windows.Forms.Label lblCurrencyRate;
        private System.Windows.Forms.Button btnStorePopup;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private gGlowBox.gGlowGroupBox gGlowGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView1;
    }
}