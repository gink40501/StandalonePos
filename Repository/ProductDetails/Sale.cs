using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 銷售紀錄（訂單主檔）
    /// </summary>
    internal class Sale
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public ulong OrderNumber { get; init; }

        /// <summary>
        /// 銷售時間
        /// </summary>
        public DateTime SaleTime { get; set; }

        /// <summary>
        /// 總金額
        /// </summary>
        public int TotalAmount { get; set; }
        /// <summary>
        /// 銷售紀錄 建構式
        /// </summary>
        /// <param name="orderNumber">訂單編號</param>
        /// <param name="saleTime">銷售時間</param>
        /// <param name="totalAmount">總金額</param>
        public Sale(ulong orderNumber, DateTime saleTime, int totalAmount)
        {
            OrderNumber = orderNumber;
            SaleTime = saleTime;
            TotalAmount = totalAmount;
        }
    }
}
