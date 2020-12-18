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
    }
}
