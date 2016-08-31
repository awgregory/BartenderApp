using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}

