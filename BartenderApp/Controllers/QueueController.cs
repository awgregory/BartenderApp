using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Controllers;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {
        // GET: Queue
        public ActionResult Order()
        {
            return View();
        }


        
    }
}