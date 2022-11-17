using System.Diagnostics.CodeAnalysis;

namespace BoekingssysteemAPI.Model
{
    public class Flight
    {
        public int id { get; set; }
        public int planeId { get; set; }
        public string fromLocation { get; set; }
        public string toLocation { get; set; }
        public DateTime departDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public decimal cost { get; set; }
        public int? flightNumber { get; set; }
    }
}
