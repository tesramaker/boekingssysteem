using System.ComponentModel.DataAnnotations.Schema;

namespace BoekingssysteemAPI.Model
{
    [Table("Plane")]
    public class Plane
    {
        public int id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public string airline { get; set; }
        public int defaultAmountSeats { get; set; }

        //public Plane(int id, string name, int seats, string airline, int defaultAmountSeats)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.seats = seats;
        //    this.airline = airline;
        //    this.defaultAmountSeats = defaultAmountSeats;
        //}

        //public Plane(int id,string name, int seats, string airline)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.seats = seats;
        //    this.airline = airline;
        //}

        //public Plane(string name, int seats, string airline)
        //{
        //    this.name = name;
        //    this.seats = seats;
        //    this.airline = airline;
        //}
    }
}
