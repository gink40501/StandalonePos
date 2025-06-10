using System;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 商品庫存資料
    /// </summary>
    internal class Inventory
    {
        /// <summary>
        /// 商品 ID
        /// </summary>
        public ulong ProductId { get; init; }

        /// <summary>
        /// 目前庫存數量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 最後更新時間
        /// </summary>
        public DateTime LastUpdated { get; set; }
        /// <summary>
        /// 商品庫存資料建構式
        /// </summary>
        /// <param name="productId">商品 ID</param>
        /// <param name="quantity">目前庫存數量</param>
        /// <param name="lastUpdated">最後更新時間</param>
        public Inventory(ulong productId, int quantity, DateTime lastUpdated)
        {
            ProductId = productId;
            Quantity = quantity;
            LastUpdated = lastUpdated;
        }
    }
}
