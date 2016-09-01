﻿using System.Collections.Generic;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        private static int _id = 0;

        private static List<Drink> _orders = new List<Drink>();

        private static List<Drink> _drinks
            = new List<Drink>()
            {
                new Drink {Name = "LA Freeway", Description = "Do not drink", Price = 1},
                new Drink {Name = "Rum and Coke", Description = "Rum mostly coke", Price = 6},
                new Drink {Name = "Mojito", Description = "Mint and vodka", Price = 9},
                new Drink {Name = "Moscow Mule", Description = "Ginger Beer and vodka", Price = 8}
            };

        public ActionResult Index()
        {
            return View(_drinks);
        }


        public ActionResult Order(Drink drink) // MVC takes the values passed to it and makes a new drink object
        {
            drink.Id = ++_id;
            _orders.Add(drink);
            return View(_orders);         
        }

        public ViewResult ViewOrders()
        {
            
            return View("Order", _orders);
        }


    }
}

