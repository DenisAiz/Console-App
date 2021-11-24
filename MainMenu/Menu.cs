using System;
using System.Linq;
using Task3.AddAndRemoveActions;
using Task3.Space;

namespace Task3
{
    class Menu
    {
        public void  StartMenu()
        {
            var instruction = new MenuOrder();

            Console.WriteLine("\t\n---  Menu  --- \n");

            Console.WriteLine("1 - Show star; 2 - Show planet; 3 - Show asteroid; 4 - Show black hole\n");           

            Console.WriteLine("5 - Add a star; 6 - Add a planet; 7 - Add a asteroid; 8 - Add a black hole; 9 - Deleted object\n");

            string userChoise = Console.ReadLine();

            instruction.Realize(userChoise);
        }        
    }
}
