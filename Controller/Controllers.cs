using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using 一盒蛋玩具店.Repository.DataOperations;
using 一盒蛋玩具店.Repository.ProductDetails;
using 一盒蛋玩具店.Repository.ProgramToolkit;
using static System.Net.WebRequestMethods;
using System.ComponentModel;
using 一盒蛋玩具店.Controller.Error;
using HarfBuzzSharp;
using static 一盒蛋玩具店.Controller.Controllers;

namespace 一盒蛋玩具店.Controller
{
    internal static class Controllers
    {
        /// <summary>
        /// 包裝服務層的工具
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private static class ControllersPackage<T>
        {
            private static GenericDataService<T> _dataService;
            /// <summary>
            /// 設定調閱的資料
            /// </summary>
            /// <param name="data"></param>
            public static void SetDataService(GenericDataService<T> data)
            {
                _dataService= data;
            }
            /// <summary>
            /// 搜尋符合條件的全部資料
            /// </summary>
            /// <param name="filter">委派</param>
            /// <param name="error">錯誤訊息</param>
            /// <returns>資料</returns>
            /// <exception cref="ToyStoreException"></exception>
            public static List<T> FindAll(Func<T, bool> filter, Error.Error error)
            {
                try
                {
                    return _dataService.FindAll(filter);
                }
                catch (InvalidOperationException)
                {
                    throw new ToyStoreException(error);
                }
            }
            /// <summary>
            /// 搜尋資料
            /// </summary>
            /// <param name="filter">委派</param>
            /// <param name="error">錯誤指令</param>
            /// <returns></returns>
            /// <exception cref="ToyStoreException"></exception>
            public static T Find(Func<T, bool> filter, Error.Error error)
            {
                try
                {
                    return _dataService.Find(filter);
                }
                catch (InvalidOperationException)
                {
                    throw new ToyStoreException(error);
                }
            }
            /// <summary>
            /// 加入資料
            /// </summary>
            /// <param name="data">資料</param>
            public static void Add(T data)
            {
                _dataService.Add(data);
                _dataService.Save();
            }
            /// <summary>
            /// 移除資料
            /// </summary>
            /// <param name="filter">委派</param>
            public static void Remove(Func<T,bool>filter)
            {
                _dataService.Remove(filter);
                _dataService.Save();
            }
            /// <summary>
            /// 獲得分頁
            /// </summary>
            /// <param name="pageNumber">頁數</param>
            /// <param name="filter">委派</param>
            /// <returns>資料</returns>
            /// <exception cref="ToyStoreException"></exception>
            public static List<T> GetPagination(int pageNumber, Func<T, bool> filter = null)
            {
                try
                {
                    List<T> category = _dataService.GetAll(filter);
                    return PaginationToolkit<T>.GoToPage(category, _itemPerPage, pageNumber);
                }
                catch (ArgumentException)
                {
                    throw new ToyStoreException(Error.Error.PageNumberCannotBeZero);
                }
                catch (NoDataFoundException)
                {
                    throw new ToyStoreException(Error.Error.PageOutOfRange);
                }
            }
            /// <summary>
            /// 更改資料
            /// </summary>
            /// <param name="filter">委派搜尋條件</param>
            /// <param name="updateAction">委派更改的資料</param>
            /// <param name="error">錯誤資料</param>
            /// <exception cref="ToyStoreException"></exception>
            public static void Updata(Func<T,bool> filter, Action<T> updateAction, Error.Error error)
            {
                try
                {
                    _dataService.Update(filter, updateAction);
                    _dataService.Save();
                }
                catch (InvalidOperationException)
                {
                    throw new ToyStoreException(error);
                }
            }
            /// <summary>
            /// 查詢資料
            /// </summary>
            /// <param name="func">委派條件</param>
            /// <returns>是否有資料</returns>
            public static bool Exists(Func<T,bool> func)
            {
                try
                {
                    _dataService.Find(func);
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            /// <summary>
            /// 最後一頁
            /// </summary>
            /// <returns>頁數</returns>
            /// <exception cref="ToyStoreException"></exception>
            public static int LastPage()
            {
                try
                {
                    List<T> data = _dataService.GetAll();
                    return PaginationToolkit<T>.GetLastPage(data.Count, _itemPerPage);
                }
                catch (ArgumentException)
                {
                    throw new ToyStoreException(Error.Error.PageNumberCannotBeZero);
                }
            }
        }



        /// <summary>
        /// 單頁顯示的項目數量
        /// </summary>
        private static int _itemPerPage = 10;

        /// <summary>
        /// 商品分類資料操作工具
        /// </summary>
        private static GenericDataService<Category> _category;

        /// <summary>
        /// 商品資料操作工具
        /// </summary>
        private static GenericDataService<Product> _product;

        /// <summary>
        /// 庫存資料操作工具
        /// </summary>
        private static GenericDataService<Inventory> _inventory;

        /// <summary>
        /// 商品價格資料操作工具
        /// </summary>
        private static GenericDataService<ProductPrice> _porductPrice;

        /// <summary>
        /// 促銷活動資料操作工具
        /// </summary>
        private static GenericDataService<Promotion> _promotion;

        /// <summary>
        /// 進貨資料操作工具
        /// </summary>
        private static GenericDataService<Purchase> _purchase;

        /// <summary>
        /// 銷售資料操作工具
        /// </summary>
        private static GenericDataService<Sale> _sale;

        /// <summary>
        /// 銷售明細資料操作工具
        /// </summary>
        private static GenericDataService<SaleDetail> _saleDetail;

        /// <summary>
        /// 廠商資料操作工具
        /// </summary>
        private static GenericDataService<Supplier> _supplier;

        /// <summary>
        /// 路徑設定
        /// </summary>
        private static Config config = new Config("test");

        /// <summary>
        /// 設定單頁 數量 項目
        /// </summary>
        /// <param name="nowItemPerPage1">數量</param>
        public static void SetItemPerPage(int nowItemPerPage1) => _itemPerPage = nowItemPerPage1;

        /// <summary>
        /// 讀取全部的資料
        /// </summary>
        public static void Load()
        {
            _category = new GenericDataService<Category>(config.Path, "Category.json");
            _product = new GenericDataService<Product>(config.Path, "Product.json");
            _inventory = new GenericDataService<Inventory>(config.Path, "Inventory.json");
            _porductPrice = new GenericDataService<ProductPrice>(config.Path, "ProductPrice.json");
            _promotion = new GenericDataService<Promotion>(config.Path, "Promotion.json");
            _purchase = new GenericDataService<Purchase>(config.Path, "Purchase.json");
            _sale = new GenericDataService<Sale>(config.Path, "Sale.json");
            _saleDetail = new GenericDataService<SaleDetail>(config.RecordSalesHistoryPath(), "SaleDetail.json");
            _supplier = new GenericDataService<Supplier>(config.Path, "Supplier.json");
        }
        /// <summary>
        /// 是否有販賣價格
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static bool HasProductPrice(Func<ProductPrice, bool> filter = null)
        {
            ControllersPackage<ProductPrice>.SetDataService(_porductPrice);
            return ControllersPackage<ProductPrice>.Exists(filter);
        }
        /// <summary>
        /// 加入販賣價格
        /// </summary>
        /// <param name="productId">產品ID</param>
        /// <param name="effectiveTime">販賣時間</param>
        /// <param name="price">價格</param>
        public static void AddProductPrice(ulong productId, DateTime effectiveTime, int price)
        {
            ProductPrice productPrice = new ProductPrice(productId, effectiveTime, price);
            ControllersPackage<ProductPrice>.SetDataService(_porductPrice);
            ControllersPackage<ProductPrice>.Add(productPrice);
        }
        /// <summary>
        /// 查詢販賣價格
        /// </summary>
        /// <param name="filter">篩選條件</param>
        /// <returns></returns>
        public static List<ProductPrice> FindAllProductPrice( Func<ProductPrice, bool> filter = null)
        {
            ControllersPackage<ProductPrice>.SetDataService(_porductPrice);
            return ControllersPackage<ProductPrice>.FindAll(filter, Error.Error.PriceInformation);
        }
        /// <summary>
        /// 移除販賣價格
        /// </summary>
        /// <param name="func">篩選條件</param>
        public static void RemoveProductPrice(Func <ProductPrice,bool> func=null)
        {
            ControllersPackage<ProductPrice>.SetDataService(_porductPrice);
            ControllersPackage<ProductPrice>.Remove(func);
        }

        /// <summary>
        /// 新增進貨資料
        /// </summary>
        /// <param name="purchaseOrderNumber">進貨單號</param>
        /// <param name="productId">商品ID</param>
        /// <param name="supplierId">廠商ID</param>
        /// <param name="purchaseTime">進貨時間</param>
        /// <param name="quantity">庫存總量</param>
        /// <param name="unitPrice">進貨總價</param>
        public static void AddPurchase(ulong purchaseOrderNumber,ulong productId,ulong supplierId,DateTime purchaseTime,int quantity,int unitPrice)
        {
            Purchase purchase=new Purchase(purchaseOrderNumber, productId, supplierId, purchaseTime, quantity, unitPrice);
            ControllersPackage<Purchase>.SetDataService(_purchase);
            ControllersPackage<Purchase>.Add(purchase);
        }
        /// <summary>
        /// 取得全部進貨資料
        /// </summary>
        /// <returns>進貨紀錄</returns>
        public static List<Purchase> GetAllPurchase()=>_purchase.GetAll();
        /// <summary>
        /// 搜尋進貨紀錄
        /// </summary>
        /// <param name="filter">搜尋條件</param>
        /// <returns></returns>
        public static List<Purchase> FindAllPurchases(Func<Purchase, bool> filter = null)
        {
            ControllersPackage<Purchase>.SetDataService(_purchase);
           return ControllersPackage<Purchase>.FindAll(filter, Error.Error.PurchaseNotFound);
        }
        /// <summary>
        /// 取得進貨資料(頁)
        /// </summary>
        /// <param name="pageNumber">頁碼</param>
        /// <param name="filter">篩選條件</param>
        /// <returns>進貨資料</returns>
        public static List<Purchase> GetPurchasePagination(int pageNumber, Func<Purchase, bool> filter = null)
        {
            ControllersPackage<Purchase>.SetDataService(_purchase);
            return  ControllersPackage<Purchase>.GetPagination(pageNumber, filter);
        }
        /// <summary>
        /// 加入庫存
        /// </summary>
        /// <param name="productId">商品ID</param>
        /// <param name="quantity">庫存</param>
        /// <param name="dateTime">更新時間</param>
        public static void AddInventory(ulong productId,int quantity,DateTime dateTime)
        {
            Inventory inventory= new Inventory(productId,quantity,dateTime);
            ControllersPackage<Inventory>.SetDataService(_inventory);
            ControllersPackage<Inventory>.Add(inventory);
        }
        /// <summary>
        /// 搜尋庫存
        /// </summary>
        /// <param name="filter">委派條件</param>
        /// <returns>庫存資料</returns>
        /// <exception cref="ToyStoreException"></exception>
        public static Inventory FindInventory(Func<Inventory,bool> filter = null)
        {
            ControllersPackage<Inventory>.SetDataService(_inventory);
           return ControllersPackage<Inventory>.Find(filter, Error.Error.NoStockFound);
        }
        /// <summary>
        /// 修改庫存
        /// </summary>
        /// <param name="productId">商品ID</param>
        /// <param name="updateAction">更改資料</param>
        public static void UpdateInventory(ulong productId, Action<Inventory> updateAction)
        {
            ControllersPackage<Inventory>.SetDataService(_inventory);
            ControllersPackage<Inventory>.Updata(s => s.ProductId == productId, updateAction, Error.Error.NoStockFound);
        }
        /// <summary>
        /// 取得全部庫存
        /// </summary>
        /// <returns></returns>
        public static List<Inventory> GetAllInventory()=>_inventory.GetAll();
        /// <summary>
        /// 新增商品資料
        /// </summary>
        /// <param name="barcode">條碼</param>
        /// <param name="name">商品名稱</param>
        /// <param name="categoryId">類型ID</param>
        public static void AddProduct(ulong barcode,string name,ulong categoryId)
        {
            ControllersPackage<Product>.SetDataService(_product);

            if (ControllersPackage<Product>.Exists(p => p.Barcode == barcode))
            {
                throw new ToyStoreException(Error.Error.ProductBarcodeAlreadyExists);
            }
            else
            {
                Product product = new Product(_product.GetNextId(p => p.ProductId), categoryId, barcode, name);
                ControllersPackage<Product>.Add(product);
            }
        }
        /// <summary>
        /// 查詢商品
        /// </summary>
        /// <param name="filter">篩選條件</param>
        /// <returns></returns>
        public static List<Product> FindAllProduct(Func<Product, bool> filter = null)
        {
            ControllersPackage<Product>.SetDataService(_product);
           return ControllersPackage<Product>.FindAll(filter, Error.Error.ProductNotFound);
        }
        /// <summary>
        /// 是否有商品
        /// </summary>
        /// <param name="filter">委派</param>
        /// <returns>是否</returns>
        public static bool HasProduct(Func<Product, bool> filter = null)
        {
            ControllersPackage<Product>.SetDataService(_product);
            return ControllersPackage<Product>.Exists(filter);
        }
        /// <summary>
        /// 取得全部商品全部資料
        /// </summary>
        /// <returns>商品</returns>
        public static List<Product> GetAllProduct()=>_product.GetAll();
        /// <summary>
        /// 取得商品資料(頁)
        /// </summary>
        /// <param name="pageNumber">頁碼</param>
        /// <param name="filter">篩選條件</param>
        /// <returns>進貨資料</returns>
        public static List<Product> GetProductPagination(int pageNumber, Func<Product, bool> filter = null)
        {
            ControllersPackage<Product>.SetDataService(_product);
            return ControllersPackage<Product>.GetPagination(pageNumber, filter);
        }
        /// <summary>
        /// 檢查價格是否生效
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ToyStoreException"></exception>
        public static ProductPrice GetValidPrice(ulong productId)
        {
            DateTime dateTime = DateTime.Now;
            ProductPrice productPrice=null;
            List<ProductPrice> productPrices = FindAllProductPrice(p => p.ProductId == productId);
            var sortPorductPrice = productPrices.OrderBy(p => p.EffectiveTime).ToList();
            foreach (var p in sortPorductPrice)
            {
                if (dateTime >= p.EffectiveTime)
                {
                    productPrice = p;
                }
            }
            if (productPrice == null)
            {
                throw new ToyStoreException(Error.Error.PriceNotEffective);
            }
            return productPrice;
        }
        /// <summary>
        /// 產品的的頁碼
        /// </summary>
        /// <returns></returns>
        public static int GetProductLastPage()
        {
            ControllersPackage<Product>.SetDataService(_product);
            return ControllersPackage<Product>.LastPage();
        }
        /// <summary>
        /// 外部使用搜尋商品資料
        /// </summary>
        /// <param name="product">委派條件</param>
        /// <returns>商品</returns>
        public static Product FindProduct(Func<Product, bool> product)
        {
            ControllersPackage<Product>.SetDataService(_product);
           return ControllersPackage<Product>.Find(product, Error.Error.ProductNotFound);
        }
        /// <summary>
        /// 取得下一個id
        /// </summary>
        /// <returns></returns>
        public static ulong GetProductNextId() => _product.GetNextId(p => p.ProductId);

        /// <summary>
        /// 新增廠商名稱
        /// </summary>
        /// <param name="name">廠商名</param>
        /// <param name="telephone">電話</param>
        public static void AddSupplier(string name,string telephone)
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
            Supplier supplier = new Supplier(_supplier.GetNextId(p => p.SupplierId), name, telephone);
            ControllersPackage<Supplier>.Add(supplier);
        }
        /// <summary>
        /// 是否查詢廠商
        /// </summary>
        /// <param name="filter">委派條件</param>
        /// <returns>是與否</returns>
        public static bool HasSupplier(Func<Supplier, bool> filter = null)
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
            return ControllersPackage<Supplier>.Exists(filter);
        }
        /// <summary>
        /// 搜尋廠商資料
        /// </summary>
        /// <param name="supplier">委派條件</param>
        /// <returns></returns>
        public static Supplier FindSupplier(Func<Supplier, bool> predicate)
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
            return ControllersPackage<Supplier>.Find(predicate, Error.Error.CatgoryNotFound);
        }
        /// <summary>
        /// 取得廠商資料(頁)
        /// </summary>
        /// <param name="pageNumber">頁數</param>
        /// <param name="filter">塞選條件</param>
        /// <returns>以頁為單位傳輸資料</returns>
        public static List<Supplier> GetSupplierPagination(int pageNumber, Func<Supplier, bool> filter = null)
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
           return ControllersPackage < Supplier >.GetPagination(pageNumber, filter);
        }
        /// <summary>
        /// 取得全部廠商資料
        /// </summary>
        /// <returns>廠商資料</returns>
        public static List<Supplier> GetAllSupplier()=>_supplier.GetAll();
        /// <summary>
        /// 廠商 ID 更新廠商資料。
        /// </summary>
        /// <param name="supplierId">更新的廠商 ID。</param>
        /// <param name="updateAction">更新邏輯的委派。</param>
        public static void UpdateSupplier(ulong supplierId, Action<Supplier> updateAction)
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
            ControllersPackage<Supplier>.Updata(s => s.SupplierId == supplierId, updateAction,Error.Error.VendorNotFound);
        }
        /// <summary>
        /// 廠商最後的頁碼
        /// </summary>
        /// <returns></returns>
        public static int GetSupplierLastPage()
        {
            ControllersPackage<Supplier>.SetDataService(_supplier);
            return ControllersPackage<Supplier>.LastPage();
        }
        /// <summary>
        /// 類型最後一頁頁碼
        /// </summary>
        /// <returns>最後一頁頁碼</returns>
        public static int GetCatgoryLastPage()
        {
            ControllersPackage<Category>.SetDataService(_category);
           return ControllersPackage<Category>.LastPage();
        }

        /// <summary>
        /// 新增商品類別
        /// </summary>
        /// <param name="name">名稱</param>
        public static void AddCatgory(string name)
        {
            ControllersPackage < Category >.SetDataService(_category);
            if (!ControllersPackage<Category>.Exists(p=>p.Name==name))
            {
                throw new ToyStoreException(Error.Error.CatgoryNameAlreadyExists);
            }
            else
            {
                Category category = new Category(name, _category.GetNextId(p => p.CategoryId));
                ControllersPackage<Category>.Add(category);
            }
        }
       /// <summary>
       /// 搜尋類別
       /// </summary>
       /// <param name="category">委派類別</param>
       /// <returns></returns>
        public static Category  FindCategory(Func<Category,bool> category)
        {
            ControllersPackage<Category>.SetDataService(_category);
            if (ControllersPackage<Category>.Exists(category))
            {
                return ControllersPackage<Category>.Find(category,Error.Error.CatgoryNotFound);
            }
            return null;
        }
        /// <summary>
        /// 獲得全部類型資料
        /// </summary>
        /// <returns>類型</returns>
        public static List<Category> GetAllCategory()=>_category.GetAll();
        /// <summary>
        /// 取得商品分類
        /// </summary>
        /// <param name="pageNumber">頁數</param>
        /// <param name="filter">篩選的邏輯的委派</param>
        /// <returns>商品分類</returns>
        public static List<Category> GetCatgoryPagination(int pageNumber, Func<Category, bool> filter = null)
        {
            ControllersPackage<Category>.SetDataService(_category);
           return ControllersPackage < Category >.GetPagination(pageNumber, filter);
        }
        /// <summary>
        /// 修改商品分類
        /// </summary>
        /// <param name="categoryId">商品分類id</param>
        /// <param name="updateAction">更新邏輯的委派</param>
        public static void UpdateCategory(ulong categoryId, Action<Category> updateAction)
        {
            ControllersPackage<Category>.SetDataService(_category);
            ControllersPackage<Category>.Updata(p => p.CategoryId == categoryId, updateAction, Error.Error.CatgoryNotFound);
        }
        /// <summary>
        /// 搜尋銷售紀錄
        /// </summary>
        /// <param name="filter">委派</param>
        /// <returns>銷售紀錄</returns>
        public static Sale FindSale(Func<Sale, bool> filter = null)
        {
            ControllersPackage<Sale>.SetDataService(_sale);
           return ControllersPackage<Sale>.Find(filter, Error.Error.NoSalesDataFound);
        }
        /// <summary>
        /// 加入銷售紀錄
        /// </summary>
        /// <param name="orderNumber">銷售編號</param>
        /// <param name="totalAmount">總價價格</param>
        public static void AddSale(ulong orderNumber, int totalAmount)
        {
            DateTime saleTime = DateTime.Now;
            Sale sale = new Sale(orderNumber,saleTime,totalAmount);
            ControllersPackage<Sale>.SetDataService(_sale);
            ControllersPackage<Sale>.Add(sale);
        }
        /// <summary>
        /// 取得下一個銷售編號
        /// </summary>
        /// <returns></returns>
        public static ulong GetSaleNextId() => _sale.GetNextId(p => p.OrderNumber);
        /// <summary>
        /// 取得全部的銷售紀錄
        /// </summary>
        /// <returns></returns>
        public static List<Sale> GetAllSale() => _sale.GetAll();
        /// <summary>
        /// 商品銷售明細
        /// </summary>
        /// <param name="orderNumber">訂單編號</param>
        /// <param name="productId">商品ID</param>
        /// <param name="quantity">數量</param>
        /// <param name="unitPrice">價格</param>
        public static void AddSaleDetail(ulong orderNumber, ulong productId, int quantity, int unitPrice)
        {
            SaleDetail saleDetail = new SaleDetail(orderNumber, productId, quantity, unitPrice);
            ControllersPackage<SaleDetail>.SetDataService(_saleDetail);
            ControllersPackage<SaleDetail>.Add(saleDetail);
        }
        /// <summary>
        /// 取得全部的商品銷售明細
        /// </summary>
        /// <returns>全部商品銷售明細</returns>
        public static List<SaleDetail> GetAllSaleDetail() => _saleDetail.GetAll();
        /// <summary>
        /// 搜尋全部的商品銷售明細
        /// </summary>
        /// <param name="filter">委派</param>
        /// <returns></returns>
        public static List<SaleDetail> FindAllSale(Func<SaleDetail, bool> filter = null)
        {
            ControllersPackage<SaleDetail>.SetDataService(_saleDetail);
            return ControllersPackage<SaleDetail>.FindAll(filter, Error.Error.NoSalesDataFound);
        }

    }
}
