using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace 一盒蛋玩具店.Repository.ProgramToolkit
{
    internal class JsonToolkit
    {

        /// <summary>
        ///儲存路徑
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 檔案名稱
        /// </summary>
        public string Name { get; set; }
        public JsonToolkit(string path, string name)
        {
            Path = path;
            Name = name;
        }
        /// <summary>
        /// 完整路徑
        /// </summary>
        private string FullPath => System.IO.Path.Combine(Path, Name);
        /// <summary>
        /// 從 JSON 檔案讀取資料
        /// </summary>
        public List<T> Load<T>()
        {
            if (!File.Exists(FullPath))
            {
                Directory.CreateDirectory(Path); // 確保資料夾存在
                File.WriteAllText(FullPath, "[]"); // 建立空 JSON 陣列檔案
                //throw new FileNotFoundException($"找不到 JSON 檔案：{FullPath}");
            }

            try
            {
                var json = File.ReadAllText(FullPath);
                var result = JsonSerializer.Deserialize<List<T>>(json);
                if (result == null)
                {
                    throw new JsonException($"JSON 反序列化失敗，無法轉換為 List<{typeof(T).Name}>。");
                }
                return result;
            }
            catch (JsonException ex)
            {
                throw new JsonException($"JSON 反序列化失敗：{ex.Message}", ex);
            }
            catch (IOException ex)
            {
                throw new IOException($"讀取檔案時發生錯誤：{ex.Message}", ex);
            }
        }
        /// <summary>
        /// 讀取原始 JSON 字串（未處理格式），檔案不存在時回傳空字串，發生 I/O 錯誤時拋出 IOException
        /// </summary>
        /// <exception cref="IOException">當讀取檔案時發生 I/O 錯誤時拋出。</exception>
        public string ReadRaw()
        {
            if (!File.Exists(FullPath))
            {
                return string.Empty; // 檔案不存在時，維持原本回傳空字串的行為
            }

            try
            {
                return File.ReadAllText(FullPath);
            }
            catch (IOException ex)
            {
                throw new IOException($"讀取檔案時發生錯誤：{ex.Message}", ex);
            }
        }
        /// <summary>
        /// 寫入原始字串（序列化請由外部處理），寫入失敗時拋出 IOException
        /// </summary>
        /// <exception cref="IOException">當寫入檔案時發生 I/O 錯誤時拋出。</exception>
        public void WriteRaw(string content)
        {
            try
            {
                Directory.CreateDirectory(Path); // 確保資料夾存在
                File.WriteAllText(FullPath, content);
            }
            catch (IOException ex)
            {
                throw new IOException($"寫入檔案時發生錯誤：{ex.Message}", ex);
            }
        }


    }
}
