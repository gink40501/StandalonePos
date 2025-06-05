using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 產品類型
    /// </summary>
    internal class Category
    {
        /// <summary>
        /// 產品類型名稱
        /// </summary>
        [DisplayName("類型")]
        public string Name { get; set; }
        /// <summary>
        /// 產品類型ID
        /// </summary>
        [DisplayName("類型ID")]
        public ulong CategoryId { get; init; }
        /// <summary>
        /// 產品類型 建構式
        /// </summary>
        /// <param name="name">產品類型名稱</param>
        /// <param name="categoryId">產品類型ID</param>
        public Category(string name, ulong categoryId)
        {
            Name = name;
            CategoryId = categoryId;
        }
    }
}
