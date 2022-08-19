using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Shopping.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void GetCartSizeTest()
        {
            ShoppingCart shpCart = new ShoppingCart();
            string name = "book";
            double price = 12.49;
            bool imported = true;
            int quantity = 1;

            Products.BookProduct bkPrd = new Products.BookProduct(name, price, imported, quantity);

            shpCart.AddItemToCart(bkPrd);
            Assert.AreEqual(1, shpCart.GetCartSize());
        }
    }
}