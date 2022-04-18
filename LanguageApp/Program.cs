using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Language learning app!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Command Menu: 1-Word Path, 2-Begin Learning, 0-Exit");

            string? filePath = "";


            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.Write("Input: ");
                int.TryParse(Console.ReadLine(), out int menuNumber);


                switch (menuNumber)
                {
                    case 1:
                        Console.WriteLine("Type Word Path");
                        filePath = Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("Menu 2 selected");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }




            }

        }
    }
}
