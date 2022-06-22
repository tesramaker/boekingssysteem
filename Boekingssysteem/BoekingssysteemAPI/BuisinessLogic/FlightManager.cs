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

        //public Vacation GetVacationById(int id)
        //{
        //    return _flightService.GetVacationById(id);
        //}

        //public Vacation GetVacationByUserId(int userId)
        //{
        //    return _flightService.GetVacationByUserId(userId);
        //}

        public Flight GetFlightById(int id)
        {
            return _flightService.GetFlightById(id);
        }

        public List<Flight> GetAllFlights()
        {
            return _flightService.GetAllFlights();
        }

    }
}
