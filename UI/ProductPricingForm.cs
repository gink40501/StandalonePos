using System;
using System.Collections.Generic;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;

namespace 一盒蛋玩具店.UI
{
    public partial class ProductPricingForm : Form
    {
        Product _nowProduct;
        List<ProductPrice> _productPricr;
        List<Product> _addProducts;
        int _productId = 0;
        int _supplierId = 0;
        int _categorId = 1;
        public ProductPricingForm(List<object>? addProducts = null)
        {
            InitializeComponent();
            tabControl1.Enabled = true;
            BtnAdd.Enabled = false;
            BtnRemove.Enabled = false;
            List<Supplier> suppliers = Controllers.GetAllSupplier();
            NudPage.Maximum = Controllers.GetProductLastPage();
            LblLastPage.Text = Controllers.GetProductLastPage().ToString();
            List<Product> products = Controllers.GetProductPagination((int)NudPage.Value);
            List<Category> categories = Controllers.GetAllCategory();
            DataGridViewTool<Product>.SetDataGridView(DgvAllProduct, products);
            DataGridViewTool<Supplier>.SetDataGridView(DgvSupplier, suppliers);
            DataGridViewTool<Category>.SetDataGridView(DgvCategory, categories);
            if (addProducts != null)
            {
                tabControl1.SelectedTab = TpProduct;
                _addProducts = new List<Product>();
                foreach (var i in addProducts)
                    _addProducts.Add((Product)i);
                DataGridViewTool<Product>.SetDataGridView(DgvProduct, _addProducts);
            }
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    Product product = Controllers.FindProduct(p => p.Barcode == ulong.Parse(TxtBarcode.Text));
                    List<Product> products = new List<Product>();
                    products.Add(product);
                    DataGridViewTool<Product>.SetDataGridView(DgvBarcodeProduct, products);
                    _nowProduct = product;
                    ulong productId = product.ProductId;
                }
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ulong productId = _nowProduct.ProductId;
            DateTime dateTime = DtpEffectiveDate.Value.Date;
            int price = (int)NudPrice.Value;
            if (Controllers.HasProductPrice(p => p.ProductId == productId))
            {
                List<ProductPrice> productPrice = Controllers.FindAllProductPrice(p => p.ProductId == productId);
                if (productPrice.Find(p => p.EffectiveTime == dateTime) == null)
                {
                    Controllers.AddProductPrice(productId, dateTime, price);
                }
                else
                {
                    MessageBox.Show("生效時間重複");
                }
            }
            else
            {
                Controllers.AddProductPrice(productId, dateTime, price);
            }
            SetDGV(productId);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (DgvProductPrice.SelectedCells.Count > 0)
            {
                int rowIndex = DgvProductPrice.SelectedCells[0].RowIndex;
                ProductPrice productPrice = _productPricr[rowIndex];
                Controllers.RemoveProductPrice(p => p.Price == productPrice.Price && p.ProductId == productPrice.ProductId && p.EffectiveTime == productPrice.EffectiveTime);
                SetDGV(productPrice.ProductId);
            }
        }
        private void SetDGV(ulong productId)
        {
            try
            {
                DgvProductPrice.Columns.Clear();
                List<ProductPrice> productPrice = Controllers.FindAllProductPrice(p => p.ProductId == productId);
                DataGridViewTool<ProductPrice>.SetDataGridView(DgvProductPrice, productPrice);
                _productPricr = productPrice;
                tabControl1.Enabled = false;
                BtnAdd.Enabled = true;
                BtnRemove.Enabled = true;
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show("無價格資料");
                tabControl1.Enabled = false;
                BtnAdd.Enabled = true;
                BtnRemove.Enabled = true;
            }
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            List<Product> products = Controllers.GetProductPagination((int)NudPage.Value);
            DataGridViewTool<Product>.SetDataGridView(DgvAllProduct, products);
        }

        private void Btnproduct_Click(object sender, EventArgs e)
        {
            int rowIndex = DgvAllProduct.SelectedCells[0].RowIndex;
            ulong productId = (ulong)DgvAllProduct.Rows[rowIndex].Cells[_productId].Value;
            _nowProduct = Controllers.FindProduct(p => p.ProductId == productId);
            SetDGV(productId);
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            SetDgvProduct(DgvBarcodeProduct);
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = DgvSupplier.SelectedCells[0].RowIndex;
                ulong supplierId = (ulong)DgvSupplier.Rows[rowIndex].Cells[_supplierId].Value;
                List<Purchase> purchases = Controllers.FindAllPurchases(p => p.SupplierId == supplierId);
                List<Product> products = new List<Product>();
                foreach (var i in purchases)
                {
                    if (products.Find(p => p.ProductId == i.ProductId) == null)
                        products.Add(Controllers.FindProduct(p => p.ProductId == i.ProductId));
                }
                DataGridViewTool<Product>.SetDataGridView(DgvSupplierProduct, products);
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSupplierCheck_Click(object sender, EventArgs e)
        {
            SetDgvProduct(DgvSupplierProduct);
        }
        void SetDgvProduct(DataGridView dgvProduc)
        {
            if (dgvProduc.SelectedCells.Count > 0)
            {
                int rowIndex = dgvProduc.SelectedCells[0].RowIndex;
                ulong productId = (ulong)dgvProduc.Rows[rowIndex].Cells[_productId].Value;
                _nowProduct = Controllers.FindProduct(p => p.ProductId == productId);
                SetDGV(productId);
            }
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            if (DgvCategory.SelectedCells.Count > 0)
            {
                try
                {
                    int rowIndex = DgvCategory.SelectedCells[0].RowIndex;
                    ulong categorId = (ulong)DgvCategory.Rows[rowIndex].Cells[_categorId].Value;
                    List<Product> products = Controllers.FindAllProduct(p => p.CategoryId == categorId);
                    DataGridViewTool<Product>.SetDataGridView(DgvCategoryProduct, products);
                }
                catch (ToyStoreException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnCategoryCheck_Click(object sender, EventArgs e)
        {
            SetDgvProduct(DgvCategoryProduct);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _nowProduct = null;
            if (_productPricr != null)
                _productPricr.Clear();
            DgvProductPrice.Columns.Clear();
            tabControl1.Enabled = true;
            BtnAdd.Enabled = false;
            BtnRemove.Enabled = false;
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            if (DgvProduct.SelectedCells.Count > 0)
            {
                int rowIndex = DgvProduct.SelectedCells[0].RowIndex;
                ulong productId = (ulong)DgvProduct.Rows[rowIndex].Cells[_productId].Value;
                _nowProduct = Controllers.FindProduct(p => p.ProductId == productId);
                SetDGV(productId);
            }
        }
    }
}
