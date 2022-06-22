namespace BoekingssysteemAPI.Model
{
    public class Vacation
    {
        public int? id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int hotelId { get; set; }
        public int roomId { get; set; }
        public int flightId { get; set; }

        //public Vacation(string name, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId)
        //{
        //    this.name = name;
        //    this.startDate = startDate;
        //    this.endDate = endDate;
        //    this.hotelId = hotelId;
        //    this.roomId = roomId;
        //    this.flightId = flightId;
        //}
    }
}
