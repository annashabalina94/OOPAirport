using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAirport1
{
    class AirportManager
    {
        private IAirport airport = new Airport();

        public void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                  Welcome!");
            Console.WriteLine("                                ************   ");
            Console.WriteLine("       -------------------------------------------------------------");
            Console.WriteLine("      | Press 1. If you want to show Arrival Table                   |");
            Console.WriteLine("      | Press 2. If yoy want to show Departure Table                 |");
            Console.WriteLine("      | Press 3. If you want to show the flights pricelist           |");
            Console.WriteLine("      | Press 4. If you want to show the passengers list             |");
            Console.WriteLine("      | Press 5. If you want to change information                   |");
            Console.WriteLine("      | Press 6. If you want to search                               |");
            Console.WriteLine("      | Press ESC if you want to exit from the program               |");
            Console.WriteLine("       --------------------------------------------------------------");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    airport.PrintArrivals();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    airport.PrintDeparture();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    airport.PrintPriceClassInfo();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    airport.PrintPassengersInfo();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    MainEditionMenu();

                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    airport.Search();
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
            Menu();
        }

        public void MainEditionMenu()
        {
            Console.WriteLine("      ------------------------------------------");
            Console.WriteLine("     |Press 1. If you want to Create information|");
            Console.WriteLine("     |Press 2. If you want to Delete information|");
            Console.WriteLine("     |Press 3. If you want to Edit information  |");
            Console.WriteLine("     |Press 4. If you want back to main menu    |");
            Console.WriteLine("      ------------------------------------------");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CreationMenu();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    DeleteMenu();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    EditMenu();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    break;
            }
            Console.ReadKey();
            Menu();
        }

        public void CreationMenu()
        {
            Console.WriteLine("Press 1. If you want to create new passenger\nPress 2. If you want to create new flight");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    airport.CreatePassenger();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    airport.CreateFlight();
                    break;
            }
            Console.ReadKey();
            Menu();
        }

        public void DeleteMenu()
        {

            {
                Console.WriteLine("Press 1. If you want delete passenger\nPress 2. If you want delete flight");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        airport.DeletePassenger();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        airport.DeleteFlight();
                        break;
                }
                Console.ReadKey();
                Menu();
            }
        }

        public void EditMenu()
        {
            Console.WriteLine("Press 1. If you want to edit passengers info\nPress 2. If you want to edit flights info");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    airport.EditPassenger();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    airport.EditFlight();
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
