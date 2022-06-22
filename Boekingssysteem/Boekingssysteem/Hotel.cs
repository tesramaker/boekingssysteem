using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Hotel
    {
        String name;
        String city;
        double xCoord;
        double yCoord;
        Room room;
        List<Room> rooms;

    public Room GetRoom()
        {
            return room;
        }

        public List<Room> GetListAvailableRooms()
        {
            return rooms;
        }
    }
}
