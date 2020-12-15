using Pizzeria.Models.Drinks;
using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzaFactory
    {
        public static IOrderable CreatePizza(string type)
        {
            IOrderable chosenPizza;
            switch (type)
            {
                case "1":
                    chosenPizza = new Margerita();
                    return chosenPizza;
                case "2":
                    chosenPizza = new Hawaii();
                    return chosenPizza;
                case "3":
                    chosenPizza = new KebabPizza();
                    return chosenPizza;
                case "4":
                    chosenPizza = new QuatroStagioni();
                    return chosenPizza;
                default:
                    throw new NotSupportedException();
            } 
        }
    }
}
