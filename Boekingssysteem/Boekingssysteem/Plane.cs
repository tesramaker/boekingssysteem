using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
    {
    internal class Plane
        {
        int Id;
        String airline;
        int seats;
        int DefaultAmountSeats;

        public Plane(int id, string airline, int seats, int defaultAmountSeats)
        {
            Id = id;
            this.airline = airline;
            this.seats = seats;
            DefaultAmountSeats = defaultAmountSeats;
        }

        public int OpenSeats()
        {
            return seats;
        }
    }
}
