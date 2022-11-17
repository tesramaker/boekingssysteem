using Microsoft.EntityFrameworkCore;

namespace BoekingssysteemAPI.Model
{
    public class Room
    {
        public int id { get; set; }
        public int hotelId { get; set; }
        public int roomNumber { get; set; }
        public int amountOfPeople { get; set; }
        public decimal price { get; set; }
        public DateTime? reservedFrom { get; set; }
        public DateTime? reservedTill { get; set; }
        public int typeOfRoom { get; set; }

        public Room(int hotelId, int roomNumber, int amountOfPeople, decimal price, DateTime reservedFrom, DateTime reservedTill)
        {
            this.hotelId = hotelId;
            this.roomNumber = roomNumber;
            this.amountOfPeople = amountOfPeople;
            this.price = price;
            this.reservedFrom = reservedFrom;
            this.reservedTill = reservedTill;
        }

        public Room(int hotelId, int roomNumber, int amountOfPeople, decimal price)
        {
            this.hotelId = hotelId;
            this.roomNumber = roomNumber;
            this.amountOfPeople = amountOfPeople;
            this.price = price;
        }
    }
}
