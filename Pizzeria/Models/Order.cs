using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class Order
    {
        public bool CanceledOrder { get; set; }
        public bool PlacedOrder { get; set; }
        public int Cost { get; set; }

        public List<IOrderable> ItemsOrdered = new List<IOrderable>();
        public Order()
        {
            
        }
    }
}
