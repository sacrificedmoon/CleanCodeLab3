using System;

namespace Pizzeria
{
    public class Pizzeria
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = MainMenu.Instance;
            mainMenu.RunMainMenu();
        }
    }
}
