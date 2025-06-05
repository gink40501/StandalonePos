using System;
using System.Windows.Forms;
using 一盒蛋玩具店.Repository.ProductDetails;
using MessageBox = System.Windows.Forms.MessageBox;

namespace 一盒蛋玩具店.UI
{
    public partial class PurchaseSettingsForm : Form
    {
        /// <summary>
        /// 商品資料
        /// </summary>
        public object NewProduct { get; set; }
        /// <summary>
        /// 商品類型
        /// </summary>
        public object SetCategory { get; set; }
        /// <summary>
        /// 進貨總數
        /// </summary>
        public ulong NewQuantity { get; set; }
        /// <summary>
        /// 進貨總價
        /// </summary>
        public ulong NewUnitPrice { get; set; }

        public PurchaseSettingsForm()
        {
            InitializeComponent();
        }

        private void BtnProductData_Click(object sender, EventArgs e)
        {
            AddProductData addProductData = new AddProductData();
            addProductData.ShowDialog();
            if (addProductData.NewProdict != null && addProductData.SetCategory != null)
            {
                Product newProduct = (Product)addProductData.NewProdict;
                Category setCategory = (Category)addProductData.SetCategory;
                LblBarcode.Text = newProduct.Barcode.ToString();
                LblProductName.Text = newProduct.Name;
                LblCategoryName.Text = setCategory.Name;
                NewProduct = newProduct;
                SetCategory = setCategory;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (NewProduct != null && SetCategory != null)
            {
                NewQuantity = (ulong)NudQuantity.Value;
                NewUnitPrice = (ulong)NudUnitPrice.Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("輸入錯誤");
            }
        }
    }
}
