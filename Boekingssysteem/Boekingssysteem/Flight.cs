using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class Flight
    {
        public int id { get; set; }
        public int flightNumber { get; set; }
        public Plane plane { get; set; }
        public double price { get; set; }
        public String departurePlace { get; set; }
        public DateTime departureDate { get; set; }
        public String destination { get; set; }
        public DateTime arrivalDate { get; set; }
        int amountOfPlaces;

        public Flight(int flightNumber, Plane plane, double price, string departurePlace, DateTime departureDate, string destination, DateTime arrivalDate, int amountOfPlaces)
        {
            this.flightNumber = flightNumber;
            this.plane = plane;
            this.price = price;
            this.departurePlace = departurePlace;
            this.departureDate = departureDate;
            this.destination = destination;
            this.arrivalDate = arrivalDate;
            this.amountOfPlaces = amountOfPlaces;
        }

        public Flight(int flightNumber, Plane plane, double price, string departurePlace, DateTime departureDate, string destination, DateTime arrivalDate)
        {
            this.flightNumber = flightNumber;
            this.plane = plane;
            this.price = price;
            this.departurePlace = departurePlace;
            this.departureDate = departureDate;
            this.destination = destination;
            this.arrivalDate = arrivalDate;
        }

        public Plane GetPlane ( )
        {
            return plane;
        }

        public void AddFlight ( )
        {

        }
    }
}
