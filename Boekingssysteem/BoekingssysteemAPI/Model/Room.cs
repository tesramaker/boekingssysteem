using Microsoft.EntityFrameworkCore;

namespace BoekingssysteemAPI.Model
{
    [Keyless]
    public class Room
    {
        public int hotelId { get; set; }
        public int roomNumber { get; set; }
        public int amountOfPeople { get; set; }
        public decimal price { get; set; }

        //public Room(int roomNumber, int amountOfPeople, decimal price)
        //{
        //    this.roomNumber = roomNumber;
        //    this.amountOfPeople = amountOfPeople;
        //    this.price = price;
        //}
    }
}
