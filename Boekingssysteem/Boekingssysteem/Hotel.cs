using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class Hotel
    {
        public int id { get; set; }
        public String name { get; set; }
        public String city { get; set; }
        public double xCoord { get; set; }
        public double yCoord { get; set; }
        public Room room { get; set; }//At this moment in time, a hotel has only one room. 
        List<Room> rooms { get; set; }//This list is not yet used

        public Hotel(string name, string city, double xCoord, double yCoord, Room room)
        {
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.room = room;
        }

        public Hotel(string name, string city, double xCoord, double yCoord, List<Room> rooms)
        {
            this.name = name;
            this.city = city;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.rooms = rooms;
        }

        public List<Room> GetListAvailableRooms()
        {
            return rooms;
        }

        public Room GetRoom()
        {
            return this.room;
        }

        public Room GetRoomById(int id)
        {
            foreach(Room value in this.rooms)
            {
                if(value.id == id)
                {
                    return value;
                }
            }
            return null;
        }
    }
}