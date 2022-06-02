using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API {
    public class Item {
        /// <summary>
        /// 物品UUID/GUID
        /// </summary>
        public string Id { get; } //uuid
        /// <summary>
        /// 物品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 物品簡述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 物品供應商id
        /// </summary>
        public string SupplierID { get; set; }
        //private bool inCombo = false;
        /// <summary>
        /// 物品價格, 只接受大於或等於 0
        /// </summary>
        public double Price {
            get { return _price; }
            set {
                if (Price >= 0) _price = value;
                else throw new ItemPriceIllegalException();
            }
        }
        private double _price;
        /// <summary>
        /// 物品數量, 只接受大於或等於 0
        /// </summary>
        public int Qty { 
            get { return _qty; } 
            set {
                if (value >= 0) _qty = value;
                else throw new ItemQtyIllegalException();
            } 
        }
        private int _qty;
        /// <summary>
        /// 物品價格, 只接受 0至3範圍內的數字
        /// </summary>
        public int Type {
            get { return _type; }
            set {
                if (value >= 0 && value <= 3) _type = value;
                else throw new ItemTypeIllegalException();
            }
        }
        private int _type;

        /// <summary>
        /// 建立現有物品
        /// </summary>
        /// <param name="id">物品UUID/GUID</param>
        /// <param name="name">物品名稱</param>
        /// <param name="price">物品價格</param>
        /// <param name="type">物品類型</param>
        /// <param name="supplierID">物品供應商id(可選)</param>
        /// <param name="description">物品簡述(可選)</param>
        /// <param name="qty">物品數量(可選)</param>
        public Item(string id, string name, double price, int type, string supplierID = null, string description = null, int qty = 1) {
            this.Id = Guid.Parse(id).ToString();
            this.Name = name;
            this.Description = description;
            this.Qty = qty;
            this.Price = price;
            this.Type = type;
            this.SupplierID = supplierID;
        }

        /// <summary>
        /// 創建新的物品
        /// </summary>
        /// <param name="name">物品名稱</param>
        /// <param name="price">物品價格</param>
        /// <param name="type">物品類型</param>
        /// <param name="supplierID">物品供應商id(可選)</param>
        /// <param name="description">物品簡述(可選)</param>
        /// <param name="qty">物品數量(可選)</param>
        public Item(string name, double price, int type, string supplierID = null, string description = null, int qty = 1) {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Description = description;
            this.Qty = qty;
            this.Price = price;
            this.Type = type;
            this.SupplierID = supplierID;
        }

        /// <summary>
        /// 增加物品數量
        /// </summary>
        public void AddQty() {
            Qty++;
        }

        /// <summary>
        /// 減少物品數量
        /// </summary>
        public void ReduceQty() {
            Qty -= 1;
        }

        /// <summary>
        /// 取得目前數量的總價錢
        /// </summary>
        /// <returns>總價錢</returns>
        public double GetTotalPrice() {
            return Price * Qty;
        }

        public Item Clone() {
            return new Item(Id, Name, Price, Type, SupplierID, Description, Qty);
        }

        /*internal void setInCombo(bool inCombo) {
            this.inCombo = inCombo;
        }*/

        override public string ToString() {
            return String.Format("Item:{0}(Name: {1}, Description: {2}, Type: {3}, Price: {4}, Qty: {5}, Total Price: {6}, SupplierID: {7})", Id, Name, Description, ItemType.GetTypeName(Type), Price, Qty, GetTotalPrice(), SupplierID);
        }
    }

    public class Combo {
        /// <summary>
        /// 套裝內的物品
        /// </summary>
        private readonly List<Item> _items = new List<Item>();
        /// <summary>
        /// 套裝名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 套裝簡述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 套裝UUID/GUID
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// 套裝價格, 只接受 0至3範圍內的數字
        /// </summary>
        public double Price {
            get {
                return _price;
            }
            set {
                if (value >= 0) _price = value;
                else throw new ItemPriceIllegalException();
            }
        }
        private double _price;

        /// <summary>
        /// 建立現有套裝
        /// </summary>
        /// <param name="id">套裝UUID/GUID</param>
        /// <param name="name">套裝名稱</param>
        /// <param name="price">套裝價格, 只接受 0至3範圍內的數字</param>
        /// <param name="description">套裝簡述(可選)</param>
        public Combo(string id, string name, double price, string description = null) {
            this.Price = price;
            this.Name = name;
            this.Id = Guid.Parse(id).ToString();
            this.Description = description;
        }

        /// <summary>
        /// 創建新套裝
        /// </summary>
        /// <param name="name">套裝名稱</param>
        /// <param name="price">套裝價格, 只接受 0至3範圍內的數字</param>
        /// <param name="description">套裝簡述(可選)</param>
        /// <param name="qty">套裝數量, 只接受 0至3範圍內的數字(可選)</param>
        public Combo(string name, double price, string description = null) {
            this.Price = price;
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
            this.Description = description;
        }

        /// <summary>
        /// 加入物品, 如果物品數量大於1將會 -1數量, 物品數量必須大於 0<br></br>
        /// 物件會被複製一份, 更改套裝內的物件不會影響到原本的物件
        /// </summary>
        /// <param name="item">物品</param>
        public void AddItem(Item item) {
            if (item.Qty == 1) {
                _items.Add(item.Clone());
                if (item.Qty > 1) {
                    item.ReduceQty();
                }
            } else { 
                throw new ComboAddItemQtyIllegalException();
            }
        }

        /// <summary>
        /// 取得所有物品
        /// </summary>
        /// <returns>物品列表</returns>
        public List<Item> GetItemsList() {
            return _items;
        }

        /// <summary>
        /// 取得套裝物品數量
        /// </summary>
        /// <returns>物品數量</returns>
        public int Size() {
            return _items.Count;
        }

        /// <summary>
        /// 刪除物品
        /// </summary>
        /// <param name="item">物品</param>
        public void Clear() {
            _items.Clear();
        }

        /// <summary>
        /// 查看原價與套裝價格的折扣價錢<br></br>
        /// 如果物品擁有的數量多於一個只當一個計算
        /// </summary>
        /// <returns>折扣價錢</returns>
        public double DiscountPrice() {
            double total = 0.0;
            foreach (Item item in _items) {
                total += item.Price;
            }
            return total - Price;
        }

        override public string ToString() {
            String items = "\n";
            foreach(Item item in _items) {
                items += "    "+item.ToString()+"\n";
            }
            items += "\n";
            return String.Format("Combo:{0}(Name: {1}, Description, {2}, Price: {3}, Discount Price: -{4}, Items: [{5}])", Id, Name, Description, Price, DiscountPrice(), items);
        }
    }

    /// <summary>
    /// 物品類型
    /// </summary>
    public class ItemType {
        /// <summary>
        /// 普通物品
        /// </summary>
        public const int Common = 0;
        /// <summary>
        /// 大型物品
        /// </summary>
        public const int Large = 1;
        /// <summary>
        /// 需要安裝物品
        /// </summary>
        public const int Install = 2;
        /// <summary>
        /// 需要安裝和大型物品
        /// </summary>
        public const int Large_and_install = 3;

        /// <summary>
        /// 轉換名類型名稱
        /// </summary>
        /// <param name="type">類型</param>
        /// <returns>類型名稱</returns>
        public static string GetTypeName(int type) {
            switch (type) {
                case Common: return "Common Item";
                case Large: return "Large Item";
                case Install: return "Install Item";
                case Large_and_install: return "Large and Install Item";
                default: return "Not any type";
            }
        }
    }

    public class ItemTypeIllegalException : Exception {
        /// <summary>
        /// 非法物品類型
        /// </summary>
        public ItemTypeIllegalException() 
            : base("Item Type illega. Only accept '1','2','3'") {}
    }
    
    public class ItemPriceIllegalException : Exception {
        /// <summary>
        /// 非法物品價錢
        /// </summary>
        public ItemPriceIllegalException() 
            : base("Item Price illega. Only accept greater than or equal to 0") {}
    }

    public class ItemQtyIllegalException : Exception {
        /// <summary>
        /// 非法物品數量
        /// </summary>
        public ItemQtyIllegalException()
            : base("Item quantity illega. Only accept greater than or equal to 0") { }
    }

    public class ComboAddItemQtyIllegalException : Exception {
        /// <summary>
        /// 套裝接受, 非法物品數量
        /// </summary>
        public ComboAddItemQtyIllegalException()
            : base("Item quantity must be greater than 0") { }
    }
}
