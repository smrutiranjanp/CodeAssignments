using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTax.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.TaxCalculations.Tests
{
    [TestClass()]
    public class LocalTaxCalculatorTests
    {
        [TestMethod()]
        public void CalculateTaxTest()
        {
            double price = 12.49;
            double localTax = 10;
            bool imported = true;

            LocalTaxCalculator ltc = new LocalTaxCalculator();
            Assert.IsTrue(ltc.CalculateTax(price, localTax, imported) > 0);
        }
    }
}