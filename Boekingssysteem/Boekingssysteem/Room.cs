using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Room
    {
        int roomnumber;
        public int amountOfPeople { get; set; }
        public double pricePerNightPerPerson { get; set; }
        int TypeOfRoom;

        public Room(int roomnumber, int amountOfPeople, double pricePerNightPerPerson, int typeOfRoom)
        {
            this.roomnumber = roomnumber;
            this.amountOfPeople = amountOfPeople;
            this.pricePerNightPerPerson = pricePerNightPerPerson;
            TypeOfRoom = typeOfRoom;
        }
    }
}
