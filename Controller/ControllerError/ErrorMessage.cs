using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace 一盒蛋玩具店.Controller.Error
{
    public  enum Error
    {
        /// <summary>
        /// 正常
        /// </summary>
        normal,
        /// <summary>
        /// 搜尋不到廠商
        /// </summary>
        VendorNotFound,
        /// <summary>
        /// 廠商名稱已有重複
        /// </summary>
        VendorNameAlreadyExists,
        /// <summary>
        /// 搜尋不到商品
        /// </summary>
        ProductNotFound,
        /// <summary>
        /// 商品條碼已重複
        /// </summary>
        ProductBarcodeAlreadyExists,
        /// <summary>
        /// 商品種類的名稱已有重複
        /// </summary>
        CatgoryNameAlreadyExists,
        /// <summary>
        /// 商品種類搜尋不到
        /// </summary>
        CatgoryNotFound,
        /// <summary>
        /// 超過頁面
        /// </summary>
        PageOutOfRange,
        /// <summary>
        /// 頁碼不可為零
        /// </summary>
        PageNumberCannotBeZero,
        /// <summary>
        /// 找不到進貨紀錄
        /// </summary>
        PurchaseNotFound,
        /// <summary>
        /// 未設定商品價格
        /// </summary>
        PriceNotSet,
        /// <summary>
        /// 找不到價格資料
        /// </summary>
        PriceInformation,
        /// <summary>
        /// 搜尋不到庫存
        /// </summary>
        NoStockFound,
        /// <summary>
        /// 價格未生效
        /// </summary>
        PriceNotEffective,
        /// <summary>
        /// 銷售資料搜尋不到
        /// </summary>
        NoSalesDataFound,
    }
    internal static class ErrorMessage
    {
        /// <summary>
        /// 錯誤訊息字典
        /// </summary>
        private static readonly Dictionary<Error, string> _errorNames = new()
        {
            { Error.normal, "正常" },
            { Error.VendorNotFound, "搜尋不到廠商" },
            { Error.VendorNameAlreadyExists, "廠商名稱已有重複" },
            { Error.ProductNotFound,"搜尋不到商品"},
            { Error.ProductBarcodeAlreadyExists,"商品條碼已重複"},
            { Error.CatgoryNotFound,"商品種類搜尋不到"},
            { Error.CatgoryNameAlreadyExists,"商品種類的名稱已有重複"},
            { Error.PageOutOfRange,"超過頁面"},
            { Error.PageNumberCannotBeZero,"頁碼不可為零"},
            { Error.PurchaseNotFound,"找不到進貨紀錄"},
            { Error.PriceNotSet,"未設定商品價格"},
            { Error.PriceInformation,"找不到價格資料"},
            { Error.NoStockFound,"搜尋不到庫存"},
            { Error.PriceNotEffective,"價格未生效"},
            { Error.NoSalesDataFound,"銷售資料搜尋不到"}
        };
        /// <summary>
        /// 取得訊息錯誤訊息
        /// </summary>
        /// <param name="status">錯誤列舉</param>
        /// <returns>訊息</returns>
        public static string GetErrorMessage(Error status)
        {
            return _errorNames.TryGetValue(status, out var name) ? name : status.ToString();
        }
    }
}
