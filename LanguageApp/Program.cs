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
            while (true)
            {
                Console.Write("Input: ");

                int.TryParse(Console.ReadLine(), out int result);

                
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Menu 1 selected");
                        break;
                    case 2:
                        Console.WriteLine("Menu 2 selected");
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }




            }

        }
    }
}
