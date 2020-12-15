using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Drinks
{
    public class Sprite : Pizzas.IOrderable
    {
        public string GetName()
        {
            return "Sprite";
        }

        public int GetPrice()
        {
            return 25;
        }
    }
}
