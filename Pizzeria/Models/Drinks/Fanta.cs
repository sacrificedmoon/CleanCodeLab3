using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Drinks
{
    public class Fanta : Pizzas.IOrderable
    {
        public string GetName()
        {
            return "Fanta";
        }

        public int GetPrice()
        {
            return 20;
        }
    }
}
