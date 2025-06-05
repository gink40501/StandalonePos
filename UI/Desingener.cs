using System;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.UI;


namespace 一盒蛋玩具店.表單
{
    public partial class Desingener : Form
    {
        public Desingener()
        {
            InitializeComponent();
            Controllers.Load();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            ReceivingForm receivingForm = new ReceivingForm();
            receivingForm.ShowDialog();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            ProductPricingForm productPricingForm = new ProductPricingForm();
            productPricingForm.ShowDialog();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.ShowDialog();
        }
    }
}
