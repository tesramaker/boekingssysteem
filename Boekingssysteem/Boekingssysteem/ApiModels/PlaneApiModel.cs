using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    internal class PlaneApiModel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public string airline { get; set; }

        public int defaultAmountSeats { get; set; }

        public PlaneApiModel(string name, int seats, string airline, int defaultAmountSeats)
        {
            this.name = name;
            this.seats = seats;
            this.airline = airline;
            this.defaultAmountSeats = defaultAmountSeats;
        }

        public PlaneApiModel(int id, string name, int seats, string airline, int defaultAmountSeats)
        {
            this.id = id;
            this.name = name;
            this.seats = seats;
            this.airline = airline;
            this.defaultAmountSeats = defaultAmountSeats;
        }
    }
}
