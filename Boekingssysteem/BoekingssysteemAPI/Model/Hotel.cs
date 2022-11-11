namespace BoekingssysteemAPI.Model
{
    public class Hotel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        //TODO add coordinates to DB
        public double xCoordinate { get; set; }
        public double yCoordinate { get; set; }

        public Hotel(string name, string city, double xCoordinate, double yCoordinate)
        {
            this.name = name;
            this.city = city;
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;  
        }

        public Hotel(string name, string city)
        {
            this.name = name;
            this.city = city;
        }

        //TODO might not have to be implemented and could be deleted
        //public void SetCoordinates(double xCoordinate, double yCoordinate)
        //{
        //    this.xCoordinate = xCoordinate;
        //    this.yCoordinate = yCoordinate;
        //}
    }
}
