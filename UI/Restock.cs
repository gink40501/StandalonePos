using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller;
using 一盒蛋玩具店.Repository.ProductDetails;



namespace 一盒蛋玩具店.表單
{
    public partial class Restock : Form
    {
        public Restock()
        {
            InitializeComponent();
            LblLastPage.Text = Controllers.GetCatgoryLastPage().ToString();
            NudPage.Maximum = Controllers.GetCatgoryLastPage();
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 更新頁數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 更新列表資料
        /// </summary>
        /// <param name="listBox">列表</param>
        /// <param name="categories">類型資料</param>
        private void AutoUpdateListBox(ListBox listBox)
        {
            List<Category> categories = Controllers.GetCatgoryPagination((int)NudPage.Value);
            listBox.Items.Clear();
            foreach (var i in categories)
            {
                listBox.Items.Add(i);
            }
        }
        /// <summary>
        /// 列表更新 設定名稱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstData_Format(object sender, ListControlConvertEventArgs e)
        {
            Category category = (Category)e.Value;
            e.Value = category.Name;
        }
        /// <summary>
        /// 新增類別資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("請輸入類別名稱", "新增");
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                Controllers.AddCatgory(userInput);
            }
            AutoUpdateListBox(LstData);
            LblLastPage.Text = Controllers.GetCatgoryLastPage().ToString();
            NudPage.Maximum = Controllers.GetCatgoryLastPage();
        }
        /// <summary>
        /// 修改類別資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.ShowDialog();
            AutoUpdateListBox(LstData);
        }
        /// <summary>
        /// 切換頁面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSwitchForm_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
