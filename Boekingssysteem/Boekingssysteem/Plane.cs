using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class Plane
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public string airline { get; set; }
        public int defaultAmountSeats { get; set; }

        public Plane(int id, string name, string airline, int seats, int defaultAmountSeats)
        {
            this.name = name;
            this.id = id;
            this.airline = airline;
            this.seats = seats;
            this.defaultAmountSeats = defaultAmountSeats;
        }

        public Plane(string name, string airline, int seats, int defaultAmountSeats)
        {
            this.name = name;
            this.airline = airline;
            this.seats = seats;
            this.defaultAmountSeats = defaultAmountSeats;
        }

        public int OpenSeats()
        {
            return seats;
        }
    }
}
