using System.Collections.Generic;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<Drink> Orders = new List<Drink>();

        private static List<Drink> Drinks
            = new List<Drink>()
            {
                new Drink {Id = 1, Name = "Rum and Coke", Description = "Rum mostly coke", Price = 6},
                new Drink {Id = 2, Name = "Mojito", Description = "Mint and vodka", Price = 9},
                new Drink {Id = 3, Name = "Moscow Mule", Description = "Ginger Beer and vodka", Price = 8}
            };

        public ActionResult Index()
        {
            return View(Drinks);
        }


        public ActionResult Order(Drink drink)
        {
            
            Orders.Add(drink);

            return View(Orders);
            
        }
        
        
    }
}
// In chrome dev tools for the actionlink I think 1 is an ID assigned by browser
// for each link it enumerates?   the Home/Order/1 
