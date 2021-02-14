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
            pictureBox1.Location = new Point(
this.ClientSize.Width / 2 - pictureBox1.Size.Width / 2,
this.ClientSize.Height / 2 - pictureBox1.Size.Height / 2);
            pictureBox1.Anchor = AnchorStyles.None;
            this.Refresh();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.back_green;

            kryptonRibbon1.SelectedTab = kryptonRibbonTab10;
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

        private void picCompanyMatser_Click(object sender, EventArgs e)
        {
            Masters.frmCompanyMaster frmCompanyMaster = new Masters.frmCompanyMaster();
            frmCompanyMaster.Show();
        }

        private void picEmployeeMaster_Click(object sender, EventArgs e)
        {
            Masters.frmEmployeeMaster frmEmployeeMaster = new Masters.frmEmployeeMaster();
            frmEmployeeMaster.Show();
        }

        private void picProduct_Item_Master_Click(object sender, EventArgs e)
        {
            Masters.frmProduct_ItemMaster frmProduct_ItemMaster = new Masters.frmProduct_ItemMaster();
            frmProduct_ItemMaster.Show();
        }

        private void picStoreMaster_Click(object sender, EventArgs e)
        {
            Masters.frmStoreMaster frmStoreMaster = new Masters.frmStoreMaster();
            frmStoreMaster.Show();
        }

        private void picSupplierMaster_Click(object sender, EventArgs e)
        {
            Masters.frmSupplierMaster frmSupplierMaster = new Masters.frmSupplierMaster();
            frmSupplierMaster.Show();
        }

        private void picUserFormRights_Click(object sender, EventArgs e)
        {
            User_Management.frmFormRights frmFormRights = new User_Management.frmFormRights();
            frmFormRights.Show();
        }

        private void picSoftwareSetting_Click(object sender, EventArgs e)
        {
            Settings.frmSoftwareSetting frmSoftwareSetting = new Settings.frmSoftwareSetting();
            frmSoftwareSetting.Show();
        }

        private void picCurrencyValueSetting_Click(object sender, EventArgs e)
        {
            Settings.frmCurrencyValueSetting frmCurrencyValueSetting = new Settings.frmCurrencyValueSetting();
            frmCurrencyValueSetting.Show();
        }

        private void picMerchandisers_Click(object sender, EventArgs e)
        {
            Masters.frmMerchandiserMaster frmMerchandiserMaster = new Masters.frmMerchandiserMaster();
            frmMerchandiserMaster.Show();
        }

        private void picPurchaseInvoice_Click(object sender, EventArgs e)
        {
            Purchase.frmPurchaseInvoice frmPurchaseInvoice = new Purchase.frmPurchaseInvoice();
            frmPurchaseInvoice.Show();
        }

        private void picPurchaseBillDetails_Click(object sender, EventArgs e)
        {
            Purchase.frmPurchaseBillDetails frmPurchaseBillDetails = new Purchase.frmPurchaseBillDetails();
            frmPurchaseBillDetails.Show();
        }

        private void picPostingDelivery_Click(object sender, EventArgs e)
        {
            Purchase.frmPostingDelivery frmPostingDelivery = new Purchase.frmPostingDelivery();
            frmPostingDelivery.Show();
        }

        private void picViewPurchaseDetails_Click(object sender, EventArgs e)
        {
            Purchase.frmViewPurchaseDetails frmViewPurchaseDetails = new Purchase.frmViewPurchaseDetails();
            frmViewPurchaseDetails.Show();
        }

        private void kryptonRibbonGroupButton24_Click(object sender, EventArgs e)
        {
            Purchase.frmPurchaseOrder frmPurchaseOrder = new Purchase.frmPurchaseOrder();
            frmPurchaseOrder.Show();
        }

        private void kryptonRibbonGroupButton47_Click(object sender, EventArgs e)
        {
            Sales.frmSales frmSales = new Sales.frmSales();
            frmSales.Show();
        }

        private void kryptonRibbonGroupButton5_Click(object sender, EventArgs e)
        {
            Sales.frmSaleBillDetails frmSaleBillDetails = new Sales.frmSaleBillDetails();
            frmSaleBillDetails.Show();
        }

        private void kryptonRibbonGroupButton9_Click(object sender, EventArgs e)
        {
            Sales.frmPromotion frmPromotion = new Sales.frmPromotion();
            frmPromotion.Show();

        }
    }
}
