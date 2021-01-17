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

namespace IMS_Client_4
{
    public partial class frmHome : KryptonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
         
        }

        private void picCustomerMater_Click(object sender, EventArgs e)
        {
            Masters.frmCustomerMaster frmCustomerMaster = new Masters.frmCustomerMaster();
            frmCustomerMaster.Show();
        }

        private void picCountryMaster_Click(object sender, EventArgs e)
        {
            Masters.frmCountryMaster frmCountryMaster = new Masters.frmCountryMaster();
            frmCountryMaster.Show();
        }
    }
}
