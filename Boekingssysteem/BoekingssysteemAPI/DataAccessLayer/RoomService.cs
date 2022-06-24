using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class RoomService
    {
        private BoekingssysteemContext dbConnection;

        public RoomService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public Room GetRoomById(int id)
        {
            try
            {
                return dbConnection.Room.Single<Room>(item => item.id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Room> GetRoomsByHotelId(int id)
        {
            try
            {
                return dbConnection.Room.Where<Room>(item => item.hotelId == id).ToList<Room>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Create(Room room)
        {
            try
            {
                dbConnection.Room.Add(room);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Edit(Room room)
        {
            try
            {
                dbConnection.Room.Update(room);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Room room)
        {
            try
            {
                dbConnection.Room.Remove(room);
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
