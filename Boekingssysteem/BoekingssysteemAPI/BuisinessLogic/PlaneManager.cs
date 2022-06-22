﻿using BoekingssysteemAPI.DataAccessLayer;
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

        public bool Delete(int id)
        {
            Plane plane = _planeService.GetPlaneById(id);
            return _planeService.Delete(plane);
        }
    }
}
