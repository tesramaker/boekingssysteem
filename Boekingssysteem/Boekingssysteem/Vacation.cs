using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
    {
    internal class Vacation
        {
        public int id { get; set; }
        public Hotel hotel { get; set; }
        public Flight outboundTrip { get; set; }
        public Flight returnTrip { get; set; }
        public int amountOfPeople { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double extraBagageInKg { get; set; }

        public Vacation(int id, Hotel hotel, Flight outboundTrip, Flight returnTrip, int amountOfPeople, DateTime startDate, DateTime endDate, double extraBagageInKg)
        {
            this.id = id;
            this.hotel = hotel;
            this.outboundTrip = outboundTrip;
            this.returnTrip = returnTrip;
            this.amountOfPeople = amountOfPeople;
            this.startDate = startDate;
            this.endDate = endDate;
            this.extraBagageInKg = extraBagageInKg;
        }

        public double GetTotalPrice()
        {
            return extraBagageInKg;
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
