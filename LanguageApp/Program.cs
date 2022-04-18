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
            int swapChoice = 0;


            while (true)
            {
                Console.WriteLine("\nMain Menu: 1-Begin Learning, 2-Word Path, 3-Swap Translation,  0-Exit");
                Console.Write("Input: ");

                int.TryParse(Console.ReadLine(), out int menuNumber);

                Console.WriteLine("\n");

                switch (menuNumber)
                {
                    case 1: //Randomize words to begin learning
                        Console.WriteLine("German : English");
                        Console.WriteLine("Command Menu: 1-Generate Word, 0-Exit");

                        while (true)
                        {
                            bool leaveLoop = false;

                            Console.Write("Input: ");
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
                        //filePath = Console.ReadLine();
                        //Read foreign word and translation from file and process further
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        if (swapChoice == 0)
                        {
                            Console.WriteLine("Current translation => English : German\n");
                            swapChoice = 1;
                        }
                        else
                        {
                            Console.WriteLine("Current translation => German : English\n");
                            swapChoice = 0;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting Language learning application");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong command\n");
                        break;
                }
            }

        }
    }
}
