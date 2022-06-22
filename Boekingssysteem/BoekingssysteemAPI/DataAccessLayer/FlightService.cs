using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class FlightService
    {
        //private DbConnect _dbConnect;

        public FlightService()
        {
            //_dbConnect = new DbConnect();
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

        public List<Flight> GetAllFlights()
        {
            return new List<Flight>();
        }
    }
}
