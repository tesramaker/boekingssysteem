using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Views;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class PlaneManager
    {
        private PlaneService _planeService;

        public PlaneManager()
        {
            _planeService = new PlaneService();
        }

        public List<Plane> GetFlightToCity(string city)
        {
            List<Plane> planes = new List<Plane>();
            return planes;
        }
    }
}
