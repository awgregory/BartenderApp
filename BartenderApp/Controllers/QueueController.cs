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

        

       public RedirectToRouteResult Prepared(Drink drink)
        {
            ready.Add(drink);
            HomeController.Orders.RemoveAll(x => x.Id == drink.Id);
            return RedirectToAction("ViewOrders");
        }

        public ViewResult ViewOrders()
        {
            return View("Ordered", HomeController.Orders);
        }

        public ViewResult ViewReady()
        {
            return View("Prepared", ready);
        }

        public RedirectToRouteResult Served(Drink drink)
        {
            ready.RemoveAll(x => x.Id == drink.Id);
            return RedirectToAction("ViewReady");
        }

    }
}