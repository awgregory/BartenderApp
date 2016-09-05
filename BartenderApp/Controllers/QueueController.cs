using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;
using BartenderApp.Controllers;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {
        private static List<Drink> ready = new List<Drink>();

        public ActionResult ViewOrdersTable () // View for this method made using List as template

        {
            return View(HomeController.Orders);
        }

       public RedirectToRouteResult Prepared(Drink drink)
        {
            ready.Add(drink);
            
            // Instead of the RemoveAll, Nick recommended this way
            var drinkToRemove = HomeController.Orders.Where(x => x.Id == drink.Id); // x represents an object in Orders
            // var uses type inference from Orders
            HomeController.Orders.Remove(drinkToRemove.FirstOrDefault());


            return RedirectToAction("ViewOrdersTable");  
        }



        public ActionResult ViewPreparedTable() 

        {
            return View(ready);
        }


        public RedirectToRouteResult Served(Drink drink)
        {
            ready.RemoveAll(x => x.Id == drink.Id);
            return RedirectToAction("ViewPreparedTable");
        }

    }
}