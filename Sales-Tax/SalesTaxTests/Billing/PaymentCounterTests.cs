using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Billing.Tests
{
    [TestClass()]
    public class PaymentCounterTests
    {
        [TestMethod()]
        public void GetBillerTest()
        {
            String strategy = "Local";
            PaymentCounter payCnt = new PaymentCounter("USA");

            Assert.IsNotNull(payCnt.GetBiller(strategy));
        }
    }
}