using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{

    internal class Service
    {
        //DbConn DBconnection;
        Vacation vacation;
        Flight flight;
        Plane plane;
        Hotel hotel;

        public Vacation GetVacationById()
        {
            return vacation;
        }

        public Flight GetFlightById()
        {
            return flight;
        }

        public Vacation GetVacationByUserId()
        {
            return vacation;
        }

        public Plane GetPlaneById()
        {
            return plane;
        }

        public Hotel GethotelByName()
        {
            return hotel;
        }
    }
}