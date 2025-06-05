using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 商品基本資料
    /// </summary>
    internal class Product
    {
        /// <summary>商品唯一識別碼</summary>
        [DisplayName("商品ID")]
        public ulong ProductId { get; init; }

        /// <summary>商品條碼</summary>
         [DisplayName("商品條碼")]
        public ulong Barcode { get; set; }

        /// <summary>商品名稱</summary>
        [DisplayName("商品名稱")]
        public string Name { get; set; }

        /// <summary>商品種類（分類）</summary>
        [DisplayName("商品種類ID")]
        public ulong CategoryId { get; init; }
        /// <summary>
        /// 商品基本資料建構式
        /// </summary>
        /// <param name="productId">產品辨識碼</param>
        /// <param name="categoryId">商品種類</param>
        /// <param name="barcode">商品條碼</param>
        /// <param name="name">商品名稱</param>
        public Product(ulong productId, ulong categoryId, ulong barcode, string name)
        {
            ProductId = productId;
            Barcode = barcode;
            Name = name;
            CategoryId = categoryId;
        }
    }
}
