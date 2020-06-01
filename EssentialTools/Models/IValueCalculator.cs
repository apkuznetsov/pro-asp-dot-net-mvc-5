using System.Collections.Generic;

namespace EssentialTools.Models
{
    public interface IValueCalculator
    {
        decimal CalcProductsPrice(IEnumerable<Product> products);
    }
}
