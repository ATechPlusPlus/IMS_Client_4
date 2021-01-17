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

namespace IMS_Client_4.Masters
{
    public partial class frmCustomerMaster : KryptonForm
    {
        public frmCustomerMaster()
        {
            InitializeComponent();
        }

        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.back_green;
        }
    }
}
