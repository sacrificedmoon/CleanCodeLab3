using Pizzeria.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class PizzaDecorator : IOrderable
    {
        private IOrderable _pizza;

        public PizzaDecorator(IOrderable pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetName()
        {
            return _pizza.GetName();
        }

        public virtual int GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
