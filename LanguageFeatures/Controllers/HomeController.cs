using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccet ball", Price = 19.5M},
                    new Product {Name = "Corner flag", Price = 34.95M},
                }
            };

            Product[] productsArr =

                {
                    new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccet ball", Price = 19.5M},
                    new Product {Name = "Corner flag", Price = 34.95M},
                };

            decimal cartTotalPrice = cart.TotalPrices();
            decimal productsArrTotalPrice = productsArr.TotalPrices();

            return View("Result",
                (object)String.Format("Cart Total: {0}\nArray Total: {1}",
                cartTotalPrice, productsArrTotalPrice));
        }
    }
}