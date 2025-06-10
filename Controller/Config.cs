using System;

namespace 一盒蛋玩具店.Controller
{
    internal class Config
    {
        /// <summary>
        /// 儲存路徑
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// 建構子初始化
        /// </summary>
        /// <param name="folder">資料夾名稱</param>
        public Config(string folder)
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Path = System.IO.Path.Combine(Path, folder);
        }
        /// <summary>
        /// 取得 (路徑\年-月\年-月-日) 
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>(路徑\年-月\年-月-日) </returns>
        public string RecordSalesHistoryPath(DateTime? dateTime = null)
        {
            DateTime nowDateTime = (dateTime == null) ? DateTime.Now : (DateTime)dateTime;
            string path = System.IO.Path.Combine(Path, nowDateTime.ToString("yyy-MM"));
            return System.IO.Path.Combine(path, nowDateTime.ToString("yyy-MM-d"));
        }

    }
}
