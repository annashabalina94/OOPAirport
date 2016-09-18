using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAirport1
{
    public class Airport : IAirport
    {

        public Airport()
        {
            Initialization();
        }

        public void Initialization()
        {
            Random random = new Random();

            var flight1 = new Flight("2000", Classprice.Bissnes, "FS 4422", "Abu-Dhabi", "14:22", "A", "G1", Status.InFlight, FlightStatus.Arrival);
            flights.Add(flight1);
            flight1.Addpassenger("Ali", "Baba", "MT 111 111", "08.07.1995", Sex.Male, Nationality.Arab);
            flight1.Addpassenger("Ali2", "Baba2", "MT 111 1112", "08.07.19952", Sex.Male, Nationality.Arab);

            var flight2 = new Flight("2565", Classprice.Bissnes, "MN 7564", "Paris", "13:00", "B", "G2", Status.GateClosed, FlightStatus.Arrival);
            flights.Add(flight2);
            flight2.Addpassenger("Ivan", "Ivanov", "MT 111 112", "08.07.1993", Sex.Male, Nationality.French);

            var flight3 = new Flight("764", Classprice.Economy, "ST 764", "Odessa", "7:40", "B", "G3", Status.InFlight, FlightStatus.Departure);
            flights.Add(flight3);
            flight3.Addpassenger("Moisha", "Snipperson", "MT 111 113", "08.07.1992", Sex.Male, Nationality.Jew);

            var flight4 = new Flight("200", Classprice.Economy, "DC 678", "Kiev", "17:15", "A", "G1", Status.Canceled, FlightStatus.Departure);
            flights.Add(flight4);
            flight4.Addpassenger("Anna", "Shabalina", "MT 111 114", "08.07.1994", Sex.Female, Nationality.Ukranian);

            var flight5 = new Flight("3000", Classprice.Bissnes, "QS 6789", "Toronto", "11:10", "B", "G2", Status.Arrived, FlightStatus.Arrival);
            flights.Add(flight5);
            flight5.Addpassenger("Petr", "Petrov", "MT 111 115", "08.07.1990", Sex.Male, Nationality.Canadian);
        }

        List<Flight> flights = new List<Flight>();

        public void PrintArrivals()
        {

            Console.WriteLine("Arrival: ");
            Console.WriteLine(" ______________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status   | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i++)
                if (flights[i].FlightStatus == FlightStatus.Arrival)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,10} | {4}        |{5}   |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime,
                        flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" ______________________________________________________________________");
                }
        }

        public void PrintDeparture()
        {
            Console.WriteLine("Departure: ");
            Console.WriteLine(" ______________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status   | Terminal | Gate|");
            Console.WriteLine(" ______________________________________________________________________");

            for (int i = 0; i < flights.Count; i = i + 1)
                if (flights[i].FlightStatus == FlightStatus.Departure)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,10} | {4}        |{5}   |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime,
                        flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" ______________________________________________________________________");
                }
        }

        public void PrintPriceClassInfo()
        {
            Random random = new Random();

            Console.WriteLine("Pricelist:");
            Console.WriteLine(" ______________________________");
            Console.WriteLine("|  Direction  |  Class | Price |");
            Console.WriteLine("|_____________|________|_______|");
            for (int i = 0; i < flights.Count; i++)
            {
                Console.WriteLine("|{0,13}|{1,7} |{2,5}$ |", flights[i].Direction, flights[i].Classprice, flights[i].Price);
                Console.WriteLine("|_____________|________|_______|");

            }
        }

        public void PrintPassengersInfo()
        {
            Console.WriteLine(" ______________________________________________________________________________");
            Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
            Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");

            for (int i = 0; i < flights.Count; i++)
            {
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}   |{4,8}|{5,4}|{6,3} |{7,5}|",
              flights[i].Flightnumber, flights[i].Passengersarr[j].Name, flights[i].Passengersarr[j].Secondname,
              flights[i].Passengersarr[j].Nationality, flights[i].Passengersarr[j].Pasport,
              flights[i].Passengersarr[j].Dateofbirthday, flights[i].Passengersarr[j].Sex, flights[i].Classprice);
                    Console.WriteLine(" _____________________________________________________________________________");
                }
            }
        }

        public void CreatePassenger()
        {
            Console.Clear();
            Passengers cr = null;
            Random random = new Random();
            Flight cr2 = null;
            cr2 = new Flight();

            cr = new Passengers();
            Console.Clear();
            Console.Write("Input Name:");
            cr.Name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input Secondname:");
            cr.Secondname = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input Pasport:");
            cr.Pasport = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input Dateofbirthday D.M.Y: ");
            cr.Dateofbirthday = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Sex\nMale - 1\nFemale - 2");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    cr.Sex = Sex.Male;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    cr.Sex = Sex.Female;
                    break;
            }
            flights.Add(cr2);
            cr2.Passengersarr.Add(cr);
        }

        public void CreateFlight()
        {
            Flight cr2 = null;
            cr2 = new Flight();
            Console.Clear();
            Console.WriteLine("What you wan to create?\nArrival Flights - 1\nDeparture Flights - 2");
            ConsoleKeyInfo key2 = new ConsoleKeyInfo();
            key2 = Console.ReadKey();
            if (key2.Key == ConsoleKey.D1 || key2.Key == ConsoleKey.NumPad1)
            {
                cr2.FlightStatus = FlightStatus.Arrival;
            }
            else
            {
                cr2.FlightStatus = FlightStatus.Departure;
            }
            Console.Clear();
            Console.Write("Input flight number: ");
            cr2.Flightnumber = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input City: ");
            cr2.Direction = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input time hh:mm ~ ");
            cr2.Datetime = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input terminal: ");
            cr2.Terminal = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Input gate: ");
            cr2.Gate = Console.ReadLine();
            flights.Add(cr2);
        }

        public void DeletePassenger()
        {
            Console.Clear();
            Console.WriteLine("Input Name, Secondname or pasport number");
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    if (flights[i].Passengersarr[j].Name.Contains(line) || flights[i].Passengersarr[j].Secondname.Contains(line) || flights[i].Passengersarr[j].Pasport.Contains(line))
                        flights.RemoveAt(i);
                }
            }
        }

        public void DeleteFlight()
        {
            Console.Clear();
            Console.WriteLine("Input flight number or direction wich you want to delete");
            string line2 = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Flightnumber.Contains(line2) || flights[i].Direction.Contains(line2))
                    flights.RemoveAt(i);
            }
        }

        public void Search()
        {
            Console.WriteLine("Input flight number, price, first and second name, passport, direction information wich you want to search");
            Type type = typeof(Status);
            string line = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Flightnumber.Contains(line) || flights[i].Direction.Contains(line) || flights[i].Price.Contains(line))
                {
                    Console.WriteLine(" ___________________________________________________________________________");
                    Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|Price|");
                    Console.WriteLine(" ___________________________________________________________________________");
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |{6}|", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime,
                    flights[i].Status, flights[i].Terminal, flights[i].Gate, flights[i].Price);
                    Console.WriteLine(" __________________________________________________________________________");
                }
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    if (flights[i].Passengersarr[j].Name.Contains(line) || flights[i].Passengersarr[j].Secondname.Contains(line) || flights[i].Passengersarr[j].Pasport.Contains(line))
                    {
                        Console.WriteLine(" ______________________________________________________________________________");
                        Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
                        Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");
                        Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].Flightnumber, flights[i].Passengersarr[0].Name,
                        flights[i].Passengersarr[0].Secondname, flights[i].Passengersarr[0].Nationality, flights[i].Passengersarr[0].Pasport, flights[i].Passengersarr[0].Dateofbirthday,
                        flights[i].Passengersarr[0].Sex, flights[i].Classprice);
                        Console.WriteLine(" _____________________________________________________________________________");
                    }
                }
            }
        }

        public void EditPassenger()
        {
            Console.Clear();
            for (int i = 0; i < flights.Count; i++)
            {
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    Search();
                    Console.WriteLine("If you want to edit flight number - 1\nName - 2\nSecondname - 3\nPasport - 5\nDB - 6");
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            flights[i].Flightnumber = Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            flights[i].Passengersarr[j].Name = Console.ReadLine();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            flights[i].Passengersarr[j].Secondname = Console.ReadLine();
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            flights[i].Passengersarr[j].Pasport = Console.ReadLine();
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            flights[i].Passengersarr[j].Dateofbirthday = Console.ReadLine();
                            break;
                    }
                }
            }
        }

        public void EditFlight()
        {
            for (int i = 0; i < flights.Count; i++)
            {
                Search();
                Console.WriteLine("If you want to edit flight number - 1\nDirection - 2\nDateTime - 3\nTerminal - 4\nGate - 5");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        flights[i].Flightnumber = Console.ReadLine();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        flights[i].Direction = Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        flights[i].Datetime = Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        flights[i].Terminal = Console.ReadLine();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        flights[i].Gate = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
