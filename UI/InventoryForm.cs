using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;

namespace 一盒蛋玩具店.UI
{
    public partial class InventoryForm : Form
    {
        private class Noname
        {
            /// <summary>
            /// 商品訊息
            /// </summary>
            private Product _product;
            /// <summary>
            /// 庫存資料
            /// </summary>
            private Inventory _inventory;
            /// <summary>
            /// 商品類型
            /// </summary>
            private Category _category;
            /// <summary>
            /// 條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong Barcode => _product.Barcode;
            /// <summary>
            /// 商品ID
            /// </summary>
            [DisplayName("商品ID")]
            public ulong ProductId => _product.ProductId;
            /// <summary>
            /// 商品名稱
            /// </summary>
            [DisplayName("商品")]
            public string ProductName => _product.Name;
            /// <summary>
            /// 總類名稱
            /// </summary>
            [DisplayName("種類")]
            public string CategoryName => _category.Name;
            /// <summary>
            /// 庫存存量
            /// </summary>
            [DisplayName("庫存數量")]
            public int Quantity => _inventory.Quantity;
            /// <summary>
            /// 建構子
            /// </summary>
            /// <param name="product">商品</param>
            /// <param name="inventory">庫存</param>
            public Noname(Product product)
            {
                _product = product;
                _inventory = Controllers.FindInventory(p => p.ProductId == _product.ProductId);
                _category = Controllers.FindCategory(p => p.CategoryId == _product.CategoryId);
            }
        }
        public InventoryForm()
        {
            InitializeComponent();
            NudPage.Maximum = Controllers.GetProductLastPage();
            LblLastPage.Text = Controllers.GetProductLastPage().ToString();
            List<Category> categories = Controllers.GetAllCategory();
            DataGridViewTool<Category>.SetDataGridView(DgvCategory, categories);
            List<Product> products = Controllers.GetProductPagination((int)NudPage.Value);
            SetDgv(products);
            PnlPahe.Enabled = true;
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            List<Product> products = Controllers.GetProductPagination((int)NudPage.Value);
            SetDgv(products);
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            int rowIndex = DgvCategory.SelectedCells[0].RowIndex;
            ulong categoryId = (ulong)DgvCategory.Rows[rowIndex].Cells[1].Value;
            List<Product> products = Controllers.FindAllProduct(p => p.CategoryId == categoryId);
            SetDgv(products);
            PnlPahe.Enabled = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            NudPage.Maximum = Controllers.GetProductLastPage();
            LblLastPage.Text = Controllers.GetProductLastPage().ToString();
            List<Product> products = Controllers.GetProductPagination((int)NudPage.Value);
            SetDgv(products);
            PnlPahe.Enabled = true;
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                ulong barcode = ulong.Parse(TxtBarcode.Text);
                List<Product> products = new List<Product>();
                Product product = Controllers.FindProduct(p => p.Barcode == barcode);
                products.Add(product);
                SetDgv(products);
                PnlPahe.Enabled = false;
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入錯誤");
            }
        }
        void SetDgv(List<Product> products)
        {
            List<Noname> nonames = new List<Noname>();

            foreach (var i in products)
            {
                Noname noname = new Noname(i);
                nonames.Add(noname);
            }
            DataGridViewTool<Noname>.SetDataGridView(DgvInventory, nonames);
            DgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    ulong barcode = ulong.Parse(TxtBarcode.Text);
                    List<Product> products = new List<Product>();
                    Product product = Controllers.FindProduct(p => p.Barcode == barcode);
                    products.Add(product);
                    SetDgv(products);
                    PnlPahe.Enabled = false;
                }
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入錯誤");
            }

        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.ShowDialog();
        }
    }
}
