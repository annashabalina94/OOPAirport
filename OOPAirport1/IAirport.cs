using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAirport1
{
    public interface IAirport
    {
        void PrintArrivals();

        void PrintDeparture();

        void PrintPriceClassInfo();

        void PrintPassengersInfo();

        void Create();

        void Del();

        void Edit();

        void Search();

    }
}
