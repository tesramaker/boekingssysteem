using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class PlaneManager
    {
        private PlaneService _planeService;

        public PlaneManager()
        {
            _planeService = new PlaneService();
        }

        public List<Plane> GetAllPlanes()
        {
            return _planeService.GetAllPlanes();
        }

        public Plane GetPlaneById(int id)
        {
            return _planeService.GetPlaneById(id);
        }

        public bool Create(Plane plane)
        {
            return _planeService.Create(plane); 
        }

        public bool Edit(Plane plane)
        {
            return _planeService.Edit(plane);
        }

        public bool DeleteById(int id)
        {
            Plane plane = _planeService.GetPlaneById(id);
            return _planeService.Delete(plane);
        }

        public bool Delete(Plane plane)
        {
            return _planeService.Delete(plane);
        }
    }
}
