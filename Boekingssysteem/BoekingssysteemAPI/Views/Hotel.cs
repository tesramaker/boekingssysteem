namespace BoekingssysteemAPI.Views
{
    public class Hotel
    {
        public int? id;
        public string name;
        public string city;

        public Hotel(int? id, string name, string city)
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
