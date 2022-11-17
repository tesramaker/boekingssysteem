namespace BoekingssysteemAPI.Model
{
    public class Hotel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double? xCoord { get; set; }
        public double? yCoord { get; set; }

        public Hotel(int id, string name, string city, double xCoord, double yCoord)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public Hotel(string name, string city, double xCoord, double yCoord)
        {
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
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
