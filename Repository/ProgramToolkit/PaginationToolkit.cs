using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace 一盒蛋玩具店.Repository.ProgramToolkit
{
    /// <summary>
    /// 分頁服務
    /// </summary>
    /// <typeparam name="T">資料</typeparam>
    internal static  class PaginationToolkit<T>
    {

        /// <summary>
        /// 跳頁
        /// </summary>
        /// <param name="pageNumber">目標頁碼（從 1 開始）</param>
        /// <returns>一頁資料</returns>
        /// <exception cref="NoDataFoundException"></exception>
        public static List<T> GoToPage<T>(List<T> data, int itemPerPage, int pageNumber, Func<T, bool> filter = null)
        {
            if (itemPerPage <= 0)
                throw new ArgumentException("每頁項目數必須大於 0", nameof(itemPerPage));
            if (pageNumber <= 0)
                throw new ArgumentException("頁碼必須大於 0", nameof(pageNumber));

            List<T> filteredData = filter == null ? data : data.Where(filter).ToList();

            int lastPage = GetLastPage(filteredData.Count, itemPerPage);

            // 這裡改成允許在無資料時仍顯示第 1 頁
            if (filteredData.Count == 0 && pageNumber == 1)
            {
                return new List<T>(); // 回傳空頁資料
            }

            if (pageNumber > lastPage)
            {
                throw new NoDataFoundException($"無第 {pageNumber} 頁面，最後頁碼為 {lastPage}");
            }

            int startIndex = (pageNumber - 1) * itemPerPage;
            int remaining = filteredData.Count - startIndex;
            int count = Math.Min(itemPerPage, remaining);

            return filteredData.GetRange(startIndex, count);
        }

        /// <summary>
        /// 取得最後一頁的頁碼
        /// </summary>
        public static int GetLastPage(int dataCount, int itemsPerPage)
        {
            if (itemsPerPage <= 0)
                throw new ArgumentException("每頁項目數必須大於 0", nameof(itemsPerPage));

            int pages = (int)Math.Ceiling(dataCount / (double)itemsPerPage);
            return pages == 0 ? 1 : pages;
        }
        public class NoDataFoundException : Exception
        {
            public NoDataFoundException(string message) : base(message) { }
        }
    }
}
