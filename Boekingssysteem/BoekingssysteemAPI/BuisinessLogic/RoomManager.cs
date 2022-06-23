using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class RoomManager
    {
        private RoomService _roomService;

        public RoomManager()
        {
            _roomService = new RoomService();
        }

        public List<Room> GetRoomsByHotelId(int id)
        {
            return _roomService.GetRoomsByHotelId(id);
        }

        public bool Create(Room room)
        {
            return _roomService.Create(room);
        }
    }
}

