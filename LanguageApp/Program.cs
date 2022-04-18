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
            Console.WriteLine("Welcome to German Language learning app!");
            Console.WriteLine("---------------------------------");

            string? filePath = "";


            while (true)
            {
                Console.WriteLine("Main Menu: 1-Begin Learning, 2-Word Path, 3-Swap Languages,  0-Exit");
                Console.WriteLine("\n");
                Console.Write("Input: ");
                int.TryParse(Console.ReadLine(), out int menuNumber);


                switch (menuNumber)
                {
                    case 1:
                        Console.WriteLine("German : English");
                        Console.WriteLine("Command Menu: 1-Generate Word, 0-Exit");
                        //Randomize foreign words that were read from file and display to user
                        while (true)
                        {
                            bool leaveLoop = false;
                            string? readInputSubMenu = Console.ReadLine();
                            int subMenuNumber;

                            if (string.IsNullOrEmpty(readInputSubMenu))
                            {
                                subMenuNumber = 1;
                            }
                            else
                            {
                                int.TryParse(readInputSubMenu, out subMenuNumber);
                            }

                            switch (subMenuNumber)
                            {
                                case 1:
                                    Console.WriteLine("German word generated...\n");
                                    break;
                                case 0:
                                    leaveLoop = true;
                                    break;
                                default:
                                    Console.WriteLine("Wrong command");
                                    break;

                            }

                            if (leaveLoop)
                            {
                                Console.WriteLine("Returned to main menu");
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Type Word Path: ");
                        filePath = Console.ReadLine();
                        //Read foreign word and translation from file and process further
                        break;
                    case 3:
                        Console.WriteLine("Swap languages English : German");
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
