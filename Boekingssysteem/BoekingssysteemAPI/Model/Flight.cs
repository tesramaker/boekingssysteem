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

        //public Flight(int id, int planeId, string fromLocation, string toLocation, DateTime departDate, DateTime arrivalDate, decimal cost, int flightNumber)
        //{
        //    this.id = id;
        //    this.planeId = planeId;
        //    this.fromLocation = fromLocation;
        //    this.toLocation = toLocation;
        //    this.departDate = departDate;
        //    this.arrivalDate = arrivalDate;
        //    this.cost = cost;
        //    this.flightNumber = flightNumber;
        //}

        //public Flight(int planeId, string fromLocation, string toLocation, DateTime departDate, DateTime arrivalDate, decimal cost, int flightNumber)
        //{
        //    this.planeId = planeId;
        //    this.fromLocation = fromLocation;
        //    this.toLocation = toLocation;
        //    this.departDate = departDate;
        //    this.arrivalDate = arrivalDate;
        //    this.cost = cost;
        //    this.flightNumber = flightNumber;
        //}
        //public Flight(int planeId, string fromLocation, string toLocation, DateTime departDate, DateTime arrivalDate, decimal cost)
        //{
        //    this.planeId = planeId;
        //    this.fromLocation = fromLocation;
        //    this.toLocation = toLocation;
        //    this.departDate = departDate;
        //    this.arrivalDate = arrivalDate;
        //    this.cost = cost;
        //}
    }
}
