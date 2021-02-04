namespace IMS_Client_4.Purchase
{
    partial class frmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grpCountryDetails = new gGlowBox.gGlowGroupBox();
            this.txtQTY = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCountryCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblQTY = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbSelectOperation = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSelectOperation = new System.Windows.Forms.Label();
            this.txtRateQTY = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRateQTY = new System.Windows.Forms.Label();
            this.lblPerfomaDate = new System.Windows.Forms.Label();
            this.txtRateCTN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRateCTN = new System.Windows.Forms.Label();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gGlowGroupBox1 = new gGlowBox.gGlowGroupBox();
            this.txtSearchByPerfomaNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rdSearchByPerfomaNo = new System.Windows.Forms.RadioButton();
            this.rdShowAllPurchase = new System.Windows.Forms.RadioButton();
            this.dtpPerfomaDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtPipeLineQTY = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPipeLineQTY = new System.Windows.Forms.Label();
            this.txtAvailableStockQTY = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblAvailableStockQTY = new System.Windows.Forms.Label();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cmbSupplier = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.grpCountryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.gGlowGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IMS_Client_4.Properties.Resources.titlebg_green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IMS_Client_4.Properties.Resources.purchaseOrderwhie;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(7, 104);
            this.kryptonHeaderGroup3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(1048, 225);
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
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Border.Rounding = 7;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup3.TabIndex = 351;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Purchase Order Details";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.countrysmallwhite;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.grpCountryDetails);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1040, 188);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 0;
            // 
            // grpCountryDetails
            // 
            this.grpCountryDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpCountryDetails.Controls.Add(this.cmbSupplier);
            this.grpCountryDetails.Controls.Add(this.btnAdd);
            this.grpCountryDetails.Controls.Add(this.txtAvailableStockQTY);
            this.grpCountryDetails.Controls.Add(this.lblAvailableStockQTY);
            this.grpCountryDetails.Controls.Add(this.txtPipeLineQTY);
            this.grpCountryDetails.Controls.Add(this.lblPipeLineQTY);
            this.grpCountryDetails.Controls.Add(this.dtpPerfomaDate);
            this.grpCountryDetails.Controls.Add(this.txtRateCTN);
            this.grpCountryDetails.Controls.Add(this.lblRateCTN);
            this.grpCountryDetails.Controls.Add(this.txtRateQTY);
            this.grpCountryDetails.Controls.Add(this.lblRateQTY);
            this.grpCountryDetails.Controls.Add(this.lblPerfomaDate);
            this.grpCountryDetails.Controls.Add(this.txtQTY);
            this.grpCountryDetails.Controls.Add(this.txtCountryCode);
            this.grpCountryDetails.Controls.Add(this.lblSupplier);
            this.grpCountryDetails.Controls.Add(this.lblQTY);
            this.grpCountryDetails.Controls.Add(this.lblProduct);
            this.grpCountryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCountryDetails.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCountryDetails.ForeColor = System.Drawing.Color.Black;
            this.grpCountryDetails.GlowAmount = 20;
            this.grpCountryDetails.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.grpCountryDetails.GlowFeather = 70;
            this.grpCountryDetails.GlowOn = true;
            this.grpCountryDetails.Location = new System.Drawing.Point(0, 0);
            this.grpCountryDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCountryDetails.Name = "grpCountryDetails";
            this.grpCountryDetails.Size = new System.Drawing.Size(1040, 188);
            this.grpCountryDetails.TabIndex = 287;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(146, 58);
            this.txtQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(250, 34);
            this.txtQTY.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtQTY.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtQTY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQTY.StateCommon.Border.Rounding = 10;
            this.txtQTY.StateCommon.Border.Width = 1;
            this.txtQTY.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQTY.StateNormal.Border.Rounding = 20;
            this.txtQTY.TabIndex = 380;
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(146, 15);
            this.txtCountryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(250, 34);
            this.txtCountryCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCountryCode.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtCountryCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCountryCode.StateCommon.Border.Rounding = 10;
            this.txtCountryCode.StateCommon.Border.Width = 1;
            this.txtCountryCode.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryCode.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCountryCode.StateNormal.Border.Rounding = 20;
            this.txtCountryCode.TabIndex = 379;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(451, 22);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(81, 21);
            this.lblSupplier.TabIndex = 286;
            this.lblSupplier.Text = "Supplier :";
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.BackColor = System.Drawing.Color.Transparent;
            this.lblQTY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTY.ForeColor = System.Drawing.Color.Black;
            this.lblQTY.Location = new System.Drawing.Point(18, 64);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(57, 21);
            this.lblQTY.TabIndex = 2;
            this.lblQTY.Text = "QTY :";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(18, 22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(79, 21);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product :";
            // 
            // cmbSelectOperation
            // 
            this.cmbSelectOperation.DropDownWidth = 100;
            this.cmbSelectOperation.Items.AddRange(new object[] {
            "Barcode",
            "Manual"});
            this.cmbSelectOperation.Location = new System.Drawing.Point(174, 63);
            this.cmbSelectOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSelectOperation.Name = "cmbSelectOperation";
            this.cmbSelectOperation.Size = new System.Drawing.Size(250, 31);
            this.cmbSelectOperation.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSelectOperation.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbSelectOperation.StateCommon.ComboBox.Border.Width = 1;
            this.cmbSelectOperation.StateCommon.Item.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cmbSelectOperation.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSelectOperation.TabIndex = 385;
            // 
            // lblSelectOperation
            // 
            this.lblSelectOperation.AutoSize = true;
            this.lblSelectOperation.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectOperation.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOperation.ForeColor = System.Drawing.Color.Black;
            this.lblSelectOperation.Location = new System.Drawing.Point(22, 68);
            this.lblSelectOperation.Name = "lblSelectOperation";
            this.lblSelectOperation.Size = new System.Drawing.Size(143, 21);
            this.lblSelectOperation.TabIndex = 384;
            this.lblSelectOperation.Text = "Select Operation :";
            // 
            // txtRateQTY
            // 
            this.txtRateQTY.Location = new System.Drawing.Point(146, 141);
            this.txtRateQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRateQTY.Name = "txtRateQTY";
            this.txtRateQTY.Size = new System.Drawing.Size(250, 34);
            this.txtRateQTY.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRateQTY.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtRateQTY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRateQTY.StateCommon.Border.Rounding = 10;
            this.txtRateQTY.StateCommon.Border.Width = 1;
            this.txtRateQTY.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateQTY.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRateQTY.StateNormal.Border.Rounding = 20;
            this.txtRateQTY.TabIndex = 387;
            // 
            // lblRateQTY
            // 
            this.lblRateQTY.AutoSize = true;
            this.lblRateQTY.BackColor = System.Drawing.Color.Transparent;
            this.lblRateQTY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateQTY.ForeColor = System.Drawing.Color.Black;
            this.lblRateQTY.Location = new System.Drawing.Point(18, 148);
            this.lblRateQTY.Name = "lblRateQTY";
            this.lblRateQTY.Size = new System.Drawing.Size(96, 21);
            this.lblRateQTY.TabIndex = 385;
            this.lblRateQTY.Text = "Rate/QTY :";
            // 
            // lblPerfomaDate
            // 
            this.lblPerfomaDate.AutoSize = true;
            this.lblPerfomaDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfomaDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfomaDate.ForeColor = System.Drawing.Color.Black;
            this.lblPerfomaDate.Location = new System.Drawing.Point(18, 106);
            this.lblPerfomaDate.Name = "lblPerfomaDate";
            this.lblPerfomaDate.Size = new System.Drawing.Size(121, 21);
            this.lblPerfomaDate.TabIndex = 384;
            this.lblPerfomaDate.Text = "Perfoma Date :";
            // 
            // txtRateCTN
            // 
            this.txtRateCTN.Location = new System.Drawing.Point(634, 55);
            this.txtRateCTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRateCTN.Name = "txtRateCTN";
            this.txtRateCTN.Size = new System.Drawing.Size(250, 34);
            this.txtRateCTN.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRateCTN.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtRateCTN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRateCTN.StateCommon.Border.Rounding = 10;
            this.txtRateCTN.StateCommon.Border.Width = 1;
            this.txtRateCTN.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateCTN.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRateCTN.StateNormal.Border.Rounding = 20;
            this.txtRateCTN.TabIndex = 389;
            // 
            // lblRateCTN
            // 
            this.lblRateCTN.AutoSize = true;
            this.lblRateCTN.BackColor = System.Drawing.Color.Transparent;
            this.lblRateCTN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateCTN.ForeColor = System.Drawing.Color.Black;
            this.lblRateCTN.Location = new System.Drawing.Point(451, 64);
            this.lblRateCTN.Name = "lblRateCTN";
            this.lblRateCTN.Size = new System.Drawing.Size(96, 21);
            this.lblRateCTN.TabIndex = 388;
            this.lblRateCTN.Text = "Rate/CTN :";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(7, 334);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1048, 96);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(204)))), ((int)(((byte)(238)))));
            this.kryptonHeaderGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Image = global::IMS_Client_4.Properties.Resources.titlebg_green;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 387;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Search";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.Search;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.gGlowGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1040, 57);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // gGlowGroupBox1
            // 
            this.gGlowGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.Controls.Add(this.txtSearchByPerfomaNo);
            this.gGlowGroupBox1.Controls.Add(this.rdSearchByPerfomaNo);
            this.gGlowGroupBox1.Controls.Add(this.rdShowAllPurchase);
            this.gGlowGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGlowGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gGlowGroupBox1.GlowAmount = 20;
            this.gGlowGroupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.gGlowGroupBox1.GlowFeather = 70;
            this.gGlowGroupBox1.GlowOn = true;
            this.gGlowGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gGlowGroupBox1.Name = "gGlowGroupBox1";
            this.gGlowGroupBox1.Size = new System.Drawing.Size(1040, 57);
            this.gGlowGroupBox1.TabIndex = 287;
            // 
            // txtSearchByPerfomaNo
            // 
            this.txtSearchByPerfomaNo.Location = new System.Drawing.Point(162, 13);
            this.txtSearchByPerfomaNo.Name = "txtSearchByPerfomaNo";
            this.txtSearchByPerfomaNo.Size = new System.Drawing.Size(298, 34);
            this.txtSearchByPerfomaNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchByPerfomaNo.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearchByPerfomaNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByPerfomaNo.StateCommon.Border.Rounding = 10;
            this.txtSearchByPerfomaNo.StateCommon.Border.Width = 1;
            this.txtSearchByPerfomaNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPerfomaNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByPerfomaNo.StateNormal.Border.Rounding = 20;
            this.txtSearchByPerfomaNo.TabIndex = 383;
            // 
            // rdSearchByPerfomaNo
            // 
            this.rdSearchByPerfomaNo.AutoSize = true;
            this.rdSearchByPerfomaNo.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.SetEffectType(this.rdSearchByPerfomaNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByPerfomaNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByPerfomaNo.ForeColor = System.Drawing.Color.Black;
            this.rdSearchByPerfomaNo.Location = new System.Drawing.Point(23, 18);
            this.rdSearchByPerfomaNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByPerfomaNo.Name = "rdSearchByPerfomaNo";
            this.gGlowGroupBox1.SetsGlowColor(this.rdSearchByPerfomaNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByPerfomaNo.sGlowColor"))));
            this.rdSearchByPerfomaNo.Size = new System.Drawing.Size(131, 25);
            this.rdSearchByPerfomaNo.TabIndex = 387;
            this.rdSearchByPerfomaNo.Text = "Perfoma No :";
            this.rdSearchByPerfomaNo.UseVisualStyleBackColor = false;
            // 
            // rdShowAllPurchase
            // 
            this.rdShowAllPurchase.AutoSize = true;
            this.rdShowAllPurchase.BackColor = System.Drawing.Color.Transparent;
            this.rdShowAllPurchase.Checked = true;
            this.gGlowGroupBox1.SetEffectType(this.rdShowAllPurchase, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdShowAllPurchase.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAllPurchase.ForeColor = System.Drawing.Color.Black;
            this.rdShowAllPurchase.Location = new System.Drawing.Point(912, 18);
            this.rdShowAllPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.rdShowAllPurchase.Name = "rdShowAllPurchase";
            this.gGlowGroupBox1.SetsGlowColor(this.rdShowAllPurchase, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAllPurchase.sGlowColor"))));
            this.rdShowAllPurchase.Size = new System.Drawing.Size(99, 25);
            this.rdShowAllPurchase.TabIndex = 388;
            this.rdShowAllPurchase.TabStop = true;
            this.rdShowAllPurchase.Text = "Show All";
            this.rdShowAllPurchase.UseVisualStyleBackColor = false;
            // 
            // dtpPerfomaDate
            // 
            this.grpCountryDetails.SetEffectType(this.dtpPerfomaDate, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dtpPerfomaDate.Location = new System.Drawing.Point(146, 101);
            this.dtpPerfomaDate.Name = "dtpPerfomaDate";
            this.grpCountryDetails.SetsGlowColor(this.dtpPerfomaDate, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dtpPerfomaDate.sGlowColor"))));
            this.dtpPerfomaDate.Size = new System.Drawing.Size(250, 31);
            this.dtpPerfomaDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpPerfomaDate.StateCommon.Border.Rounding = 10;
            this.dtpPerfomaDate.StateCommon.Border.Width = 1;
            this.dtpPerfomaDate.TabIndex = 390;
            // 
            // txtPipeLineQTY
            // 
            this.txtPipeLineQTY.Location = new System.Drawing.Point(634, 98);
            this.txtPipeLineQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPipeLineQTY.Name = "txtPipeLineQTY";
            this.txtPipeLineQTY.Size = new System.Drawing.Size(250, 34);
            this.txtPipeLineQTY.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPipeLineQTY.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtPipeLineQTY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPipeLineQTY.StateCommon.Border.Rounding = 10;
            this.txtPipeLineQTY.StateCommon.Border.Width = 1;
            this.txtPipeLineQTY.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPipeLineQTY.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPipeLineQTY.StateNormal.Border.Rounding = 20;
            this.txtPipeLineQTY.TabIndex = 392;
            // 
            // lblPipeLineQTY
            // 
            this.lblPipeLineQTY.AutoSize = true;
            this.lblPipeLineQTY.BackColor = System.Drawing.Color.Transparent;
            this.lblPipeLineQTY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPipeLineQTY.ForeColor = System.Drawing.Color.Black;
            this.lblPipeLineQTY.Location = new System.Drawing.Point(451, 106);
            this.lblPipeLineQTY.Name = "lblPipeLineQTY";
            this.lblPipeLineQTY.Size = new System.Drawing.Size(132, 21);
            this.lblPipeLineQTY.TabIndex = 391;
            this.lblPipeLineQTY.Text = "Pipe Line QTY :";
            // 
            // txtAvailableStockQTY
            // 
            this.txtAvailableStockQTY.Location = new System.Drawing.Point(634, 141);
            this.txtAvailableStockQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvailableStockQTY.Name = "txtAvailableStockQTY";
            this.txtAvailableStockQTY.Size = new System.Drawing.Size(250, 34);
            this.txtAvailableStockQTY.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAvailableStockQTY.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtAvailableStockQTY.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAvailableStockQTY.StateCommon.Border.Rounding = 10;
            this.txtAvailableStockQTY.StateCommon.Border.Width = 1;
            this.txtAvailableStockQTY.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableStockQTY.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAvailableStockQTY.StateNormal.Border.Rounding = 20;
            this.txtAvailableStockQTY.TabIndex = 394;
            // 
            // lblAvailableStockQTY
            // 
            this.lblAvailableStockQTY.AutoSize = true;
            this.lblAvailableStockQTY.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableStockQTY.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableStockQTY.ForeColor = System.Drawing.Color.Black;
            this.lblAvailableStockQTY.Location = new System.Drawing.Point(451, 148);
            this.lblAvailableStockQTY.Name = "lblAvailableStockQTY";
            this.lblAvailableStockQTY.Size = new System.Drawing.Size(178, 21);
            this.lblAvailableStockQTY.TabIndex = 393;
            this.lblAvailableStockQTY.Text = "Available Stock QTY :";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpCountryDetails.SetEffectType(this.btnAdd, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnAdd.Location = new System.Drawing.Point(928, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.grpCountryDetails.SetsGlowColor(this.btnAdd, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnAdd.sGlowColor"))));
            this.btnAdd.Size = new System.Drawing.Size(105, 35);
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 12;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 395;
            this.btnAdd.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnAdd.Values.Text = "Add";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(949, 702);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnPrint.Size = new System.Drawing.Size(105, 35);
            this.btnPrint.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.StateCommon.Border.Rounding = 12;
            this.btnPrint.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.TabIndex = 396;
            this.btnPrint.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.btnPrint.Values.Text = "Print";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvUser.Location = new System.Drawing.Point(11, 433);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUser.Size = new System.Drawing.Size(1044, 266);
            this.dgvUser.TabIndex = 397;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownWidth = 100;
            this.cmbSupplier.Location = new System.Drawing.Point(634, 15);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(250, 31);
            this.cmbSupplier.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSupplier.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbSupplier.StateCommon.ComboBox.Border.Width = 1;
            this.cmbSupplier.StateCommon.Item.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cmbSupplier.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbSupplier.TabIndex = 396;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 744);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.cmbSelectOperation);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.lblSelectOperation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPurchaseOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.grpCountryDetails.ResumeLayout(false);
            this.grpCountryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.gGlowGroupBox1.ResumeLayout(false);
            this.gGlowGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private gGlowBox.gGlowGroupBox grpCountryDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQTY;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCountryCode;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.Label lblProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSelectOperation;
        private System.Windows.Forms.Label lblSelectOperation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRateQTY;
        private System.Windows.Forms.Label lblRateQTY;
        private System.Windows.Forms.Label lblPerfomaDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRateCTN;
        private System.Windows.Forms.Label lblRateCTN;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private gGlowBox.gGlowGroupBox gGlowGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByPerfomaNo;
        private System.Windows.Forms.RadioButton rdSearchByPerfomaNo;
        private System.Windows.Forms.RadioButton rdShowAllPurchase;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpPerfomaDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAvailableStockQTY;
        private System.Windows.Forms.Label lblAvailableStockQTY;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPipeLineQTY;
        private System.Windows.Forms.Label lblPipeLineQTY;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvUser;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSupplier;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}