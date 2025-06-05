using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;



namespace 一盒蛋玩具店
{
    public partial class SaleForm : Form
    {
        List<Sales> saleList = new List<Sales>();

        private class HistoricalData
        {
            /// <summary>
            /// 商品資料
            /// </summary>
            private Product _product;
            /// <summary>
            /// 銷售詳細資料
            /// </summary>
            private SaleDetail _saleDetail;
            /// <summary>
            /// 銷售資料
            /// </summary>
            private Sale _sale;
            /// <summary>
            /// 銷售編號
            /// </summary>
            [DisplayName("銷售編號")]
            public ulong Serial => _saleDetail.OrderNumber;
            /// <summary>
            /// 販賣時間
            /// </summary>
            [DisplayName("販賣時間")]
            public DateTime time => _sale.SaleTime;
            /// <summary>
            /// 條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong ProductBarcode => _product.Barcode;
            /// <summary>
            /// 名稱
            /// </summary>
            [DisplayName("名稱")]
            public string ProductName => _product.Name;
            /// <summary>
            /// 數量
            /// </summary>
            [DisplayName("數量")]
            public int SalesDetailQuantity => _saleDetail.Quantity;
            /// <summary>
            /// 銷售價錢
            /// </summary>
            [DisplayName("銷售價錢")]
            public int SalesDetailUnitPrice => _saleDetail.UnitPrice;
            public HistoricalData(SaleDetail saleDetail)
            {
                _saleDetail = saleDetail;
                _product = Controllers.FindProduct(p => p.ProductId == _saleDetail.ProductId);
                _sale = Controllers.FindSale(p => p.OrderNumber == _saleDetail.OrderNumber);
            }
        }
        public class Sales
        {
            /// <summary>
            /// 庫存
            /// </summary>
            private Inventory _inventory;
            /// <summary>
            /// 商品資料
            /// </summary>
            private Product _product;
            /// <summary>
            /// 價格資料
            /// </summary>
            private ProductPrice _productPrice;
            /// <summary>
            /// 條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong Barcode => _product.Barcode;
            /// <summary>
            /// 品名
            /// </summary>
            [DisplayName("品名")]
            public string Name => _product.Name;
            /// <summary>
            /// 庫存
            /// </summary>
            [DisplayName("庫存")]
            public int Quantity => _inventory.Quantity;
            /// <summary>
            /// 數量
            /// </summary>
            [DisplayName("數量")]
            public int Count { get; set; }
            /// <summary>
            /// 單價
            /// </summary>
            [DisplayName("單價")]
            public int UnitPrice => _productPrice.Price;
            /// <summary>
            /// 價格
            /// </summary>
            [DisplayName("價格")]
            public int Price => UnitPrice * Count;
            internal Sales(Product product)
            {
                try
                {
                    _inventory = Controllers.FindInventory(p => p.ProductId == product.ProductId);
                    Count = 1;
                    _productPrice = Controllers.GetValidPrice(product.ProductId);
                    _product = product;
                }
                catch (ToyStoreException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public SaleForm()
        {
            InitializeComponent();
            LblTotalAmount.Text = AmountTotal().ToString();
            SetHistoricalData();
        }
        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\r')
                {
                    SearchProduct();
                }
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvTable.CurrentCell is DataGridViewComboBoxCell && e.Control is ComboBox comboBox)
            {
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                comboBox.Tag = DgvTable.CurrentCell.RowIndex;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DgvTable.CurrentCell is DataGridViewComboBoxCell cell)
            {
                int rowIndex = DgvTable.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < saleList.Count)
                {
                    ComboBox combo = sender as ComboBox;
                    if (int.TryParse(combo.SelectedItem?.ToString(), out int selectedCount))
                    {
                        saleList[rowIndex].Count = selectedCount;
                        DgvTable.Rows[rowIndex].Cells["Price"].Value = saleList[rowIndex].Price;
                        LblTotalAmount.Text = AmountTotal().ToString();
                    }
                }
            }
        }
        private int AmountTotal()
        {
            int amount = 0;
            foreach (var i in saleList)
            {
                amount = amount + i.Price;
            }
            return amount;
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            SetSale();
            saleList.Clear();
            DataGridViewTool<Sales>.SetDataGridView(DgvTable, saleList, Dgv_EditingControlShowing);
            LblTotalAmount.Text = AmountTotal().ToString();
        }
        private void SetSale()
        {
            ulong saleId = Controllers.GetSaleNextId();
            DateTime dateTime = DateTime.Now;
            foreach (var i in saleList)
            {
                ulong barcode = i.Barcode;
                int quantity = i.Count;
                int price = i.Price;
                int count = i.Quantity - i.Count;
                var product = Controllers.FindProduct(p => p.Barcode == barcode);
                Controllers.AddSaleDetail(saleId, product.ProductId, quantity, price);
                Controllers.UpdateInventory(product.ProductId, p => p.Quantity = count);
                Controllers.UpdateInventory(product.ProductId, p => p.LastUpdated = dateTime);
            }
            Controllers.AddSale(saleId, AmountTotal());
            SetHistoricalData();
        }
        private void SetHistoricalData()
        {
            List<HistoricalData> historicalDatas = new List<HistoricalData>();
            List<SaleDetail> inventoryList = Controllers.GetAllSaleDetail();
            foreach (var item in inventoryList)
            {
                HistoricalData historical = new HistoricalData(item);
                historicalDatas.Add(historical);
            }
            DataGridViewTool<SaleDetail>.SetDataGridView(DgvHistoricalData, historicalDatas);
        }
        private void SearchProduct()
        {
            ulong barcode = ulong.Parse(TxtBarcode.Text);
            if (Controllers.HasProduct(p => p.Barcode == barcode))
            {
                Product product = Controllers.FindProduct(p => p.Barcode == barcode);
                Sales sales = new Sales(product);
                if (saleList.Find(p => p.Barcode == product.Barcode) == null)
                {
                    saleList.Add(sales);
                    DataGridViewTool<Sales>.SetDataGridView(DgvTable, saleList, Dgv_EditingControlShowing);
                    LblTotalAmount.Text = AmountTotal().ToString();
                }
                else
                {
                    MessageBox.Show("此商品已在購物車中。請選擇數量。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TxtBarcode.Clear();
            }
            else
            {
                TxtBarcode.Clear();
                MessageBox.Show("商品不存在。請檢查條碼是否正確。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }
    }
}
