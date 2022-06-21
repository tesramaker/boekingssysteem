namespace BoekingssysteemAPI.Views
{
    public class Plane
    {
        public int? planeId;
        public string name;
        public int seats;
        public string airline;

        public Plane(int? planeId, string name, int seats, string airline)
        {
            this.planeId = planeId;
            this.name = name;
            this.seats = seats;
            this.airline = airline;
        }

        public Plane(string name, int seats, string airline)
        {
            this.name = name;
            this.seats = seats;
            this.airline = airline;
        }
    }
}
