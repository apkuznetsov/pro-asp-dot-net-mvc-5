using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal totalPrice = 0;
            foreach (Product p in products)
            {
                totalPrice += p.Price;
            }

            return totalPrice;
        }
    }
}
