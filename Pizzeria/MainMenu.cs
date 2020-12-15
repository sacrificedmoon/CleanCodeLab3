using Pizzeria.Models;
using Pizzeria.Models.Pizzas;
using Pizzeria.Models.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    public class MainMenu
    {
        public static bool MainMenuIsRunning = true;
        public static Order currentOrder;
        public static List<Order> Orders = new List<Order>();

        private static MainMenu instance = new MainMenu();
        private MainMenu() { }
        public static MainMenu Instance
        {
            get { return instance; }
        }

        public void RunMenu()
        {
            while (MainMenuIsRunning)
            {
                
                Console.WriteLine("Choose an option: \n" +
                    "1.Place an order \n" +
                    "2.View orders \n" +
                    "3.Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        currentOrder = new Order();
                        PlaceOrder();
                        break;
                    case "2":
                        ViewOrders();
                        break;
                    case "3":
                        MainMenuIsRunning = false;
                        break;
                }
            }
        }

        public void PlaceOrder()
        {
            MainMenuIsRunning = false;
            Console.Clear();
            if(currentOrder.ItemsOrdered.Count() > 0)
            {
                WriteOrderToConsole();
            }
            Console.WriteLine("What would you like to order?\n" +
                "1.Pizza\n" +
                "2.Soda\n" +
                "Press X to go cancel order and go back\n" +
                "Press Y to place order");
            switch (Console.ReadLine())
            {
                case "1":
                    OrderPizza();
                    return;
                case "2":
                    OrderSoda();
                    return;
                case "x":
                    currentOrder.CanceledOrder = true;
                    currentOrder.Cost = CalculateCost(currentOrder);
                    Orders.Add(currentOrder);
                    MainMenuIsRunning = true;
                    RunMenu();
                    return;
                case "y":
                    currentOrder.PlacedOrder = true;
                    currentOrder.Cost = CalculateCost(currentOrder);
                    Orders.Add(currentOrder);
                    MainMenuIsRunning = true;
                    RunMenu();
                    return;
                default:
                    Console.WriteLine("Please write the number of the item you'd like to order");
                    PlaceOrder();
                    return;
            }
        }

        public void OrderPizza()
        {
            Console.WriteLine("Which pizza do you want? You can add extra toppings after you've chosen one.\n" +
                $"1. Margerita - Tomatosauce, cheese - 85 sek\n" +
                $"2. Hawaii - Tomatosauce, cheese, ham, pineapple - 95sek\n" +
                $"3. Kebabpizza - Tomatosauce, cheese, kebab, mushrooms, onion, feferoni, lettuce, tomato, kebabsauce - 105sek \n" +
                $"4. Quatro Stagioni - Tomatosauce, cheese, ham, shrimp, mussels, mushrooms, artichoke - 115sek ");
            var item = PizzaFactory.CreatePizza(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You chose a {item.GetName()}");
            AddToppingsMenu(item);
        }

        public void OrderSoda()
        {
            Console.Clear();
            Console.WriteLine("What drink do you want?\n" +
                "1.Coca Cola - 20sek\n" +
                "2.Fanta - 20sek\n" +
                "3.Sprite - 25sek");
            var drink = DrinkFactory.CreateSoda(Console.ReadLine());
            Console.WriteLine($"You chose a {drink.GetName()}");
            currentOrder.ItemsOrdered.Add(drink);
            PlaceOrder();
        }

        public void AddToppingsMenu(IOrderable pizza)
        {
            Console.Clear();
            Console.WriteLine($"You have a {pizza.GetName()} \n" +
                "\nWhat toppings do you want?\n" +
                "1.Artichoke - 15 sek\n" +
                "2.Cilantro - 20 sek\n" +
                "3.Ham - 10 sek\n" +
                "4.Kebab - 20 sek\n" +
                "5.Kebabsauce - 10 sek\n" +
                "6.Mushrooms - 10 sek\n" +
                "7.Mussels - 15 sek\n" +
                "8. Onions - 10 sek\n" +
                "9.Pineapple - 10 sek\n" +
                "10.Shrimp - 15 sek\n" +
                "Press Y if you are happy with your pizza");
            AddToppings(pizza, Console.ReadLine());
        }

        public void AddToppings(IOrderable pizza, string type)
        {
            switch (type)
            {
                case "1":
                    IOrderable artichoke = new Artichoke(pizza);
                    AddToppingsMenu(artichoke);
                    return;
                case "2":
                    IOrderable cilantro = new Cilantro(pizza);
                    AddToppingsMenu(cilantro);
                    return;
                case "3":
                    IOrderable ham = new Ham(pizza);
                    AddToppingsMenu(ham);
                    return;
                case "4":
                    IOrderable kebab = new Kebab(pizza);
                    AddToppingsMenu(kebab);
                    return;
                case "5":
                    IOrderable kebabsauce = new Kebabsauce(pizza);
                    AddToppingsMenu(kebabsauce);
                        return;
                case "6":
                    IOrderable mushroom = new Mushroom(pizza);
                    AddToppingsMenu(mushroom);
                    return;
                case "7":
                    IOrderable mussels = new Mussels(pizza);
                    AddToppingsMenu(mussels);
                    return;
                case "8":
                    IOrderable onion = new Onion(pizza);
                    AddToppingsMenu(onion);
                    return;
                case "9":
                    IOrderable pineapple = new Pinapple(pizza);
                    AddToppingsMenu(pineapple);
                    return;
                case "10":
                    IOrderable shrimp = new Shrimp(pizza);
                    AddToppingsMenu(shrimp);
                    return;
                case "y":
                    currentOrder.ItemsOrdered.Add(pizza);
                    PlaceOrder();
                    return;
                default:
                    Console.WriteLine("Please write the number of the topping you want.");
                    AddToppingsMenu(pizza);
                    return;
            }
        }

        public void WriteOrderToConsole()
        {
            int totalCost = CalculateCost(currentOrder);
            Console.WriteLine($"Your order costs: {totalCost}");
            Console.WriteLine("Your order is: ");
            foreach (var item in currentOrder.ItemsOrdered)
            {
                Console.WriteLine($"{item.GetName()}\n");
            }
        }

        public int CalculateCost(Order currentOrder)
        {
            int totalCost = 0;
            foreach (var item in currentOrder.ItemsOrdered)
            {
                totalCost += item.GetPrice();
            }
            return totalCost;
        }

        public void ViewOrders()
        {
            Console.Clear();
            foreach (var placedOrder in Orders)
            {
                Console.WriteLine($"Order canceled: {placedOrder.CanceledOrder}");
                Console.WriteLine($"Order was placed: {placedOrder.PlacedOrder}");
                Console.WriteLine("Order contains:");
                foreach (var item in placedOrder.ItemsOrdered)
                {
                    Console.WriteLine(item.GetName());
                }
                Console.WriteLine($"Order costs: {placedOrder.Cost} sek");
                Console.WriteLine("\n");
            }

            Console.ReadKey();
            MainMenuIsRunning = true;
        }
    }
}
