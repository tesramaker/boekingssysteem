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
        public String airline { get; set; }
        int seats;
        int DefaultAmountSeats;

        public Plane(int id, string airline, int seats, int defaultAmountSeats)
        {
            //System.Diagnostics.Debug.WriteLine("Creating  plane with " + id + airline + seats + defaultAmountSeats);
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
