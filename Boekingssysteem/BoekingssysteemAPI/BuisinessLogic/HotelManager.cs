using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

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

        public List<Hotel> GetAllHotelsNearCity(string city)
        {
            return _hotelService.GetAllHotelsNearCity(city);
        }
    }
}
