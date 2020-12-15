using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Toppings
{
    public class Onion : PizzaDecorator
    {
        public Onion(IOrderable pizza) : base(pizza) { }

        public override string GetName()
        {
            string type = base.GetName();
            type += "\r\n with onion";
            return type;
        }

        public override int GetPrice()
        {
            int price = base.GetPrice();
            price += 10;
            return price;
        }
    }
}
