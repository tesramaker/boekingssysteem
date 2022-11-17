namespace BoekingssysteemAPI.Model
{
    public class Hotel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double xCoordinate { get; set; }
        public double yCoordinate { get; set; }

        public Hotel(string name, string city, double xCoordinate, double yCoordinate)
        {
            this.name = name;
            this.city = city;
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }

        public Hotel(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

        public Hotel(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
    }
}
