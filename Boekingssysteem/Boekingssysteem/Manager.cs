using Boekingssysteem.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class Manager
    {
        private readonly ApiCaller _apiCaller;

        public Manager()
        {
            this._apiCaller = new ApiCaller();
        }

        public List<Vacation> GetAllVacations() 
        {
            //TODO : Continue making objects in the Manager class
            List<Vacation> vacations = new List<Vacation>();
            //var apiVacationList = _apiCaller.GetAllVacations();

            return vacations;
        }
        //public Vacation GetVacationByUserId()
        //{
        //    return vacation;
        //}

        public async Task<List<Flight>> GetAllFlights()
        {
            List<Flight> flights = new List<Flight>();
            List<FlightApiModel> flightApiModels = await _apiCaller.GetAllFlights();

            foreach (FlightApiModel flightApiModel in flightApiModels)
            {
                flights.Add(await this.GetFlightById(flightApiModel.id));
            }
            return flights;
        }

        public async Task<List<Flight>> GetAllFlightsToCity(string location)
        {
            List<Flight> flights = new List<Flight>();
            List<FlightApiModel> flightApiModels = await _apiCaller.GetAllFlightsToCity(location);

            foreach(FlightApiModel flightApiModel in flightApiModels)
            {
                flights.Add(await this.GetFlightById(flightApiModel.id));
            }
            return flights;
        }

        public async Task<Flight> GetFlightById(int id)
        {
            FlightApiModel flightApiModel = await _apiCaller.GetFlightById(id);
            List<PlaneApiModel> planeApiModels = await _apiCaller.GetAllPlanes();
            int planeId = 0;

            foreach(PlaneApiModel planeApiModel in planeApiModels)
            {
                if(planeApiModel.id == flightApiModel.planeId)
                {
                    planeId = planeApiModel.id;
                }
            }

            Flight flight = new(flightApiModel.id, await this.GetPlaneById(planeId), flightApiModel.cost ,flightApiModel.fromLocation, flightApiModel.departDate, flightApiModel.toLocation, flightApiModel.arrivalDate);
            return flight;
        }

        /// <summary>
        /// Planes
        /// </summary>

        public async Task<List<Plane>> GetAllPlanes()
        {
            List<Plane> planes = new List<Plane>();
            List<PlaneApiModel> planeApiModels = await _apiCaller.GetAllPlanes();

            foreach (PlaneApiModel planeApiModel in planeApiModels)
            {
                planes.Add(await this.GetPlaneById(planeApiModel.id));
            }
            return planes;
        }

        public async Task<Plane> GetPlaneById(int id)
        {
            PlaneApiModel planeApiModel = await _apiCaller.GetPlaneById(id);
            Plane plane = new(planeApiModel.name, planeApiModel.airline, planeApiModel.seats, planeApiModel.defaultAmountSeats);
            return plane;
        }

        /// <summary>
        /// Hotels
        /// </summary>

        public async Task<List<Hotel>> GetHotelByCity(string city)
        {
            List<Hotel> hotels = new List<Hotel>();
            List<RoomApiModel> roomsApiModels = await _apiCaller.GetAllRooms();
            List<HotelApiModel> hotelApiModels = await _apiCaller.GetAllHotelsInCity(city);

            foreach (HotelApiModel hotelApiModel in hotelApiModels)
            {
                List<Room> rooms = new List<Room>();
                foreach (RoomApiModel roomApiModel in roomsApiModels)
                {
                    if (hotelApiModel.id != null)
                    {
                        hotels.Add(await this.GetHotelById((int)hotelApiModel.id));
                    }
                }
            }
            return hotels;
        }
        
        public async Task<List<Hotel>> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            List<RoomApiModel> roomsApiModels = await _apiCaller.GetAllRooms();
            List<HotelApiModel> hotelApiModels = await _apiCaller.GetAllHotels();

            foreach (HotelApiModel hotelApiModel in hotelApiModels)
            {
                hotels.Add(await this.GetHotelById(hotelApiModel.id));
            }
            return hotels;
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            HotelApiModel hotelApiModel = await _apiCaller.GetHotelById(id);
            List<RoomApiModel> roomsApiModels = await _apiCaller.GetAllRooms();
            List<Room> rooms = new List<Room>();

            foreach (RoomApiModel roomApiModel in roomsApiModels)
            {
                if (roomApiModel.hotelId == hotelApiModel.id)
                {
                    rooms.Add(await this.GetRoomById(roomApiModel.id));
                }
            }

            return new Hotel(
                hotelApiModel.id,
                hotelApiModel.name,
                hotelApiModel.city,
                hotelApiModel.xCoord,
                hotelApiModel.yCoord,
                rooms
            );
        }

        /// <summary>
        /// Rooms
        /// </summary>

        public async Task<List<Room>> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            List<RoomApiModel> roomApiModels = await _apiCaller.GetAllRooms();
            
            foreach(RoomApiModel roomApiModel in roomApiModels)
            {
                rooms.Add(await this.GetRoomById(roomApiModel.id));
            }
            return rooms;
        }

        public async Task<Room> GetRoomById(int id)
        {
            RoomApiModel roomApiModel = await _apiCaller.GetRoomById(id);
            Room room = new(
                roomApiModel.id, 
                roomApiModel.roomNumber, 
                roomApiModel.amountOfPeople, 
                (double) roomApiModel.price, 
                roomApiModel.typeOfRoom
            );
            
            return room;
        }
    }
}