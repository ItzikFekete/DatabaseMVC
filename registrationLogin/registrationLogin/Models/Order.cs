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
        public string Coffee { get; set; }
        public string Espresso { get; set; }
        public string Chocoloate { get; set; }
        public string Frappucino { get; set; }
        public string Shakes { get; set; }
        public string Tea { get; set; }
        public string BottlesAndCans { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Bakery { get; set; }
        public string SnacksAndSweets { get; set; }
        public string Beans { get; set; }
        public string Capsules { get; set; }
        public IEnumerable<SelectListItem> Coffees { get; set; }
    }
  
   

    public class OrderDBCOntext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}



    public enum Coffees
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
public struct Convertenum
{
    public int Value { get; set; }
    public string Text { get; set; }
}
