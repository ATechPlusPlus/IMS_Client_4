
namespace IMS_Client_4.Purchase
{
    partial class frmPostingDelivery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFormMessage = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblTotalQTY = new System.Windows.Forms.Label();
            this.lblSupplierBillNo = new System.Windows.Forms.Label();
            this.lblEntryType = new System.Windows.Forms.Label();
            this.cmbCountry = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplierBillNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPost = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 42);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posting Delivery";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IMS_Client_4.Properties.Resources.postwhite;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFormMessage
            // 
            this.lblFormMessage.AutoSize = true;
            this.lblFormMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblFormMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMessage.Location = new System.Drawing.Point(26, 65);
            this.lblFormMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormMessage.Name = "lblFormMessage";
            this.lblFormMessage.Size = new System.Drawing.Size(534, 52);
            this.lblFormMessage.TabIndex = 243;
            this.lblFormMessage.Text = "You have to post delivered enteries for \r\npurchase invoice to able to view the it" +
    "ems in system";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.BackColor = System.Drawing.Color.Transparent;
            this.lblStore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(27, 260);
            this.lblStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(59, 21);
            this.lblStore.TabIndex = 249;
            this.lblStore.Text = "Store :";
            // 
            // lblTotalQTY
            // 
            this.lblTotalQTY.AutoSize = true;
            this.lblTotalQTY.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQTY.Location = new System.Drawing.Point(27, 306);
            this.lblTotalQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQTY.Name = "lblTotalQTY";
            this.lblTotalQTY.Size = new System.Drawing.Size(100, 21);
            this.lblTotalQTY.TabIndex = 248;
            this.lblTotalQTY.Text = "Total QTY :";
            // 
            // lblSupplierBillNo
            // 
            this.lblSupplierBillNo.AutoSize = true;
            this.lblSupplierBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierBillNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierBillNo.Location = new System.Drawing.Point(27, 214);
            this.lblSupplierBillNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierBillNo.Name = "lblSupplierBillNo";
            this.lblSupplierBillNo.Size = new System.Drawing.Size(143, 21);
            this.lblSupplierBillNo.TabIndex = 247;
            this.lblSupplierBillNo.Text = "Supplier Bill No. :";
            // 
            // lblEntryType
            // 
            this.lblEntryType.AutoSize = true;
            this.lblEntryType.BackColor = System.Drawing.Color.Transparent;
            this.lblEntryType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryType.Location = new System.Drawing.Point(27, 168);
            this.lblEntryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryType.Name = "lblEntryType";
            this.lblEntryType.Size = new System.Drawing.Size(102, 21);
            this.lblEntryType.TabIndex = 246;
            this.lblEntryType.Text = "Entry Type :";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownWidth = 313;
            this.cmbCountry.Location = new System.Drawing.Point(184, 164);
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
            this.cmbCountry.TabIndex = 406;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(501, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 21);
            this.label13.TabIndex = 407;
            this.label13.Text = "*";
            // 
            // txtSupplierBillNo
            // 
            this.txtSupplierBillNo.Location = new System.Drawing.Point(184, 208);
            this.txtSupplierBillNo.Name = "txtSupplierBillNo";
            this.txtSupplierBillNo.Size = new System.Drawing.Size(260, 35);
            this.txtSupplierBillNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSupplierBillNo.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtSupplierBillNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSupplierBillNo.StateCommon.Border.Rounding = 10;
            this.txtSupplierBillNo.StateCommon.Border.Width = 1;
            this.txtSupplierBillNo.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierBillNo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSupplierBillNo.StateNormal.Border.Rounding = 20;
            this.txtSupplierBillNo.TabIndex = 409;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(449, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 408;
            this.label12.Text = "*";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 313;
            this.kryptonComboBox1.Location = new System.Drawing.Point(184, 256);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(260, 31);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 10;
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Width = 1;
            this.kryptonComboBox1.StateCommon.Item.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonComboBox1.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.TabIndex = 410;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(184, 300);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(260, 35);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 10;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateNormal.Border.Rounding = 20;
            this.kryptonTextBox1.TabIndex = 411;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(343, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnClear.Size = new System.Drawing.Size(101, 35);
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 12;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.TabIndex = 413;
            this.btnClear.Values.Text = "Clear";
            // 
            // btnPost
            // 
            this.btnPost.AutoSize = true;
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.Location = new System.Drawing.Point(184, 357);
            this.btnPost.Name = "btnPost";
            this.btnPost.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnPost.Size = new System.Drawing.Size(101, 35);
            this.btnPost.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPost.StateCommon.Border.Rounding = 12;
            this.btnPost.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.TabIndex = 412;
            this.btnPost.Values.Text = "Post";
            // 
            // frmPostingDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 417);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.txtSupplierBillNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblTotalQTY);
            this.Controls.Add(this.lblSupplierBillNo);
            this.Controls.Add(this.lblEntryType);
            this.Controls.Add(this.lblFormMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPostingDelivery";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posting Delivery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormMessage;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblTotalQTY;
        private System.Windows.Forms.Label lblSupplierBillNo;
        private System.Windows.Forms.Label lblEntryType;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCountry;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSupplierBillNo;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPost;
    }
}