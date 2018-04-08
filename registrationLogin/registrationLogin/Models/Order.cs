using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace registrationLogin.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Coffee")]
        public string coffee { get; set; }
        public string espresso { get; set; }
        public string chocoloate { get; set; }
        public string frappucino { get; set; }
        public string shakes { get; set; }
        public string tea { get; set; }
        public string bottlesAndCans { get; set; }
        public string breakfast { get; set; }
        public string lunch { get; set; }
        public string bakery { get; set; }
        public string snacksAndSweets { get; set; }
        public string beans { get; set; }
        public string capsules { get; set; }
        public IEnumerable<SelectListItem> Coffees { get; set; }
    }

    public class OrderDBCOntext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}



    /*public enum Coffee
    {
        Americano, 
        [Display(Name ="Arabian Nights")]
        arabianNights,
        [Display(Name ="Guatamalan Surprise")]
        guatemalanSurprise,
        [Display(Name = "Brazilian Beanz")]
        brazilianBeanz, 
        [Display(Name = "Mexican Secret")]
        mexicanSecret
    }
}
*/
