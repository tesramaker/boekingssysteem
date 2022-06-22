using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class FlightManager
    {
        private FlightService _flightService;

        public FlightManager()
        {
            _flightService = new FlightService();
        }

        public List<Flight> GetAllFlightsToCity(string city)
        {
            return _flightService.GetAllFlightsToCity(city);
        }

        public Flight GetFlightById(int id)
        {
            return _flightService.GetFlightById(id);
        }

        public List<Flight> GetAllFlights()
        {
            return _flightService.GetAllFlights();
        }

        public bool Create(Flight flight)
        {
            return _flightService.Create(flight);
        }

        public bool Edit(Flight flight)
        {
            return _flightService.Edit(flight);
        }

        public bool Delete(Flight flight)
        {
            return _flightService.Delete(flight);
        }
    }
}
