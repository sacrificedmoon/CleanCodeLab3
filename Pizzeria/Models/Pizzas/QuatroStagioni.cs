using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Pizzas
{
    public class QuatroStagioni : IOrderable
    {
        public string GetName()
        {
            return "Quatro Stagioni";
        }

        public int GetPrice()
        {
            return 115;
        }

        public static List<string> Toppings()
        {
            List<string> toppings = new List<string>() { "Tomatosauce", "Cheese", "Ham", "Prawns", "Mussels", "Mushrooms", "Artichoke" };
            return toppings;
        }
    }
}
