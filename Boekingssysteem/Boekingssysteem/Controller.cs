using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Controller
    {
        Manager manager;
        Vacation vacation;
        Flight flight;
        Hotel hotel;
        Plane plane;


        public Vacation GetVacationById()
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

        public Vacation GetVacationByUserID()
        {
            return vacation;
        }
    }
}
