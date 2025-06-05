using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Repository.ProductDetails;


namespace 一盒蛋玩具店.表單
{
    public partial class Price : Form
    {
        Category _category;
        public Price()
        {
            InitializeComponent();
            Controllers.Load();
            LblLastPage.Text = Controllers.GetCatgoryLastPage().ToString();
            NudPage.Maximum = Controllers.GetCatgoryLastPage();
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 更新listbox
        /// </summary>
        /// <param name="listBox"></param>
        private void AutoUpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            List<Category> categories = Controllers.GetCatgoryPagination((int)NudPage.Value);
            foreach (var i in categories)
            {
                listBox.Items.Add(i);
            }
        }
        /// <summary>
        /// 修改顯示方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstData_Format(object sender, ListControlConvertEventArgs e)
        {
            Category category = (Category)e.Value;
            e.Value = category.Name;
        }
        /// <summary>
        /// 切換頁面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 選定旗標
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            _category = (Category)LstData.SelectedItem;
        }
        /// <summary>
        /// 修改資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdata_Click(object sender, EventArgs e)
        {
            if (_category != null)
            {
                string userInput = Interaction.InputBox("請輸入類別名稱", "修改");
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    Controllers.UpdateCategory(_category.CategoryId, p => p.Name = userInput);
                }
            }
            AutoUpdateListBox(LstData);
        }
    }
}

