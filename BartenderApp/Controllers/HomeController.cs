using System.Collections.Generic;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {

        private static int id = 0;  // Should I be using a Property for this field?

        public static List<Drink> Orders = new List<Drink>();  // Ditto above on this
        // This will be persisted in Database

        private static List<Drink> drinks
            = new List<Drink>()
            {
                new Drink {Name = "LA Freeway", Description = "Do not drink", Price = 1},
                new Drink {Name = "Rum and Coke", Description = "Rum mostly coke", Price = 6},
                new Drink {Name = "Mojito", Description = "Mint and vodka", Price = 9},
                new Drink {Name = "Moscow Mule", Description = "Ginger Beer and vodka", Price = 8}
            };

        public ActionResult Index()
        {
            return View(drinks);
        }  


        public RedirectToRouteResult Order(Drink drink) // MVC takes the values passed to it and makes a new drink object here
        {
            drink.Id = ++id;
            Orders.Add(drink);
            return RedirectToAction("Index");
        }



    }
}

