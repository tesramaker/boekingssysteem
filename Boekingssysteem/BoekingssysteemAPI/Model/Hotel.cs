namespace BoekingssysteemAPI.Model
{
    public class Hotel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        public Hotel(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
    }
}
