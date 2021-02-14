namespace IMS_Client_4.Stock_Management
{
    partial class frmStockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gGlowGroupBox1 = new gGlowBox.gGlowGroupBox();
            this.txtSearchByCompanyMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSearchByCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rdSearchByCompanyMobileNo = new System.Windows.Forms.RadioButton();
            this.rdSearchByCompanyName = new System.Windows.Forms.RadioButton();
            this.rdShowAllCompany = new System.Windows.Forms.RadioButton();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gGlowGroupBox2 = new gGlowBox.gGlowGroupBox();
            this.dgvCompanyMaster = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.gGlowGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.gGlowGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 65);
            this.panel1.TabIndex = 359;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IMS_Client_4.Properties.Resources.stockdetailswhite;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(3, 69);
            this.kryptonHeaderGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(916, 78);
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
            this.kryptonHeaderGroup1.TabIndex = 360;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Search";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.Search;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.gGlowGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(908, 44);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // gGlowGroupBox1
            // 
            this.gGlowGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.Controls.Add(this.txtSearchByCompanyMobileNo);
            this.gGlowGroupBox1.Controls.Add(this.txtSearchByCompanyName);
            this.gGlowGroupBox1.Controls.Add(this.rdSearchByCompanyMobileNo);
            this.gGlowGroupBox1.Controls.Add(this.rdSearchByCompanyName);
            this.gGlowGroupBox1.Controls.Add(this.rdShowAllCompany);
            this.gGlowGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGlowGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gGlowGroupBox1.GlowAmount = 20;
            this.gGlowGroupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.gGlowGroupBox1.GlowFeather = 70;
            this.gGlowGroupBox1.GlowOn = true;
            this.gGlowGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gGlowGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gGlowGroupBox1.Name = "gGlowGroupBox1";
            this.gGlowGroupBox1.Size = new System.Drawing.Size(908, 44);
            this.gGlowGroupBox1.TabIndex = 287;
            // 
            // txtSearchByCompanyMobileNo
            // 
            this.txtSearchByCompanyMobileNo.Location = new System.Drawing.Point(457, 6);
            this.txtSearchByCompanyMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByCompanyMobileNo.Name = "txtSearchByCompanyMobileNo";
            this.txtSearchByCompanyMobileNo.Size = new System.Drawing.Size(198, 30);
            this.txtSearchByCompanyMobileNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchByCompanyMobileNo.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearchByCompanyMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByCompanyMobileNo.StateCommon.Border.Rounding = 10;
            this.txtSearchByCompanyMobileNo.StateCommon.Border.Width = 1;
            this.txtSearchByCompanyMobileNo.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByCompanyMobileNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByCompanyMobileNo.StateNormal.Border.Rounding = 20;
            this.txtSearchByCompanyMobileNo.TabIndex = 390;
            // 
            // txtSearchByCompanyName
            // 
            this.txtSearchByCompanyName.Location = new System.Drawing.Point(125, 7);
            this.txtSearchByCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByCompanyName.Name = "txtSearchByCompanyName";
            this.txtSearchByCompanyName.Size = new System.Drawing.Size(176, 30);
            this.txtSearchByCompanyName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearchByCompanyName.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearchByCompanyName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByCompanyName.StateCommon.Border.Rounding = 10;
            this.txtSearchByCompanyName.StateCommon.Border.Width = 1;
            this.txtSearchByCompanyName.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByCompanyName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearchByCompanyName.StateNormal.Border.Rounding = 20;
            this.txtSearchByCompanyName.TabIndex = 383;
            // 
            // rdSearchByCompanyMobileNo
            // 
            this.rdSearchByCompanyMobileNo.AutoSize = true;
            this.rdSearchByCompanyMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.SetEffectType(this.rdSearchByCompanyMobileNo, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByCompanyMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByCompanyMobileNo.ForeColor = System.Drawing.Color.Black;
            this.rdSearchByCompanyMobileNo.Location = new System.Drawing.Point(334, 11);
            this.rdSearchByCompanyMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCompanyMobileNo.Name = "rdSearchByCompanyMobileNo";
            this.gGlowGroupBox1.SetsGlowColor(this.rdSearchByCompanyMobileNo, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByCompanyMobileNo.sGlowColor"))));
            this.rdSearchByCompanyMobileNo.Size = new System.Drawing.Size(119, 21);
            this.rdSearchByCompanyMobileNo.TabIndex = 389;
            this.rdSearchByCompanyMobileNo.Text = "Product Name :";
            this.rdSearchByCompanyMobileNo.UseVisualStyleBackColor = false;
            // 
            // rdSearchByCompanyName
            // 
            this.rdSearchByCompanyName.AutoSize = true;
            this.rdSearchByCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.SetEffectType(this.rdSearchByCompanyName, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdSearchByCompanyName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearchByCompanyName.ForeColor = System.Drawing.Color.Black;
            this.rdSearchByCompanyName.Location = new System.Drawing.Point(16, 12);
            this.rdSearchByCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.rdSearchByCompanyName.Name = "rdSearchByCompanyName";
            this.gGlowGroupBox1.SetsGlowColor(this.rdSearchByCompanyName, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdSearchByCompanyName.sGlowColor"))));
            this.rdSearchByCompanyName.Size = new System.Drawing.Size(105, 21);
            this.rdSearchByCompanyName.TabIndex = 387;
            this.rdSearchByCompanyName.Text = "Barcode No :";
            this.rdSearchByCompanyName.UseVisualStyleBackColor = false;
            // 
            // rdShowAllCompany
            // 
            this.rdShowAllCompany.AutoSize = true;
            this.rdShowAllCompany.BackColor = System.Drawing.Color.Transparent;
            this.rdShowAllCompany.Checked = true;
            this.gGlowGroupBox1.SetEffectType(this.rdShowAllCompany, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.rdShowAllCompany.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShowAllCompany.ForeColor = System.Drawing.Color.Black;
            this.rdShowAllCompany.Location = new System.Drawing.Point(786, 13);
            this.rdShowAllCompany.Margin = new System.Windows.Forms.Padding(2);
            this.rdShowAllCompany.Name = "rdShowAllCompany";
            this.gGlowGroupBox1.SetsGlowColor(this.rdShowAllCompany, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("rdShowAllCompany.sGlowColor"))));
            this.rdShowAllCompany.Size = new System.Drawing.Size(79, 21);
            this.rdShowAllCompany.TabIndex = 388;
            this.rdShowAllCompany.TabStop = true;
            this.rdShowAllCompany.Text = "Show All";
            this.rdShowAllCompany.UseVisualStyleBackColor = false;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(9, 151);
            this.kryptonHeaderGroup2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonPanel3);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(908, 391);
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
            this.kryptonHeaderGroup2.TabIndex = 395;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Stock Details";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::IMS_Client_4.Properties.Resources.Grid;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.gGlowGroupBox2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(906, 339);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.TabIndex = 0;
            // 
            // gGlowGroupBox2
            // 
            this.gGlowGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox2.Controls.Add(this.dgvCompanyMaster);
            this.gGlowGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGlowGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.gGlowGroupBox2.GlowAmount = 20;
            this.gGlowGroupBox2.GlowColorDefault = System.Drawing.Color.White;
            this.gGlowGroupBox2.GlowFeather = 70;
            this.gGlowGroupBox2.GlowOn = true;
            this.gGlowGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.gGlowGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.gGlowGroupBox2.Name = "gGlowGroupBox2";
            this.gGlowGroupBox2.Size = new System.Drawing.Size(906, 339);
            this.gGlowGroupBox2.TabIndex = 287;
            // 
            // dgvCompanyMaster
            // 
            this.dgvCompanyMaster.AllowUserToAddRows = false;
            this.dgvCompanyMaster.AllowUserToDeleteRows = false;
            this.dgvCompanyMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox2.SetEffectType(this.dgvCompanyMaster, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.dgvCompanyMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvCompanyMaster.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompanyMaster.Name = "dgvCompanyMaster";
            this.dgvCompanyMaster.ReadOnly = true;
            this.dgvCompanyMaster.RowHeadersWidth = 51;
            this.dgvCompanyMaster.RowTemplate.Height = 24;
            this.gGlowGroupBox2.SetsGlowColor(this.dgvCompanyMaster, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dgvCompanyMaster.sGlowColor"))));
            this.dgvCompanyMaster.Size = new System.Drawing.Size(906, 339);
            this.dgvCompanyMaster.TabIndex = 0;
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS_Client_4.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 553);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStockManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.gGlowGroupBox1.ResumeLayout(false);
            this.gGlowGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.gGlowGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private gGlowBox.gGlowGroupBox gGlowGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByCompanyMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearchByCompanyName;
        private System.Windows.Forms.RadioButton rdSearchByCompanyMobileNo;
        private System.Windows.Forms.RadioButton rdSearchByCompanyName;
        private System.Windows.Forms.RadioButton rdShowAllCompany;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private gGlowBox.gGlowGroupBox gGlowGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCompanyMaster;
    }
}