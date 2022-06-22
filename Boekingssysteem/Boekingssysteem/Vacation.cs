using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
    {
    internal class Vacation
        {
        int id;
        Hotel hotel;
        Flight outboundTrip;
        Flight returnTrip;
        int amountOfPeople;
        DateTime startDate;
        DateTime endDate;
        double extrabagageInKG;

        public double GetTotalPrice()
        {
            return extrabagageInKG;
        }

        public Hotel GetHotel()
        {
            return hotel;
        }

        public Flight getOutboundTrip()
        {
            return outboundTrip;
        }

        public Flight GetreturnTrip()
        {
            return returnTrip;
        }
    }
}
