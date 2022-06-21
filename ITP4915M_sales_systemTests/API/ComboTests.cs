using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ITP4915M.API.Tests {
    [TestClass()]
    public class ComboTests {

        [TestMethod()]
        public void AddItemTest() {
            Item item = new Item("abc", 15, 0, "", "", 0);
            Item item2 = new Item("abc2", 15, 0, "", "", 0);
            Combo combo = new Combo("combo", 10);
            combo.AddItem(item);
            combo.AddItem(item2);
            Assert.AreEqual(combo.Size(), 2);
        }

        [TestMethod()]
        public void GetItemsTest() {
            Item item1 = new Item("abc", 15, 0, "", "", 0);
            Item item2 = new Item("abc2", 15, 0, "", "", 0);
            Combo combo = new Combo("combo", 10);
            combo.AddItem(item1);
            combo.AddItem(item2);
            Assert.AreEqual(combo.GetItemsList()[0], item1);
            Assert.AreEqual(combo.GetItemsList()[1], item2);
        }

        [TestMethod()]
        public void SizeTest() {
            Item item1 = new Item("abc", 15, 0, "", "", 0);
            Item item2 = new Item("abc2", 15, 0, "", "", 0);
            Combo combo = new Combo("combo", 10);
            combo.AddItem(item1);
            combo.AddItem(item2);
            Assert.AreEqual(combo.Size(), 2);
        }

        [TestMethod()]
        public void DiscountPriceTest() {
            Item item1 = new Item("abc", 15, 0, "", "", 0);
            Item item2 = new Item("abc2", 15, 0, "", "", 0);
            Combo combo = new Combo("combo", 10);
            combo.AddItem(item1);
            combo.AddItem(item2);
            Assert.AreEqual(combo.DiscountPrice(), 15*2-10);
        }
    }
}