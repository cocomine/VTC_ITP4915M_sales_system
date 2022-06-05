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
        public string Id { get; }
        /// <summary>
        /// 物品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 物品簡述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// 物品供應商id
        /// </summary>
        public string SupplierID { get; set; }
        /// <summary>
        /// 物品價格, 只接受大於或等於 0
        /// </summary>
        /// <exception cref="ItemPriceIllegalException">物品價錢不符合要求</exception>
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
        /// <exception cref="ItemQtyIllegalException">物品數量不符合要求</exception>
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
        /// <exception cref="ItemTypeIllegalException">物品類型不符合要求</exception>
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
            Qty--;
        }

        /// <summary>
        /// 取得目前數量的總價錢
        /// </summary>
        /// <returns>總價錢</returns>
        public double GetTotalPrice() {
            return Price * Qty;
        }

        /// <summary>
        /// 將現有物件內的所有數據複製一份
        /// </summary>
        /// <returns>物品</returns>
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
        /// 套裝ID
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// 套裝價格
        /// </summary>
        /// <exception cref="ItemPriceIllegalException">套裝價格不符合要求</exception>
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
        /// <param name="id">套裝ID</param>
        /// <param name="name">套裝名稱</param>
        /// <param name="price">套裝價格, 只接受 0至3範圍內的數字</param>
        /// <param name="description">套裝簡述(可選)</param>
        public Combo(string id, string name, double price, string description = null) {
            this.Price = price;
            this.Name = name;
            this.Id = id;
            this.Description = description;
        }

        /// <summary>
        /// 創建新套裝
        /// </summary>
        /// <param name="name">套裝名稱</param>
        /// <param name="price">套裝價格, 只接受 0至3範圍內的數字</param>
        /// <param name="description">套裝簡述(可選)</param>
        public Combo(string name, double price, string description = null) {
            this.Price = price;
            this.Name = name;
            this.Id = null;
            this.Description = description;
        }

        /// <summary>
        /// 加入物品
        /// </summary>
        /// <param name="item">物品</param>
        public void AddItem(Item item) {
            _items.Add(item);
        }

        /// <summary>
        /// 取得所有物品<br></br>
        /// 請小心使用, 列表obj不會複製一份
        /// </summary>
        /// <returns>物品列表</returns>
        public List<Item> GetItemsList() {
            return _items;
        }

        /// <summary>
        /// 取得物品總共數量
        /// </summary>
        /// <returns>物品總共數量</returns>
        public int Size() {
            int total = 0;
            foreach (Item item in _items) {
                total += item.Qty;
            }
            return total;
        }

        /// <summary>
        /// 刪除全部物品
        /// </summary>
        /// <param name="item">物品</param>
        public void Clear() {
            _items.Clear();
        }

        /// <summary>
        /// 查看原價與套裝價格的折扣價錢 * 套裝份量
        /// </summary>
        /// <returns>折扣價錢</returns>
        public double DiscountPrice() {
            return GetTotalPrice() - GetFinalPrice();
        }

        /// <summary>
        /// 取得未折扣價錢
        /// </summary>
        /// <returns>價錢</returns>
        public double GetTotalPrice() {
            double total = 0.0;
            foreach (Item item in _items) {
                total += item.Price;
            }
            return total * GetQty(); ;
        }

        /// <summary>
        /// 取得折扣後的實質價錢<br></br>
        /// </summary>
        /// <returns>價錢</returns>
        public double GetFinalPrice() {
            return Price * GetQty();
        }

        /// <summary>
        /// 套裝份量
        /// 取當中物品數量最小的進行套裝數量計算
        /// </summary>
        /// <example>
        /// 如果: 
        ///     Item1.Qty = 1;
        ///     Item2.Qty = 1;
        ///     套裝會當作1份計算
        /// 如果:
        ///     Item1.Qty = 1;
        ///     Item2.Qty = 2;
        ///     套裝亦是當作1份計算
        /// 如果:
        ///     Item1.Qty = 2;
        ///     Item2.Qty = 2;
        ///     套裝就會當作2份計算
        /// </example>
        /// <returns>份量</returns>
        public int GetQty() {
            int comboQty = _items.FirstOrDefault().Qty;
            foreach (Item item in _items) {
                if (comboQty > item.Qty) comboQty = item.Qty; //攞最少數量
            }
            return comboQty;
        }

        override public string ToString() {
            String items = "\n";
            foreach (Item item in _items) {
                items += "    " + item.ToString() + "\n";
            }
            items += "\n";
            return String.Format("Combo:{0}(Name: {1}, Description, {2}, Price: {3}, Discount Price: -{4}, TotalPrice: {5}, FinalPrice: {6}, Items: [{7}])", Id, Name, Description, Price, DiscountPrice(), GetTotalPrice(), GetFinalPrice(), items);
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
            : base("Item Type illega. Only accept '1','2','3'") { }
    }

    public class ItemPriceIllegalException : Exception {
        /// <summary>
        /// 非法物品價錢
        /// </summary>
        public ItemPriceIllegalException()
            : base("Item Price illega. Only accept greater than or equal to 0") { }
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
