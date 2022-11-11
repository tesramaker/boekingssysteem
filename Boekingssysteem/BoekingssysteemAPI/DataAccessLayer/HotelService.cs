using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class HotelService
    {
        private BoekingssysteemContext dbConnection;

        public HotelService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public List<Hotel> GetAllHotels()
        {
            try
            {
                return dbConnection.Hotel.ToList<Hotel>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Hotel GetHotelById(int id)
        {
            try
            {
                return dbConnection.Hotel.Single<Hotel>(item => item.id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Hotel> GetAllHotelsInCity(string city)
        {
            try
            {
                return dbConnection.Hotel.Where(item => item.city == city).ToList<Hotel>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Hotel GetHotelByName(string name)
        {
            try
            {
                return dbConnection.Hotel.Single<Hotel>(item => item.name == name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Create(Hotel hotel)
        {
            try
            {
                dbConnection.Hotel.Add(hotel);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Edit(Hotel hotel)
        {
            try
            {
                dbConnection.Hotel.Update(hotel);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Hotel hotel)
        {
            try
            {
                dbConnection.Hotel.Remove(hotel);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
