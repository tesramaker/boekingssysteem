using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Room
    {
        public int id { get; set; }
        public Hotel hotel { get; set; }
        public int roomnumber { get; set; }
        public int amountOfPeople { get; set; }
        public double pricePerNightPerPerson { get; set; }
        public int typeOfRoom { get; set; }
        public DateTime reservedFrom { get; set; }
        public DateTime reservedTill { get; set; }

        public Room(int id, int roomnumber, int amountOfPeople, double pricePerNightPerPerson, int typeOfRoom)
        {
            this.id = id;
            this.roomnumber = roomnumber;
            this.amountOfPeople = amountOfPeople;
            this.pricePerNightPerPerson = pricePerNightPerPerson;
            this.typeOfRoom = typeOfRoom;
        }

        public Room(int id, int roomnumber, int amountOfPeople, double pricePerNightPerPerson, int typeOfRoom, DateTime reservedFrom, DateTime reservedTill)
        {
            this.id = id;
            this.roomnumber = roomnumber;
            this.amountOfPeople = amountOfPeople;
            this.pricePerNightPerPerson = pricePerNightPerPerson;
            this.typeOfRoom = typeOfRoom;
        }
    }
}
