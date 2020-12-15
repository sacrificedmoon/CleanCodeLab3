using Pizzeria.Models.Drinks;
using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class DrinkFactory
    {
        public static IOrderable CreateSoda(string type)
        {
            IOrderable soda;
            switch (type)
            {
                case "1":
                    soda = new CocaCola();
                    return soda;
                case "2":
                    soda = new Fanta();
                    return soda;
                case "3":
                    soda = new Sprite();
                    return soda;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
