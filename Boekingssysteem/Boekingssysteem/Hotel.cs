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
        public Room room { get; set; }//At this moment in time, a hotel has only one room. 
        List<Room> rooms;//This list is not yet used

        public Hotel(string name, string city, double xCoord, double yCoord, Room room)
        {
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.room = room;
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