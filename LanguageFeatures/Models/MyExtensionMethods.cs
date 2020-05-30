namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cart)
        {
            decimal totalPrice = 0;
            foreach (Product p in cart.Products)
            {
                totalPrice += p.Price;
            }

            return totalPrice;
        }
    }
}
