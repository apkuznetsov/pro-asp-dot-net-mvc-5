using EssentialTools.Models;
using System.Web.Mvc;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calculator;

        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.5M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M},
        };

        public HomeController(IValueCalculator calculator1, IValueCalculator calculator2)
        {
            this.calculator = calculator1;
        }

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calculator) { Products = products };
            decimal totalPrice = cart.CalcTotalProductsPrice();

            return View(totalPrice);
        }
    }
}