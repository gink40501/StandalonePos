using System;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 優惠活動資料（名稱、時間與內容）
    /// </summary>
    internal class Promotion
    {
        /// <summary>
        /// 優惠活動 ID
        /// </summary>
        public ulong PromotionId { get; init; }

        /// <summary>
        /// 活動名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 開始時間
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 結束時間
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 優惠內容說明
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 優惠活動資料 建構式
        /// </summary>
        /// <param name="promotionId">優惠活動</param>
        /// <param name="name">活動名稱</param>
        /// <param name="startTime">開始時間</param>
        /// <param name="endTime">結束時間</param>
        /// <param name="content">優惠內容說明</param>
        public Promotion(ulong promotionId, string name, DateTime startTime, DateTime endTime, string content)
        {
            PromotionId = promotionId;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Content = content;
        }
    }
}
