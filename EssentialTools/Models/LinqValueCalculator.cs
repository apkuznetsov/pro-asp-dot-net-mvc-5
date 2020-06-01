using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discount)
        {
            this.discounter = discount;

            System.Diagnostics.Debug.WriteLine(
                string.Format("Instance {0} create", counter));
        }

        public decimal CalcProductsPrice(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}