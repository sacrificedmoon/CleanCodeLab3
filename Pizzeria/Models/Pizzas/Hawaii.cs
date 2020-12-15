using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Pizzas
{
    public class Hawaii : IOrderable
    {
        public string GetName()
        {
            return "Hawaii";
        }
        public int GetPrice()
        {
            return 95;
        }

        public static List<string> Toppings()
        {
            List<string> toppings = new List<string>() { "Tomatosauce", "Cheese", "Ham", "Pinapple" };
            return toppings;
        }
        
    }
}
