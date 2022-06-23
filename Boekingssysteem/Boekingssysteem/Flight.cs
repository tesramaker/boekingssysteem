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
        Plane plane;
        double price;
        String departurePlace;
        DateTime departureDate;
        String destination;
        DateTime arrivalDate;
        int amountOfPlaces;


        public Plane GetPlane ( )
            {
            return plane;
            }

        public void AddFlight ( )
            {

            }
        }
    }
