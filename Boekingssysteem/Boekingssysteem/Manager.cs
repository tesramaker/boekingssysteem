using Boekingssysteem.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class Manager
    {
        private readonly ApiCaller _apiCaller;

        public Manager()
        {
            this._apiCaller = new ApiCaller();
        }

        public List<Vacation> GetAllVacations() 
        {
            List<Vacation> vacations = new List<Vacation>();
            //var apiVacationList = _apiCaller.GetAllVacations();

            return vacations;
        }
        //public Vacation GetVacationByUserId()
        //{
        //    return vacation;
        //}

        //public Flight GetFlightById()
        //{
        //    return flight;
        //}
        //public Plane GetPlaneById()
        //{
        //    return plane;
        //}

        public List<Hotel> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            var apiHotels = _apiCaller.GetAllHotels();

            return hotels;
        }

        //public Hotel GetHotelById()
        //{
        //    return hotel;
        //}

    }
}