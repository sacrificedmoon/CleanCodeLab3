using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria;
using Pizzeria.Models;
using Pizzeria.Models.Drinks;
using Pizzeria.Models.Pizzas;
using Pizzeria.Models.Toppings;
using System;
using System.IO;

namespace PizzeriaTest
{
    [TestClass]
    public class PizzeriaTest
    {
        public MainMenu mainMenu = MainMenu.Instance;

        [TestMethod]
        public void CreateSodaTest()
        {
            var expected = "Coca Cola";
            var soda = DrinkFactory.CreateSoda("1");
            var actual = soda.GetName();
            Assert.AreEqual(expected, actual);

            expected = "Fanta";
            soda = DrinkFactory.CreateSoda("2");
            actual = soda.GetName();
            Assert.AreEqual(expected, actual);

            expected = "Sprite";
            soda = DrinkFactory.CreateSoda("3");
            actual = soda.GetName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatePizzaTest()
        {
            var expected = "Margerita";
            var pizza = PizzaFactory.CreatePizza("1");
            var actual = pizza.GetName();
            Assert.AreEqual(expected, actual);

            expected = "Hawaii";
            pizza = PizzaFactory.CreatePizza("2");
            actual = pizza.GetName();
            Assert.AreEqual(expected, actual);

            expected = "KebabPizza";
            pizza = PizzaFactory.CreatePizza("3");
            actual = pizza.GetName();
            Assert.AreEqual(expected, actual);

            expected = "Quatro Stagioni";
            pizza = PizzaFactory.CreatePizza("4");
            actual = pizza.GetName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCostTest()
        {
            Order currentOrder = new Order();
            currentOrder.ItemsOrdered.Add(new Margerita());
            currentOrder.ItemsOrdered.Add(new Hawaii());
            currentOrder.ItemsOrdered.Add(new Sprite());
            var result = mainMenu.CalculateOrderCost(currentOrder);
            var expected = 205;
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void DecoratorTest()
        {
            IOrderable pizza = new Margerita();
            IOrderable ham = new Ham(pizza);
            IOrderable kebab = new Kebab(ham);
            IOrderable onion = new Onion(kebab);
            var expectedPizza = $"Margerita{Environment.NewLine} with ham{Environment.NewLine} with kebab{Environment.NewLine} with onion";
            var expectedPrice = 125;
            var actualPizza = onion.GetName();
            var actualPrice = onion.GetPrice();
            Assert.AreEqual(expectedPizza, actualPizza);
            Assert.IsTrue(expectedPrice == actualPrice);
        }
    }
}
