using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 一盒蛋玩具店.Controller.Error;
using 一盒蛋玩具店.Repository.ProductDetails;
using static 一盒蛋玩具店.SaleForm;

namespace 一盒蛋玩具店.Controller
{
    internal static class DataGridViewTool<T>
    {

        public static void SetDataGridView(
            DataGridView dgv,
            List<Sales> data,
            Action<object, DataGridViewEditingControlShowingEventArgs>? onEditingControlShowing = null
        )
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            dgv.DataError += (s, e) => e.ThrowException = false;
            foreach (var prop in props)
            {
                string header = prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? prop.Name;
                if (header == "隱藏") continue;

                if (header == "數量")
                {
                    dgv.Columns.Add(new DataGridViewComboBoxColumn
                    {
                        HeaderText = header,
                        Name = prop.Name, // 一定要設定 Name
                        DataPropertyName = prop.Name,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                        ValueType = typeof(int)
                    });
                }
                else
                {
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = header,
                        Name = prop.Name,
                        DataPropertyName = prop.Name,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }
            }
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.ReadOnly = col.HeaderText != "數量";
            }

            dgv.Rows.Clear();
            int index = 0;
            foreach (var item in data)
            {
                dgv.Rows.Add();
                var row = dgv.Rows[index];
                foreach (var prop in props)
                {
                    string header = prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? prop.Name;
                    if (header == "隱藏") continue;

                    var cell = row.Cells[prop.Name];
                    var value = prop.GetValue(item);
                    if (!(cell is DataGridViewComboBoxCell))
                    {
                        cell.Value = value;
                    }
                }

                if (row.Cells["Count"] is DataGridViewComboBoxCell comboCell)
                {
                    var quantityProp = typeof(T).GetProperty("Quantity");
                    int maxQty = quantityProp != null
                        ? (int)quantityProp.GetValue(item)!
                        : 1;

                    comboCell.Items.Clear();
                    for (int q = 1; q <= maxQty; q++)
                        comboCell.Items.Add(q);
                    var countProp = typeof(T).GetProperty("Count");
                    int currentCount = countProp != null
                        ? (int)countProp.GetValue(item)!
                        : 1;
                    comboCell.Value = currentCount;
                }

                index++;
            }
            if (onEditingControlShowing != null)
            {
                dgv.EditingControlShowing -= new DataGridViewEditingControlShowingEventHandler(onEditingControlShowing);
                dgv.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(onEditingControlShowing);
            }
        }

        /// <summary>
        /// 設定DGV為指定的資料型別，並設定欄位屬性。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgv">DGV</param>
        /// <param name="data">綁定的資料</param>
        /// <param name="mode">設定框設定</param>
        public static void SetDataGridView<T>(
            DataGridView dgv,
            List<T> data,
            DataGridViewAutoSizeColumnMode? mode = null)
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dgv.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            dgv.DataError += (s, e) => e.ThrowException = false;

            mode ??= DataGridViewAutoSizeColumnMode.Fill;
            foreach (var prop in props)
            {
                string header = prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? prop.Name;
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = prop.Name,
                    Name = prop.Name,
                    HeaderText = header,
                    AutoSizeMode = mode.Value
                });
            }
            dgv.DataSource = data;
        }

    }
}
