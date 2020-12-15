using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Pizzas
{
    public class Margerita : IOrderable
    {
        public string GetName()
        {
            return "Margerita";
        }

        public int GetPrice()
        {
            return 85;
        }

        public static List<string> Toppings()
        {
            List<string> toppings = new List<string>() { "Tomatosauce", "Cheese" };
            return toppings;
        }
    }
}
