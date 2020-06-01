namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalPrice);
    }

    public class DefaultDiscounterHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            return (totalPrice - (10m / 100m * totalPrice));
        }
    }
}