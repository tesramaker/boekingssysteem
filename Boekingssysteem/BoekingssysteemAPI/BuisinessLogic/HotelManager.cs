﻿using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Views;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class HotelManager
    {
        private HotelService _hotelService;

        public HotelManager()
        {
            _hotelService = new HotelService();
        }

        public Hotel GetHotelByName(string name)
        {
            return _hotelService.GetHotelByName(name);
        }

        public List<Hotel> GetAllHotelNearCity(string city)
        {
            return _hotelService.GetAllHotelNearCity(city);
        }
    }
}
