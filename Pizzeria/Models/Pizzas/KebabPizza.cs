using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Pizzas
{
    public class KebabPizza : IOrderable
    {
        public string GetName()
        {
            return "KebabPizza";
        }

        public int GetPrice()
        {
            return 105;
        }
    }
}
