using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Manager
    {
        Service service;
        Vacation vacation;
        Flight flight;
        Hotel hotel;
        Plane plane;


        public Vacation GetVacation() 
        {
            return vacation;
        }

        public Flight GetFlightById()
        {
            return flight;
        }

        public Hotel GetHotelById()
        {
            return hotel;
        }

        public Plane GetPlaneById()
        {
            return plane;
        }

        public Vacation GetVacationByUserId()
        {
            return vacation;
        }
    }
}
