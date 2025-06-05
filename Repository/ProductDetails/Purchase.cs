using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 進貨紀錄（包含商品、廠商、數量與單價）
    /// </summary>
    internal class Purchase
    {
        /// <summary>
        /// 進貨單號
        /// </summary>
        public ulong PurchaseOrderNumber { get; set; }

        /// <summary>
        /// 進貨的商品 ID
        /// </summary>
        public ulong ProductId { get; init; }

        /// <summary>
        /// 供應廠商 ID
        /// </summary>
        public ulong SupplierId { get; init; }

        /// <summary>
        /// 進貨時間
        /// </summary>
        public DateTime PurchaseTime { get; set; }

        /// <summary>
        /// 進貨數量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 進貨單價
        /// </summary>
        public int UnitPrice { get; set; }
        /// <summary>
        /// 進貨紀錄 建構式
        /// </summary>
        /// <param name="purchaseOrderNumber">進貨單號</param>
        /// <param name="productId">進貨的商品 ID</param>
        /// <param name="supplierId">供應廠商 ID</param>
        /// <param name="purchaseTime">進貨時間</param>
        /// <param name="quantity">進貨數量</param>
        /// <param name="unitPrice">進貨單價</param>
        public Purchase(ulong purchaseOrderNumber, ulong productId, ulong supplierId, DateTime purchaseTime, int quantity, int unitPrice)
        {
            PurchaseOrderNumber = purchaseOrderNumber;
            ProductId = productId;
            SupplierId = supplierId;
            PurchaseTime = purchaseTime;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
