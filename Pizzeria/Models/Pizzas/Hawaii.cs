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
    }
}
