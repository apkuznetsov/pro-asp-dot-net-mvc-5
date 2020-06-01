using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator
    {
        public decimal CalcProductsPrice(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}