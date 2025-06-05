using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;

namespace 一盒蛋玩具店.UI
{
    public partial class AddProductData : Form
    {
        class PrintData
        {
            private Product _product;
            private Category _category;
            /// <summary>
            /// 產品名稱
            /// </summary>
            [DisplayName("產品")]
            public string ProductName { get { return _product.Name; } }
            /// <summary>
            /// 條碼
            /// </summary>
            [DisplayName("條碼")]
            public ulong Barcode { get { return _product.Barcode; } }
            /// <summary>
            /// 廠商名稱
            /// </summary>
            [DisplayName("類型")]
            public string CategoryName { get { return _category.Name; } }
            public PrintData(Product product, Category category)
            {
                _product = product;
                _category = category;
            }
        }

        Product _product;
        /// <summary>
        /// id
        /// </summary>
        ulong _id;
        /// <summary>
        /// 新商品(Prodict)
        /// </summary>
        public object NewProdict { get; set; }
        /// <summary>
        /// 設定商品種類
        /// </summary>
        public object SetCategory { get; set; }
        public AddProductData()
        {
            InitializeComponent();
            LblLastPage.Text = Controllers.GetCatgoryLastPage().ToString();
            NudPage.Maximum = Controllers.GetCatgoryLastPage();
            AutoUpdateListBox(LstCategory);
            PnlSelect.Enabled = false;
            PnlSet.Enabled = false;
        }
        private void AutoUpdateListBox(ListBox listBox)
        {
            try
            {
                List<Category> categories = Controllers.GetCatgoryPagination((int)NudPage.Value);
                if (categories != null)
                {
                    LstCategory.Items.Clear();
                    foreach (var i in categories)
                    {
                        LstCategory.Items.Add(i);
                    }
                }
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string result = Interaction.InputBox("輸入種類：", "輸入視窗");

                if (!string.IsNullOrWhiteSpace(result))
                {
                    Controllers.AddCatgory(result);
                }
                AutoUpdateListBox(LstCategory);
            }
            catch (ToyStoreException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LstCategory_Format(object sender, ListControlConvertEventArgs e)
        {
            Category category = (Category)e.Value;
            e.Value = category.Name;
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            AutoUpdateListBox(LstCategory);
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\r')
            {
                SearchProdict();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (PnlSelect.Enabled == true)
            {
                NewProdict = _product;
                SetCategory = Controllers.FindCategory(p => p.CategoryId == _product.CategoryId);
                this.Close();
            }
            if (PnlSet.Enabled == true)
            {
                if (_id != 0 && TxtName.Text != "" && TxtBarcode.Text != "")
                {
                    NewProdict = new Product(Controllers.GetProductNextId(), _id, ulong.Parse(TxtBarcode.Text), TxtName.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("輸入錯誤");
                }
            }
        }

        private void LstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            object i = LstCategory.SelectedItem;
            if (i != null)
            {
                Category category = (Category)i;
                SetCategory = i;
                _id = category.CategoryId;
            }

        }
        private void SearchProdict()
        {
            try
            {
                var product = Controllers.FindProduct(p => p.Barcode == ulong.Parse(TxtBarcode.Text));
                var category = Controllers.FindCategory(p => p.CategoryId == product.CategoryId);
                PrintData printData = new PrintData(product, category);
                List<PrintData> printList = new List<PrintData>();
                printList.Add(printData);
                DataGridViewTool<PrintData>.SetDataGridView(DgvProduct, printList);
                tabControl1.SelectedTab = TpSelect;
                PnlSelect.Enabled = true;
                PnlSet.Enabled = false;
                TxtBarcode.Clear();
                _product = product;
            }
            catch (ToyStoreException ex)
            {
                tabControl1.SelectedTab = TpSet;
                PnlSelect.Enabled = false;
                PnlSet.Enabled = true;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchProdict();
        }
    }
}
