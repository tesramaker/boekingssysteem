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
        String airline;
        int seats;
        int DefaultAmountSeats;

        public int OpenSeats()
        {
            return seats;
        }
    }
}
