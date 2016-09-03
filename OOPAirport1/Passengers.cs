using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAirport1
{
    class Passengers
    {
        public string Name;
        public string Secondname;
        public string Pasport;
        public string Dateofbirthday;
        public Sex Sex;
        public Nationality Nationality;
    }

    enum Nationality
    {
        Unknown = 0,
        Ukranian = 1,
        Jew = 2,
        Arab = 3,
        Canadian = 4,
        French = 5
    }

    enum Sex
    {
        Unknown = 0,
        Female = 1,
        Male = 2
    }
}
