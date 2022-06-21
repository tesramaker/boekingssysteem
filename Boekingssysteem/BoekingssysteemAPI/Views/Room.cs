namespace BoekingssysteemAPI.Views
{
    public class Room
    {
        public int hotelId;
        public int roomNumber;
        public int amountOfPeople;
        public decimal price;

        public Room(int hotelId, int roomNumber, int amountOfPeople, decimal price)
        {
            this.hotelId = hotelId;
            this.roomNumber = roomNumber;
            this.amountOfPeople = amountOfPeople;
            this.price = price;
        }

        public Room(int roomNumber, int amountOfPeople, decimal price)
        {
            this.roomNumber = roomNumber;
            this.amountOfPeople = amountOfPeople;
            this.price = price;
        }
    }
}
