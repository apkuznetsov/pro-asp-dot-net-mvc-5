namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalPrice);
    }

    public class DefaultDiscounterHelper : IDiscountHelper
    {
        private decimal discountSize;

        public DefaultDiscounterHelper(decimal discountSize)
        {
            this.discountSize = discountSize;
        }

        public decimal ApplyDiscount(decimal totalPrice)
        {
            return (totalPrice - (discountSize / 100m * totalPrice));
        }
    }
}