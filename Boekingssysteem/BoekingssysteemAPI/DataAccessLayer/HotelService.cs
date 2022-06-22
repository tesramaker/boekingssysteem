using BoekingssysteemAPI.Model;
using System.Data.Common;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class HotelService
    {
        //private DbConnect _dbConnect;
    
        public HotelService()
        {
           //_dbConnect = new DbConnect();
        }

        public List<Hotel> GetAllHotelsNearCity(string name)
        {
            return new List<Hotel>();
        }

        public Hotel GetHotelByName(string name)
        {
            return new Hotel();
        }
    }
}
