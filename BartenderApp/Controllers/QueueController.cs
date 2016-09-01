using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {
        private static List<Drink> _ready = new List<Drink>();

        

       public ActionResult Prepared(Drink drink)
        {
            _ready.Add(drink);
            return View(_ready);
        }

        public ViewResult ViewReady()
        {

            return View("Prepared", _ready);
        }
    }
}