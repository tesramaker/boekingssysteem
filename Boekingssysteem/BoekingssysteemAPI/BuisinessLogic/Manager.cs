using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Views;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class Manager
    {
        private Service _service = new Service();

        public List<Flight> GetAllFLights()
        {
            return _service.GetAllFlights();
        }

        public Vacation GetVacationById(int id)
        {

        }
        public Vacation GetVacationByUserId(int userId)
        {

        }

        public Flight GetFlightById(int id)
        {

        }

        public Hotel GetHotelByName(string name)
        {

        }

        public Plane GetPlaneById(int id)
        {

        }

    }
}
