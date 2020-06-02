using System;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            if (totalPrice < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (totalPrice > 100)
            {
                return totalPrice * 0.9M;
            }
            else if (totalPrice >= 10 && totalPrice <= 100)
            {
                return totalPrice - 5;
            }
            else
            {
                return totalPrice;
            }
        }
    }
}