using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = MainMenu.Instance;
            mainMenu.RunMenu();
        }
    }
}
