namespace BoekingssysteemAPI.Model
{
    public class Plane
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public string airline { get; set; }

        public Plane(string name, int seats, string airline)
        {
            this.name = name;
            this.seats = seats;
            this.airline = airline;
        }
    }
}
