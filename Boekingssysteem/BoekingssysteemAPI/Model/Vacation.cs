namespace BoekingssysteemAPI.Model
{
    public class Vacation
    {
        public int? id { get; set; }
        public int userId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int hotelId { get; set; }
        public int roomId { get; set; }
        public int flightId { get; set; }
        public double extraBagageInKg { get; set; }
        public int? amountOfPeople { get; set; }

        public Vacation(int userId, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId, double extraBagageInKg, int amountOfPeople)
        {
            this.userId = userId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotelId = hotelId;
            this.roomId = roomId;
            this.flightId = flightId;
            this.extraBagageInKg = extraBagageInKg;
            this.amountOfPeople = amountOfPeople;
        }

        public Vacation(int userId, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId, double extraBagageInKg)
        {
            this.userId = userId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotelId = hotelId;
            this.roomId = roomId;
            this.flightId = flightId;
            this.extraBagageInKg = extraBagageInKg;
        }

        public Vacation(int userId, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId)
        {
            this.userId = userId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotelId = hotelId;
            this.roomId = roomId;
            this.flightId = flightId;
        }
    }
}
