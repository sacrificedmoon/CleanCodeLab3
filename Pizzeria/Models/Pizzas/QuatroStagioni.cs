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
    }
}
