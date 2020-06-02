using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
