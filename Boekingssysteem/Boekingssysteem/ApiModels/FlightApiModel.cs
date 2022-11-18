using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    internal class FlightApiModel
    {
        public int id { get; set; }
        public int FlightNumber { get; set; }
        public int planeId { get; set; }
        public string fromLocation { get; set; }
        public string toLocation { get; set; }
        public DateTime departDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public double cost { get; set; }

        public FlightApiModel(int planeId, string fromLocation, string toLocation, DateTime departDate, DateTime arrivalDate, double cost)
        {
            this.planeId = planeId;
            this.fromLocation = fromLocation;
            this.toLocation = toLocation;
            this.departDate = departDate;
            this.arrivalDate = arrivalDate;
            this.cost = cost;
        }
    }
}
