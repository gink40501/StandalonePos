using System.Collections.Generic;
using System.Text.Json;
using 一盒蛋玩具店.Repository.ProgramToolkit;

namespace 一盒蛋玩具店.Repository.Invoker
{
    internal class JsonDataInvoker
    {
        private readonly JsonToolkit _jsonToolkit;

        public JsonDataInvoker(string path, string name)
        {
            _jsonToolkit = new JsonToolkit(path, name);
        }
        /// <summary>
        /// 從 JSON 檔案讀取資料並反序列化為 List<T>
        /// </summary>
        /// <typeparam name="T">要反序列化的目標列表元素類型</typeparam>
        /// <returns>從檔案讀取並反序列化後的 List<T>，如果檔案不存在則回傳 null。</returns>
        /// <exception cref="System.IO.FileNotFoundException">當指定的 JSON 檔案不存在時拋出 (由 JsonToolkit 處理)。</exception>
        /// <exception cref="JsonException">當 JSON 反序列化失敗時拋出 (由 JsonToolkit 處理)。</exception>
        /// <exception cref="System.IO.IOException">當讀取檔案時發生其他 I/O 錯誤時拋出 (由 JsonToolkit 處理)。</exception>
        public List<T> LoadData<T>() => _jsonToolkit.Load<T>();
        /// <summary>
        /// 將提供的資料物件序列化為 JSON 並儲存到檔案中
        /// </summary>
        /// <typeparam name="T">要儲存的資料類型</typeparam>
        /// <param name="data">要儲存的資料物件</param>
        /// <exception cref="System.IO.IOException">寫入檔案發生錯誤時拋出。</exception>
        /// <exception cref="JsonException">序列化資料失敗時拋出。</exception>
        public void SaveData<T>(T data)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data);
                _jsonToolkit.WriteRaw(jsonString);
            }
            catch (JsonException ex)
            {
                throw new JsonException($"序列化物件為 JSON 字串時發生錯誤：{ex.Message}", ex);
            }
            catch (System.IO.IOException ex)
            {
                throw new System.IO.IOException($"使用 JsonToolkit 寫入檔案時發生錯誤：{ex.Message}", ex);
            }
        }


    }
}
