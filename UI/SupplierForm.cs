using System;
using System.Collections.Generic;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Repository.ProductDetails;

namespace 一盒蛋玩具店.UI
{
    public partial class SupplierForm : Form
    {
        /// <summary>
        /// 設定廠商
        /// </summary>
        public object SetSupplier { get; set; }
        private Supplier _supplier;
        public SupplierForm()
        {
            InitializeComponent();
            LblLastPage.Text = Controllers.GetSupplierLastPage().ToString();
            NudPage.Maximum = Controllers.GetCatgoryLastPage();
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 更新列表資料
        /// </summary>
        /// <param name="listBox">列表</param>
        /// <param name="categories">類型資料</param>
        private void AutoUpdateListBox(ListBox listBox)
        {
            List<Supplier> suppliers = Controllers.GetSupplierPagination((int)NudPage.Value);
            listBox.Items.Clear();
            foreach (var i in suppliers)
            {
                listBox.Items.Add(i);
            }
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            AutoUpdateListBox(LstData);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
            AutoUpdateListBox(LstData);
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            SetSupplier = _supplier;
            this.Close();
        }

        private void LstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            _supplier = (Supplier)LstData.SelectedItem;
        }

        private void LstData_Format(object sender, ListControlConvertEventArgs e)
        {
            Supplier supplier = (Supplier)e.Value;
            e.Value = supplier.Name;
        }

    }
}
