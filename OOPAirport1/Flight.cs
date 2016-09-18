using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAirport1
{
    class Flight
    {
        public List<Passengers> Passengersarr { get; set; }
        public string Price { get; set; }
        public Classprice Classprice { get; set; }
        public string Flightnumber { get; set; }
        public string Direction { get; set; }
        public string Datetime { get; set; }
        public string Terminal { get; set; }
        public string Gate { get; set; }
        public Status Status { get; set; }
        public FlightStatus FlightStatus { get; set; }

        public Flight()
        {
            List<Passengers> Passengersarr;
        }

        public Flight(string price, Classprice classprice, string flightnumber, string direction, string datetime, string terminal, string gate, Status status, FlightStatus flightStatus)
        {
            this.Price = price;
            this.Classprice = classprice;
            this.Flightnumber = flightnumber;
            this.Direction = direction;
            this.Datetime = datetime;
            this.Terminal = terminal;
            this.Gate = gate;
            this.Status = status;
            this.FlightStatus = flightStatus;
            this.Passengersarr = new List<Passengers>();
        }

        public void Addpassenger(string name, string secondname, string pasport, string dateofbirthday, Sex sex, Nationality nationality)
        {
            var passenger = new Passengers();
            passenger.Name = name;
            passenger.Secondname = secondname;
            passenger.Pasport = pasport;
            passenger.Dateofbirthday = dateofbirthday;
            passenger.Sex = sex;
            passenger.Nationality = nationality;
            Passengersarr.Add(passenger);
        }
    }

    enum FlightStatus
    {
        Unknown = 0,
        Arrival = 1,
        Departure = 2
    }

    enum Classprice
    {
        Unknown = 0,
        Economy = 1,
        Bissnes = 2
    }

    enum Status
    {
        Unknown = 0,
        CheckIn = 1,
        GateClosed = 2,
        Arrived = 3,
        DepartedAt = 4,
        Canceled = 5,
        ExpectedAt = 6,
        Delayed = 7,
        InFlight = 8
    }
}
