﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_Client_4.Sales
{
    public partial class frmSaleBillDetails : KryptonForm
    {
        public frmSaleBillDetails()
        {
            InitializeComponent();
        }

        private void frmSaleBillDetails_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
        }
    }
}
