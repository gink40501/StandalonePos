using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一盒蛋玩具店.Repository.ProductDetails
{
    /// <summary>
    /// 廠商資料
    /// </summary>
    internal class Supplier
    {
        /// <summary>
        /// 廠商 ID
        /// </summary>
        [DisplayName("廠商id")]
        public ulong SupplierId { get; init; }

        /// <summary>
        /// 廠商名稱
        /// </summary>
        [DisplayName("廠商名稱")]
        public string Name { get; set; }

        /// <summary>
        /// 廠商聯絡電話
        /// </summary>
        [DisplayName("電話")]
        public string Phone { get; set; }
        /// <summary>
        /// 廠商資料 建構式
        /// </summary>
        /// <param name="supplierId">廠商 ID</param>
        /// <param name="name">廠商名稱</param>
        /// <param name="phone">廠商聯絡電話</param>
        public Supplier(ulong supplierId, string name, string phone)
        {
            SupplierId = supplierId;
            Name = name;
            Phone = phone;
        }
        /// <summary>
        /// 建立此 Supplier 的深層複製物件。
        /// </summary>
        /// <returns>一個與原始 Supplier 資料相同、但記憶體獨立的新 Supplier 物件。</returns>
        public object Clone()
        {
            return new Supplier(SupplierId, Name, Phone);
        }
    }
}
