using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Views;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class FlightManager
    {
        private FlightService _flightService;

        public FlightManager()
        {
            _flightService = new FlightService();
        }

        public List<Flight> GetAllFLights()
        {
            return _flightService.GetAllFlights();
        }

        public Vacation GetVacationById(int id)
        {
            return _flightService.GetVacationById(id);
        }
        public Vacation GetVacationByUserId(int userId)
        {
            return _flightService.GetVacationByUserId(userId);
        }

        public Flight GetFlightById(int id)
        {
            return _flightService.GetFlightById(id);
        }



        public Plane GetPlaneById(int id)
        {
            return _flightService.GetPlaneById(id);
        }

    }
}
