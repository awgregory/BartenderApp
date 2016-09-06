using System.Collections.Generic;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    // HomeController is the default controller and holds default method to display the mock Drink Ojects contained in the 
    // drinks list when a user makes a Get Request to the base URL.  
    // It also has a method to add a drink object to the "Orders" List.  
    public class HomeController : Controller
    {

        // This is used to create and add an Id to the drinks when they are added to Orders List
        private static int id = 0;
        

        // This list is used to hold the drinks that have been ordered
        public static List<Drink> Orders = new List<Drink>();
        // This will later be persisted in Database


        // This list with mock data holds the list of drinks offered on the menu
        private static List<Drink> drinks
            = new List<Drink>()
            {
                new Drink {Name = "LA Freeway", Description = "Do not drink", Price = 1},
                new Drink {Name = "Rum and Coke", Description = "Rum mostly coke", Price = 6},
                new Drink {Name = "Mojito", Description = "Mint and vodka", Price = 9},
                new Drink {Name = "Moscow Mule", Description = "Ginger Beer and vodka", Price = 8}
            };


        // This method displays the list of drinks on the menu
        public ActionResult Index()
        {
            return View(drinks);
        }  


        // This method is invoked when a drink on the menu is ordered, adding it to the Orders List, then redisplaying menu
        public RedirectToRouteResult Order(Drink drink) // MVC takes values passed in here and makes new drink object
        {
            drink.Id = ++id;
            Orders.Add(drink);
            return RedirectToAction("Index");
        }
        
    }
}

