using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using 一盒蛋玩具店.表單;

namespace 一盒蛋玩具店.UI.@class
{
    internal static class Program
    {

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(true, "一盒蛋玩具店_Mutex", out bool createdNew);
            if (!createdNew)
            {
                // 如果已經有相同的程式執行，跳出提示然後退出
                MessageBox.Show("程式已經在執行中！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Desingener());
        }
    }
}
