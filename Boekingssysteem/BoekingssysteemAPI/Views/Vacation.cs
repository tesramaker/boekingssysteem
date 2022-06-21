namespace BoekingssysteemAPI.Views
{
    public class Vacation
    {
        public int? id;
        public string name;
        public DateTime startDate;
        public DateTime endDate;
        public int hotelId;
        public int roomId;
        public int flightId;

        public Vacation(int? id, string name, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotelId = hotelId;
            this.roomId = roomId;
            this.flightId = flightId;
        }

        public Vacation(string name, DateTime startDate, DateTime endDate, int hotelId, int roomId, int flightId)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hotelId = hotelId;
            this.roomId = roomId;
            this.flightId = flightId;
        }
    }
}
