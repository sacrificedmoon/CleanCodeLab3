using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Pizzas
{
    public interface IOrderable
    {
        string GetName();
        int GetPrice();
    }
}
