using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calculator;

        public ShoppingCart(IValueCalculator calculator)
        {
            this.calculator = calculator;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalcTotalProductsPrice()
        {
            return calculator.CalcProductsPrice(Products);
        }
    }
}