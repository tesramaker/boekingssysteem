using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    internal class RoomApiModel
    {
        public int id { get; set; }
        public int hotelId { get; set; }
        public int roomNumber { get; set; }
        public int amountOfPeople { get; set; }
        public decimal price { get; set; }
        public DateTime reservedFrom { get; set; }
        public DateTime reservedTill { get; set; }
        public int typeOfRoom { get; set; }

        public RoomApiModel(int hotelId, int roomNumber, int amountOfPeople, double price, DateTime reservedFrom, DateTime reservedTill, int typeOfRoom)
        {
            this.hotelId = hotelId;
            this.roomNumber = roomNumber;
            this.amountOfPeople = amountOfPeople;
            this.price = (decimal)price;
            this.reservedFrom = reservedFrom;
            this.reservedTill = reservedTill;
            this.typeOfRoom = typeOfRoom;
        }
    }
}
