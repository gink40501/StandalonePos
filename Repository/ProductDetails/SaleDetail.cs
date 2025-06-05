using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 單筆訂單中的商品明細資料
    /// </summary>
    internal class SaleDetail
    {
        /// <summary>
        /// 所屬訂單編號
        /// </summary>
        [DisplayName("訂單編號")]
        public ulong OrderNumber { get; init; }

        /// <summary>
        /// 商品 ID
        /// </summary>
        [DisplayName("商品 ID")]
        public ulong ProductId { get; init; }

        /// <summary>
        /// 銷售數量
        /// </summary>
        [DisplayName("銷售數量")]
        public int Quantity { get; set; }

        /// <summary>
        /// 銷售單價
        /// </summary>
        [DisplayName("銷售單價")]
        public int UnitPrice { get; set; }
        /// <summary>
        /// 單筆訂單中的商品明細資料 建構式
        /// </summary>
        /// <param name="orderNumber">所屬訂單編號</param>
        /// <param name="productId">商品 ID</param>
        /// <param name="quantity">銷售數量</param>
        /// <param name="unitPrice">銷售單價</param>
        public SaleDetail(ulong orderNumber, ulong productId, int quantity, int unitPrice)
        {
            OrderNumber = orderNumber;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
