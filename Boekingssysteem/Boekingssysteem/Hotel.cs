using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    internal class Hotel
    {
        public String name { get; set; }
        public String city { get; set; }
        double xCoord;
        double yCoord;
        Room room;
        List<Room> rooms;

        public Hotel(string name, string city, double xCoord, double yCoord, List<Room> rooms)
        {
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.rooms = rooms;
        }

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