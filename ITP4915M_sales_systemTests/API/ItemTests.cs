using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITP4915M.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP4915M.API.Tests {
    [TestClass()]
    public class ItemTests {

        [TestMethod()]
        public void AddQtyTest() {
            Item item = new Item("abc", 15, 0, "", "", 0);
            item.AddQty();
            Assert.AreEqual(item.Qty, 1);
        }

        [TestMethod()]
        public void ReduceQtyTest() {
            Item item = new Item("abc", 15, 0, "", "", 1);
            item.ReduceQty();
            Assert.AreEqual(item.Qty, 0);
        }

        [TestMethod()]
        public void GetTotalPriceTest() {
            Item item = new Item("abc", 15, 0, "", "", 2);
            Assert.AreEqual(item.GetTotalPrice(), 15 * 2);
        }
    }
}