using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
    {
    internal class Flight
        {
        int FlightNumber;
        public Plane plane { get; set; }
        public double price { get; set; }
        String departurePlace;
        public DateTime departureDate { get; set; }
        public String destination { get; set; }
        public DateTime arrivalDate { get; set; }
        int amountOfPlaces;

        public Flight(int flightNumber, Plane plane, double price, string departurePlace, DateTime departureDate, string destination, DateTime arrivalDate, int amountOfPlaces)
        {
            FlightNumber = flightNumber;
            this.plane = plane;
            this.price = price;
            this.departurePlace = departurePlace;
            this.departureDate = departureDate;
            this.destination = destination;
            this.arrivalDate = arrivalDate;
            this.amountOfPlaces = amountOfPlaces;
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
