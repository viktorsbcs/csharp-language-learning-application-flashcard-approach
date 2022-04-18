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
                Console.WriteLine("\n");
                Console.Write("Input: ");
                int.TryParse(Console.ReadLine(), out int menuNumber);


                switch (menuNumber)
                {
                    case 1:
                        Console.Write("Type Word Path: ");
                        filePath = Console.ReadLine();
                        //Read foreign word and translation from file and process further
                        break;
                    case 2:
                        Console.WriteLine("");
                        //Randomize foreign words that were read from file and display to user
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
