using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Repository.ProductDetails;
using 一盒蛋玩具店.UI;


namespace 一盒蛋玩具店
{
    public partial class ReceivingForm : Form
    {
        internal class DgvProduct
        {
            private Product _dgvProduct;
            private Category _dgvCategory;
            private ulong _quantity;
            private ulong _unitPrice;
            /// <summary>
            /// 商品條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong ProductBarcode => _dgvProduct.Barcode;
            /// <summary>
            /// 商品類型
            /// </summary>
            [DisplayName("類型")]
            public string CategoryName => _dgvCategory.Name;
            /// <summary>
            /// 商品名稱
            /// </summary>
            [DisplayName("商品")]
            public string ProductName => _dgvProduct.Name;
            /// <summary>
            /// 進貨數量
            /// </summary>
            [DisplayName("進貨數量")]
            public ulong Quantity => _quantity;
            /// <summary>
            /// 進貨單價
            /// </summary>
            [DisplayName("進貨單價")]
            public ulong UnitPrice => _unitPrice;

            /// <summary>
            /// 取得商品物件
            /// </summary>
            /// <returns></returns>
            public Product GetProduct() => _dgvProduct;
            /// <summary>
            /// 取得類型物件
            /// </summary>
            /// <returns></returns>
            public Category GetCategory() => _dgvCategory;
            public DgvProduct(Product product, Category category, ulong quantity, ulong unitPrice)
            {
                _dgvProduct = product;
                _dgvCategory = category;
                //CategoryName = _dgvCategory.Name;
                //ProductBarcode= _dgvProduct.Barcode;
                //ProductName= _dgvProduct.Name;
                _quantity = quantity;
                _unitPrice = unitPrice;
            }

        }


        private List<DgvProduct> _dgvProducts = new List<DgvProduct>();
        private List<object> _productList = new List<object>();
        private Supplier _supplier = null;
        public ReceivingForm()
        {
            InitializeComponent();
            AllClear();
            //LblSupplierClear();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)(Keys.Enter))
            {
                ulong NowID = ulong.Parse(textBox1.Text);
                PnlSupplier.Enabled = true;
            }
        }

        private void BtnAddListBox_Click(object sender, EventArgs e)
        {
            PurchaseSettingsForm purchaseSettingsForm = new PurchaseSettingsForm();
            purchaseSettingsForm.ShowDialog();
            if (purchaseSettingsForm.NewProduct != null && purchaseSettingsForm.SetCategory != null)
            {
                Product product = (Product)purchaseSettingsForm.NewProduct;
                Category category = (Category)purchaseSettingsForm.SetCategory;
                DgvProduct test = new DgvProduct(product, category, purchaseSettingsForm.NewQuantity, purchaseSettingsForm.NewUnitPrice);
                _dgvProducts.Add(test);
                DataGridViewTool<DgvProduct>.SetDataGridView(DgvProdict, _dgvProducts);
            }
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
            if (supplierForm.SetSupplier != null)
            {
                _supplier = (Supplier)supplierForm.SetSupplier;
                LblSupplierName.Text = _supplier.Name;
                LblPhone.Text = _supplier.Phone;
                PnlProduct.Enabled = true;
            }
        }

        private void BntRemoveListBox_Click(object sender, EventArgs e)
        {
            if (DgvProdict.SelectedCells.Count > 0)
            {
                int rowIndex = DgvProdict.SelectedCells[0].RowIndex;
                DgvProduct product = _dgvProducts[rowIndex];
                _dgvProducts.Remove(product);
                DataGridViewTool<DgvProduct>.SetDataGridView(DgvProdict, _dgvProducts);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || _supplier == null || _dgvProducts == null)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }
            _productList.Clear();
            DateTime dateTime = DateTime.Now;
            foreach (var i in _dgvProducts)
            {
                ulong purchaseOrderNumber = ulong.Parse(textBox1.Text);
                int quantity = (int)i.Quantity;
                ulong productId;
                ulong supplierId = _supplier.SupplierId;
                ulong price = i.UnitPrice;
                Product product = i.GetProduct();
                if (Controllers.HasProduct(p => p.Barcode == i.ProductBarcode))
                    productId = Controllers.FindProduct(p => p.Barcode == i.ProductBarcode).ProductId;
                else
                    productId = Controllers.GetProductNextId();
                Controllers.AddPurchase(
                purchaseOrderNumber, productId, supplierId,
                dateTime, quantity, (int)price);
                if (Controllers.HasProduct(p => p.ProductId == productId))
                {
                    Inventory inventory = Controllers.FindInventory(p => p.ProductId == productId);
                    int inventoryQuantity = inventory.Quantity + quantity;
                    Controllers.UpdateInventory(productId, p => p.Quantity = inventoryQuantity);
                    Controllers.UpdateInventory(productId, p => p.LastUpdated = dateTime);
                }
                else
                {
                    Controllers.AddProduct(product.Barcode, product.Name, product.CategoryId);
                    Controllers.AddInventory(productId, quantity, dateTime);
                }
                _productList.Add(Controllers.FindProduct(p => p.Name == product.Name));
            }
            AllClear();
            DialogResult result = MessageBox.Show("是否要設定價格", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProductPricingForm productPricingForm = new ProductPricingForm(_productList);
                productPricingForm.ShowDialog();
            }
        }
        private void AllClear()
        {
            textBox1.Clear();
            LblSupplierName.Text = "未輸入";
            LblPhone.Text = "未輸入";
            DgvProdict.Columns.Clear();
            _supplier = null;
            _dgvProducts.Clear();
            PnlProduct.Enabled = false;
            PnlSupplier.Enabled = false;
        }

        private void BtnPurchaseRecords_Click(object sender, EventArgs e)
        {
            PurchaseRecordForm purchaseRecordForm = new PurchaseRecordForm();
            purchaseRecordForm.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ulong NowID = ulong.Parse(textBox1.Text);
            PnlSupplier.Enabled = true;
        }
    }
}
