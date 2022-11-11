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

        public Hotel GetHotelById(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        public Hotel GetHotelByName(string name)
        {
            return _hotelService.GetHotelByName(name);
        }

        public List<Hotel> GetAllHotelsInCity(string city)
        {
            return _hotelService.GetAllHotelsInCity(city);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelService.GetAllHotels();
        }

        public bool Create(Hotel hotel)
        {
            return _hotelService.Create(hotel);
        }

        public bool Edit(Hotel hotel)
        {
            return _hotelService.Edit(hotel);
        }

        public bool DeleteById(int id)
        {
            Hotel hotel = _hotelService.GetHotelById(id);
            return _hotelService.Delete(hotel); 

        }

        public bool Delete(Hotel hotel)
        {
            return _hotelService.Delete(hotel);
        }
    }
}
