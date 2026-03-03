using StockBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockBuddy.Services;

namespace StockBuddyTest
{
    [TestClass]
    public class CartServiceTests
    {
        [TestMethod]
        public void AddItem_AddsToCart_AndUpdatesTotal()
        {
            var service = new CartService();

            service.AddItem(new Item { itemName = "Candy", itemNum = 1, itemPrice = 2.50m });
            service.AddItem(new Item { itemName = "Soda", itemNum = 2, itemPrice = 1.25m });

            Assert.AreEqual(2, service.Cart.Count);
            Assert.AreEqual(3.75m, service.Total());
        }

        [TestMethod]
        public void RemoveLast_WhenCartEmpty_ReturnsFalse()
        {
            var service = new CartService();

            var removed = service.RemoveLast();

            Assert.IsFalse(removed);
            Assert.AreEqual(0, service.Cart.Count);
        }

        [TestMethod]
        public void RemoveLast_WhenCartHasItems_RemovesOne()
        {
            var service = new CartService();
            service.AddItem(new Item { itemName = "Candy", itemNum = 1, itemPrice = 2.50m });

            var removed = service.RemoveLast();

            Assert.IsTrue(removed);
            Assert.AreEqual(0, service.Cart.Count);
            Assert.AreEqual(0m, service.Total());
        }

        [TestMethod]
        public void TotalWithTax_ComputesCorrectly()
        {
            var service = new CartService();
            service.AddItem(new Item { itemName = "Candy", itemNum = 1, itemPrice = 10.00m });

            var total = service.TotalWithTax(0.10m); // 10%

            Assert.AreEqual(11.00m, total);
        }
    }
}
