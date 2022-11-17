namespace BoekingssysteemAPI.Model
{
    public class Vacation
    {
        public int id { get; set; }
        public int userId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int hotelId { get; set; }
        public int roomId { get; set; }
        public int flightId { get; set; }
        public double? extraBagageInKg { get; set; }
        public int? amountOfPeople { get; set; }
    }
}
