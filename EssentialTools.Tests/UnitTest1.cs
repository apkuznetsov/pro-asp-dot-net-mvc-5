using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper GetTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            IDiscountHelper target = GetTestObject();
            decimal total = 200;

            var discountedTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            IDiscountHelper target = GetTestObject();

            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            Assert.AreEqual(5, TenDollarDiscount, "$10 dicount is wrong");
            Assert.AreEqual(5, HundredDollarDiscount, "$100 dicount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 dicount is wrong");
        }

        [TestMethod]
        public void Discount_Less_Than_10()
        {
            IDiscountHelper target = GetTestObject();

            decimal discount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);

            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_TotalPrice()
        {
            IDiscountHelper target = GetTestObject();

            target.ApplyDiscount(-1);
        }
    }
}
