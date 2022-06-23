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

        public Room GetRoomById(int id)
        { 
            return _roomService.GetRoomById(id); 
        }

        public List<Room> GetRoomsByHotelId(int id)
        { 
            return _roomService.GetRoomsByHotelId(id); 
        }

        public bool Create(Room room)
        {
            return _roomService.Create(room); 
        }

        public bool Edit(Room room)
        { 
            return _roomService.Edit(room); 
        }

        public bool Delete(Room room)
        { 
            return _roomService.Delete(room); 
        }

        public bool DeleteById(int id)
        {
            var room = _roomService.GetRoomById(id);
            return _roomService.Delete(room);
        }
    }
}

