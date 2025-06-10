using System;
using System.ComponentModel;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 商品價格紀錄，可用於多種價格策略
    /// </summary>
    internal class ProductPrice
    {
        /// <summary>
        /// 所屬商品的 ID
        /// </summary>
        [DisplayName("商品ID")]
        public ulong ProductId { get; init; }

        ///// <summary>
        ///// 價格類型編號（如一般價、促銷價）
        ///// </summary>
        //public ulong PriceTypeId { get; init; }

        /// <summary>
        /// 價格生效時間
        /// </summary>
        [DisplayName("價格生效時間")]
        public DateTime EffectiveTime { get; set; }

        /// <summary>
        /// 實際價格
        /// </summary>
        [DisplayName("售價")]
        public int Price { get; set; }
        /// <summary>
        /// 商品價格紀錄建構式
        /// </summary>
        /// <param name="productId">所屬商品的 ID</param>
        /// <param name="priceTypeId">價格類型編號</param>
        /// <param name="effectiveTime">價格生效時間</param>
        /// <param name="price">實際價格</param>
        public ProductPrice(ulong productId, DateTime effectiveTime, int price)
        {
            ProductId = productId;
            //PriceTypeId = priceTypeId;
            EffectiveTime = effectiveTime;
            Price = price;
        }
    }
}
