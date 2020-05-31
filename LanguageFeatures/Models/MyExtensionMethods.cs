using System;
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

        public static IEnumerable<Product> FilterByCategory(
            this IEnumerable<Product> products, string category)
        {
            foreach (Product p in products)
            {
                if (p.Category == category)
                {
                    yield return p;
                }
            }
        }

        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> products,
            Func<Product, bool> selector)
        {
            foreach (Product p in products)
            {
                if (selector(p))
                {
                    yield return p;
                }
            }
        }
    }
}
