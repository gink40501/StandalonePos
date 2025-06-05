using System;
using System.Collections.Generic;
using System.Linq;
using 一盒蛋玩具店.Repository.Invoker;

namespace 一盒蛋玩具店.Repository.DataOperations
{
    internal class GenericDataService<T> :List<T>
    {
        private readonly JsonDataInvoker _invoker;
        private List<T> _dataList;

        /// <summary>
        /// 建構子：建立 JSON invoker 並讀取檔案資料到清單。
        /// </summary>
        /// <param name="path">資料檔案所在路徑（資料夾）。</param>
        /// <param name="fileName">資料檔案名稱（含 .json）。</param>
        public GenericDataService(string path, string fileName)
        {
            _invoker = new JsonDataInvoker(path, fileName);
            _dataList = _invoker.LoadData<T>() ?? new List<T>();
        }

        /// <summary>
        /// 儲存所有變更到 JSON 檔。
        /// </summary>
        public void Save()
        {
            _invoker.SaveData(_dataList);
        }

        /// <summary>
        /// 取得所有資料，或套用過濾後回傳子集合。
        /// </summary>
        /// <param name="filter">可選的 LINQ 篩選式；若為 null 則回傳全部資料。</param>
        /// <returns>符合 filter 條件的資料清單。</returns>
        public List<T> GetAll(Func<T, bool> filter = null)
        {
            return filter == null
                ? _dataList
                : _dataList.Where(filter).ToList();
        }

        /// <summary>
        /// 新增一筆資料到清單末端（需呼叫 Save() 才會持久化）。
        /// </summary>
        /// <param name="item">欲新增的 T 物件。</param>
        public void Add(T item)
        {
            _dataList.Add(item);
        }

        /// <summary>
        /// 依條件尋找第一筆資料。
        /// </summary>
        /// <param name="predicate">判斷欲搜尋物件的條件。</param>
        /// <returns>找到的 T 物件。</returns>
        /// <exception cref="InvalidOperationException">找不到符合條件的資料時拋出。</exception>
        public T Find(Func<T, bool> predicate)
        {
            var found = _dataList.FirstOrDefault(predicate);
            if (found == null)
                throw new InvalidOperationException("找不到符合條件的資料。");
            return found;
        }
        /// <summary>
        /// 取得全部符合條件的物件
        /// </summary>
        /// <param name="predicate">判斷欲搜尋物件的條件</param>
        /// <returns>物件</returns>
        /// <exception cref="InvalidOperationException">找不到符合條件的資料時拋出。</exception>
        public List<T> FindAll(Func<T, bool> predicate)
        {
            List<T> data = _dataList.Where(predicate).ToList();
            if (data.Count == 0)
                throw new InvalidOperationException("找不到符合條件的資料。");
            return data;
        }
        /// <summary>
        /// 依條件更新第一筆資料，由呼叫方提供更新邏輯。
        /// </summary>
        /// <param name="predicate">判斷欲更新物件的條件。</param>
        /// <param name="updateAction">對找到物件執行的更新動作（設定欄位）。</param>
        /// <exception cref="InvalidOperationException">找不到符合條件的資料時拋出。</exception>
        public void Update(Func<T, bool> predicate, Action<T> updateAction)
        {
            var found = Find(predicate);
            if (found== null)
                throw new InvalidOperationException("找不到符合條件的資料。");
            updateAction(found);
        }

        /// <summary>
        /// 依條件移除第一筆符合的資料。
        /// </summary>
        /// <param name="predicate">判斷欲移除物件的條件。</param>
        /// <exception cref="InvalidOperationException">找不到要刪除的資料時拋出。</exception>
        public void Remove(Func<T, bool> predicate)
        {
            var found = _dataList.FirstOrDefault(predicate);
            if (found == null)
                throw new InvalidOperationException("找不到要刪除的資料。");
            _dataList.Remove(found);
        }

        /// <summary>
        /// 取得下一個 ID：用於自動編號的情況。
        /// </summary>
        /// <param name="idSelector">從 T 取出 ID 欄位（ulong）的函式。</param>
        /// <returns>下一個可用的 ID 編號。</returns>
        public ulong GetNextId(Func<T, ulong> idSelector)
        {
            return _dataList.Count == 0
                ? 1
                : _dataList.Max(idSelector) + 1UL;
        }
    }
}
