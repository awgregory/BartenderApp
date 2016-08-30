using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<Drink> drinks = new List<Drink>{   
                new Drink { Name = "Rum and Coke", Description = "Rum mostly coke", Price = 6 },
                new Drink { Name = "Mojito", Description = "Mint and vodka", Price = 9 },
                new Drink { Name = "Moscow Mule", Description = "Ginger Beer and vodka", Price = 8 }
        }; // initialized like pg 74 , rendered pg 166 examples

            return View(drinks);
        }

        public ViewResult Order()
        {
            return View();
        }
    }
}

