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
            Random random = new Random();

            var flight1 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight1.FlightStatus = FlightStatus.Arrival;
            flight1.Flightnumber = "FS 4422";
            flight1.Direction = "Abu-Dhabi";
            flight1.Datetime = "14:22";
            flight1.Terminal = "A";
            flight1.Gate = "G1";
            var pasan1 = new Passengers();
            pasan1.Name = "Ali";
            pasan1.Secondname = "Baba";
            pasan1.Pasport = "MT 111 111";
            pasan1.Dateofbirthday = "08.07.1995";
            pasan1.Nationality = Nationality.Arab;
            pasan1.Sex = Sex.Male;
            flight1.Passengersarr.Add(pasan1);
            flights.Add(flight1);

            var flight2 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight2.FlightStatus = FlightStatus.Arrival;
            flight2.Flightnumber = "MN 7564";
            flight2.Direction = "Paris";
            flight2.Datetime = "13:00";
            flight2.Terminal = "B";
            flight2.Gate = "G2";
            var pasan2 = new Passengers();
            pasan2.Name = "Ivan";
            pasan2.Secondname = "Ivanov";
            pasan2.Pasport = "MT 111 112";
            pasan2.Dateofbirthday = "08.07.1993";
            pasan2.Nationality = Nationality.French;
            pasan2.Sex = Sex.Male;
            flight2.Passengersarr.Add(pasan2);
            flights.Add(flight2);

            var flight3 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight3.FlightStatus = FlightStatus.Departure;
            flight3.Flightnumber = "ST 764";
            flight3.Direction = "Odessa";
            flight3.Datetime = "7:40";
            flight3.Terminal = "B";
            flight3.Gate = "G3";
            var pasan3 = new Passengers();
            pasan3.Name = "Moisha";
            pasan3.Secondname = "Snipperson";
            pasan3.Pasport = "MT 111 113";
            pasan3.Dateofbirthday = "08.07.1992";
            pasan3.Nationality = Nationality.Jew;
            pasan3.Sex = Sex.Male;
            flight3.Passengersarr.Add(pasan3);
            flights.Add(flight3);

            var flight4 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight4.FlightStatus = FlightStatus.Departure;
            flight4.Flightnumber = "DC 678";
            flight4.Direction = "Kiev";
            flight4.Datetime = "17:15";
            flight4.Terminal = "A";
            flight4.Gate = "G1";
            var pasan4 = new Passengers();
            pasan4.Name = "Anna";
            pasan4.Secondname = "Shabalina";
            pasan4.Pasport = "MT 111 114";
            pasan4.Dateofbirthday = "08.07.1994";
            pasan4.Nationality = Nationality.Ukranian;
            pasan4.Sex = Sex.Female;
            flight4.Passengersarr.Add(pasan4);
            flights.Add(flight4);

            var flight5 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
            flight5.FlightStatus = FlightStatus.Arrival;
            flight5.Flightnumber = "QS 6789";
            flight5.Direction = "Toronto";
            flight5.Datetime = "11:10";
            flight5.Terminal = "B";
            flight5.Gate = "G2";
            var pasan5 = new Passengers();
            pasan5.Name = "Petr";
            pasan5.Secondname = "Petrov";
            pasan5.Pasport = "MT 111 115";
            pasan5.Dateofbirthday = "08.07.1990";
            pasan5.Nationality = Nationality.Canadian;
            pasan5.Sex = Sex.Male;
            flight5.Passengersarr.Add(pasan5);
            flights.Add(flight5);
        }

        List<Flight> flights = new List<Flight>();

        public void PrintArrivals()
        {

            Console.WriteLine("Arrival: ");
            Console.WriteLine(" _____________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i++)
                if (flights[i].FlightStatus == FlightStatus.Arrival)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
                }
        }
        public void PrintDeparture()
        {
            Console.WriteLine("Departure: ");
            Console.WriteLine(" _____________________________________________________________________");
            Console.WriteLine("| Number  |  Direction   | Date and Time |   Status  | Terminal | Gate|");
            Console.WriteLine(" _____________________________________________________________________");

            for (int i = 0; i < flights.Count; i = i + 1)
                if (flights[i].FlightStatus == FlightStatus.Departure)
                {
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate);
                    Console.WriteLine(" _____________________________________________________________________");
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
                Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].Flightnumber, flights[i].Passengersarr[0].Name, flights[i].Passengersarr[0].Secondname, flights[i].Passengersarr[0].Nationality, flights[i].Passengersarr[0].Pasport, flights[i].Passengersarr[0].Dateofbirthday, flights[i].Passengersarr[0].Sex, flights[i].Classprice);
                Console.WriteLine(" _____________________________________________________________________________");
            }
        }
        public void Create()
        {
            Console.Clear();
            Console.WriteLine("What you want to create?\nNew passenger - 1\nNew Flight - 2");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            Flight cr2 = null;
            Passengers cr = null;
            Random random = new Random();
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
            {
                cr = new Passengers();
                Console.Clear();
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
                Console.WriteLine("Input Dateofbirthday D.M.Y: ");
                cr.Dateofbirthday = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Sex\nMale - 1\nFemale - 2");

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        cr.Sex = Sex.Male;
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        cr.Sex = Sex.Female;
                        Console.ReadKey();
                        break;
                }
                cr2 = new Flight(random, Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
                cr2.Passengersarr.Add(cr);
                flights.Add(cr2);
            }
            else
            {
                cr2 = new Flight(new Random(), Classprice.Bissnes, Classprice.Economy, FlightStatus.Arrival, FlightStatus.Departure);
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
                Console.WriteLine("Input terminal: ");
                cr2.Terminal = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Input gate: ");
                cr2.Gate = Console.ReadLine();
                Console.ReadKey();

                flights.Add(cr2);
            }
        }
        public void Del()
        {
            Console.Clear();
            Console.WriteLine("What you want to delete?\nDelete passenger - 1\nDelete Flight - 2");
            ConsoleKeyInfo key1 = new ConsoleKeyInfo();
            key1 = Console.ReadKey();
            if (key1.Key == ConsoleKey.D1 || key1.Key == ConsoleKey.NumPad1)
            {
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
            else
            {
                Console.WriteLine("Input flight number or direction wich you want to delete");
                string line2 = Console.ReadLine();
                for (int i = 0; i < flights.Count; i++)
                {
                    if (flights[i].Flightnumber.Contains(line2) || flights[i].Direction.Contains(line2))
                        flights.RemoveAt(i);
                }
                Console.WriteLine("Press ESC to exit to the main menu");
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        break;
                }
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
                    Console.WriteLine("|{0,8} | {1,9}    | {2,10}    | {3,08}  | {4}      |{5}  |{6}|", flights[i].Flightnumber, flights[i].Direction, flights[i].Datetime, flights[i].Status, flights[i].Terminal, flights[i].Gate, flights[i].Price);
                    Console.WriteLine(" __________________________________________________________________________");
                }
                for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                {
                    if (flights[i].Passengersarr[j].Name.Contains(line) || flights[i].Passengersarr[j].Secondname.Contains(line) || flights[i].Passengersarr[j].Pasport.Contains(line))
                    {
                        Console.WriteLine(" ______________________________________________________________________________");
                        Console.WriteLine("| Number | Name | Second Name | Nationality | Pasport |    DB    | Sex | Class |");
                        Console.WriteLine("|________|______|_____________|_____________|_________|__________|_____|_______|");
                        Console.WriteLine("|{0,7} |{1,5} |{2,11} |{3,10}  |{4,8}|{5,4}|{6,3} |{7,5}|", flights[i].Flightnumber, flights[i].Passengersarr[0].Name, flights[i].Passengersarr[0].Secondname, flights[i].Passengersarr[0].Nationality, flights[i].Passengersarr[0].Pasport, flights[i].Passengersarr[0].Dateofbirthday, flights[i].Passengersarr[0].Sex, flights[i].Classprice);
                        Console.WriteLine(" _____________________________________________________________________________");
                    }
                }
            }
        }
        public void Edit()
        {
            Console.Clear();
            Console.WriteLine("What you want to Edit?\nEdit passengers - 1\nEdit flights - 2\nEdit Pricelist - 3");
            ConsoleKeyInfo key1 = new ConsoleKeyInfo();
            key1 = Console.ReadKey();
            if (key1.Key == ConsoleKey.D1 || key1.Key == ConsoleKey.NumPad1)
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    for (int j = 0; j < flights[i].Passengersarr.Count; j++)
                    {
                        Search();
                        Console.WriteLine("If you want to edit flight number - 1\nName - 2\nSecondname - 3\nPasport - 5\nDB - 6");
                        ConsoleKeyInfo key = new ConsoleKeyInfo();
                        key = Console.ReadKey();
                        switch (key.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                flights[i].Flightnumber = Console.ReadLine();
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                flights[i].Passengersarr[j].Name = Console.ReadLine();
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                flights[i].Passengersarr[j].Secondname = Console.ReadLine();
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                flights[i].Passengersarr[j].Pasport = Console.ReadLine();
                                break;

                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                flights[i].Passengersarr[j].Dateofbirthday = Console.ReadLine();
                                break;
                        }
                    }
                }
            }
            if (key1.Key == ConsoleKey.D2 || key1.Key == ConsoleKey.NumPad2)
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Search();
                    Console.WriteLine("If you want to edit flight number - 1\nDirection - 2\nDateTime - 3\nTerminal - 4\nGate - 5");
                    ConsoleKeyInfo key = new ConsoleKeyInfo();
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            flights[i].Flightnumber = Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            flights[i].Direction = Console.ReadLine();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            flights[i].Datetime = Console.ReadLine();
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Console.Clear();
                            flights[i].Terminal = Console.ReadLine();
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            Console.Clear();
                            flights[i].Gate = Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
