
namespace IMS_Client_4.Masters
{
    partial class frmCompanyMaster
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
            this.krypbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krypbtnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krypbtnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krypbtnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krypbtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krypbtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(982, 80);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IMS_Client_4.Properties.Resources.customerwhite;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // krypbtnCancel
            // 
            this.krypbtnCancel.AutoSize = true;
            this.krypbtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnCancel.Location = new System.Drawing.Point(772, 96);
            this.krypbtnCancel.Name = "krypbtnCancel";
            this.krypbtnCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnCancel.Size = new System.Drawing.Size(107, 35);
            this.krypbtnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnCancel.StateCommon.Border.Rounding = 12;
            this.krypbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnCancel.TabIndex = 349;
            this.krypbtnCancel.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnCancel.Values.Text = "Cancel";
            // 
            // krypbtnDelete
            // 
            this.krypbtnDelete.AutoSize = true;
            this.krypbtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnDelete.Location = new System.Drawing.Point(642, 96);
            this.krypbtnDelete.Name = "krypbtnDelete";
            this.krypbtnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnDelete.Size = new System.Drawing.Size(107, 35);
            this.krypbtnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnDelete.StateCommon.Border.Rounding = 12;
            this.krypbtnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnDelete.TabIndex = 348;
            this.krypbtnDelete.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnDelete.Values.Text = "Delete";
            // 
            // krypbtnUpdate
            // 
            this.krypbtnUpdate.AutoSize = true;
            this.krypbtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnUpdate.Location = new System.Drawing.Point(512, 96);
            this.krypbtnUpdate.Name = "krypbtnUpdate";
            this.krypbtnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnUpdate.Size = new System.Drawing.Size(107, 35);
            this.krypbtnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnUpdate.StateCommon.Border.Rounding = 12;
            this.krypbtnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnUpdate.TabIndex = 347;
            this.krypbtnUpdate.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnUpdate.Values.Text = "Update";
            // 
            // krypbtnEdit
            // 
            this.krypbtnEdit.AutoSize = true;
            this.krypbtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnEdit.Location = new System.Drawing.Point(382, 96);
            this.krypbtnEdit.Name = "krypbtnEdit";
            this.krypbtnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnEdit.Size = new System.Drawing.Size(107, 35);
            this.krypbtnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnEdit.StateCommon.Border.Rounding = 12;
            this.krypbtnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnEdit.TabIndex = 346;
            this.krypbtnEdit.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnEdit.Values.Text = "Edit";
            // 
            // krypbtnSave
            // 
            this.krypbtnSave.AutoSize = true;
            this.krypbtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnSave.Location = new System.Drawing.Point(252, 96);
            this.krypbtnSave.Name = "krypbtnSave";
            this.krypbtnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnSave.Size = new System.Drawing.Size(107, 35);
            this.krypbtnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnSave.StateCommon.Border.Rounding = 12;
            this.krypbtnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnSave.TabIndex = 345;
            this.krypbtnSave.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnSave.Values.Text = "Save";
            // 
            // krypbtnAdd
            // 
            this.krypbtnAdd.AutoSize = true;
            this.krypbtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krypbtnAdd.Location = new System.Drawing.Point(122, 96);
            this.krypbtnAdd.Name = "krypbtnAdd";
            this.krypbtnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.krypbtnAdd.Size = new System.Drawing.Size(107, 35);
            this.krypbtnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krypbtnAdd.StateCommon.Border.Rounding = 12;
            this.krypbtnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krypbtnAdd.TabIndex = 344;
            this.krypbtnAdd.Values.Image = global::IMS_Client_4.Properties.Resources._new;
            this.krypbtnAdd.Values.Text = "Add New";
            // 
            // frmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 724);
            this.Controls.Add(this.krypbtnCancel);
            this.Controls.Add(this.krypbtnDelete);
            this.Controls.Add(this.krypbtnUpdate);
            this.Controls.Add(this.krypbtnEdit);
            this.Controls.Add(this.krypbtnSave);
            this.Controls.Add(this.krypbtnAdd);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmCompanyMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Master";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton krypbtnAdd;
    }
}