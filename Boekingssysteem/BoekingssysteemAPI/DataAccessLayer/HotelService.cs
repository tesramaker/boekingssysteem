using BoekingssysteemAPI.Views;
using System.Data.Common;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class HotelService
    {
        private DbConnection _dbConnect;
    
        public HotelService()
        {
           // _dbConnect = new DbConnection();
        }

        public List<Hotel> GetAllHotelNearCity()
        {
            return new List<Hotel>();
        }
    }
}
