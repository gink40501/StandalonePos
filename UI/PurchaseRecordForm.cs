using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;


namespace 一盒蛋玩具店.UI
{
    public partial class PurchaseRecordForm : Form
    {
        private class Noname
        {
            /// <summary>
            /// 進貨紀錄
            /// </summary>
            private Purchase _purchase;
            /// <summary>
            /// 商品訊息
            /// </summary>
            private Product _product;
            /// <summary>
            /// 廠商資料
            /// </summary>
            private Supplier _supplier;
            /// <summary>
            /// 進貨單號
            /// </summary>
            [DisplayName("進貨單號")]
            public ulong PurchaseOrderNumber => _purchase.PurchaseOrderNumber;
            /// <summary>
            /// 條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong Barcode => _product.Barcode;
            /// <summary>
            /// 商品名稱
            /// </summary>
            [DisplayName("商品")]
            public string ProductName => _product.Name;
            /// <summary>
            /// 廠商名稱
            /// </summary>
            [DisplayName("廠商")]
            public string SupplierName => _supplier.Name;
            /// <summary>
            /// 進貨時間
            /// </summary>
            [DisplayName("進貨時間")]
            public DateTime PurchaseTime => _purchase.PurchaseTime;
            /// <summary>
            /// 進貨數量
            /// </summary>
            [DisplayName("進貨數量")]
            public int Quantity => _purchase.Quantity;
            /// <summary>
            /// 進貨單價
            /// </summary>
            [DisplayName("進貨單價")]
            public int UnitPrice => _purchase.UnitPrice;
            /// <summary>
            /// 建構子
            /// </summary>
            /// <param name="purchase">進貨紀錄</param>
            /// <param name="product">商品訊息</param>
            /// <param name="supplier">廠商資料</param>
            /// <param name="category">產品類型</param>
            public Noname(Purchase purchase, Product product, Supplier supplier)
            {
                _purchase = purchase;
                _product = product;
                _supplier = supplier;
            }
        }
        List<Supplier> _suppliers = new List<Supplier>();
        public PurchaseRecordForm()
        {
            InitializeComponent();
            List<Purchase> purchases = Controllers.GetAllPurchase();
            _suppliers = Controllers.GetAllSupplier();
            DataGridViewTool<Supplier>.SetDataGridView(DgvSupplier, _suppliers);
            SetDgv(DgvPurchase, purchases);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            List<Purchase> purchases = Controllers.GetAllPurchase();
            SetDgv(DgvPurchase, purchases);
        }
        private void SetDgv(DataGridView Dgv, List<Purchase> purchases)
        {
            List<Noname> _nonames = new List<Noname>();
            foreach (Purchase purchase in purchases)
            {
                ulong productId = purchase.ProductId;
                ulong supplierId = purchase.SupplierId;
                Product product = Controllers.FindProduct(p => p.ProductId == productId);
                Supplier supplier = Controllers.FindSupplier(p => p.SupplierId == supplierId);
                Noname noname = new Noname(purchase, product, supplier);
                _nonames.Add(noname);
            }
            DataGridViewTool<Noname>.SetDataGridView(Dgv, _nonames);
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                ulong barcode = ulong.Parse(TxtBarcode.Text);
                Product product = Controllers.FindProduct(p => p.Barcode == barcode);
                List<Purchase> purchases = Controllers.FindAllPurchases(p => p.ProductId == product.ProductId);
                SetDgv(DgvPurchase, purchases);
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
                    Product product = Controllers.FindProduct(p => p.Barcode == barcode);
                    List<Purchase> purchases = Controllers.FindAllPurchases(p => p.ProductId == product.ProductId);
                    SetDgv(DgvPurchase, purchases);
                    TxtBarcode.Clear();
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
        private void TxtPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    List<Purchase> purchases = Controllers.FindAllPurchases(p => p.PurchaseOrderNumber == ulong.Parse(TxtPurchase.Text));
                    SetDgv(DgvPurchase, purchases);
                    TxtPurchase.Clear();
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

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = DgvSupplier.SelectedCells[0].RowIndex;
                Supplier supplier = _suppliers[rowIndex];
                List<Purchase> purchases = Controllers.FindAllPurchases(p => p.SupplierId == supplier.SupplierId);
                SetDgv(DgvPurchase, purchases);
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                List<Purchase> purchases = Controllers.FindAllPurchases(p => p.PurchaseOrderNumber == ulong.Parse(TxtPurchase.Text));
                SetDgv(DgvPurchase, purchases);
                TxtPurchase.Clear();
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
    }
}
