using Pizzeria.Models;
using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Drinks
{
    public class CocaCola : Pizzas.IOrderable
    {
        public string GetName()
        {
            return "Coca Cola";
        }

        public int GetPrice()
        {
            return 20;
        }
    }
}
