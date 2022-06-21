using BoekingssysteemAPI.Views;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class FlightService
    {
        private DbConnect _dbConnect;

        public FlightService()
        {
            _dbConnect = new DbConnect();
        }

        public List<Flight> GetAllFlightsToCity(string city)
        {
            List<Flight> flights = new List<Flight>();
            return flights;
        }

        public Flight GetFlightById(int id)
        {
            return new Flight();
        }

        public Plane GetPlaneById(int id)
        {
            return new Plane();
        }
    }
}
