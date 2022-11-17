using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boekingssysteem.ApiModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Boekingssysteem
{
    internal class ApiCaller
    {
        HttpClient client;
        Uri uri;
        public ApiCaller()
        {
            this.uri = new Uri("https://localhost:7173/");
        }

        //FLIGHT Create, read, update, delete. -COMPLETE
        //GET
        public async Task<List<FlightApiModel>> GetAllFlights()
        {
            List<FlightApiModel> flights = new List<FlightApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Flight/GetAllflights");
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        flights = System.Text.Json.JsonSerializer.Deserialize<List<FlightApiModel>>(myContent);
                    }
                }
                return flights;
            }
        }
        public async Task<List<FlightApiModel>> GetAllFlightsToCity(string location)
        {
            List<FlightApiModel> flights = new List<FlightApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Flight/GetAllFlightsToCity/" + location);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        //string myContent = await content.ReadAsStringAsync();
                        //dynamic allFlights = JsonConvert.DeserializeObject(myContent);

                        string myContent = await content.ReadAsStringAsync();
                        flights = System.Text.Json.JsonSerializer.Deserialize<List<FlightApiModel>>(myContent);
                }
                }
                return flights;
            }
        }
        public async Task<FlightApiModel> GetFlightById(int id)
        {
        FlightApiModel flight;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Flight/GetFlightById/" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {

                    string myContent = await content.ReadAsStringAsync();
                    flight = System.Text.Json.JsonSerializer.Deserialize<FlightApiModel>(myContent);
                }

                return flight;
                }
            }
        }

        //CREATE
        public async Task<bool> CreateFlight(FlightApiModel flight)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(flight);
            StringContent stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpContent httpContent = stringContent;

            HttpResponseMessage response = new HttpResponseMessage();
            using (client)
            {
                // Sends a POST request to create a vacation
                response = await client.PostAsync(this.uri + "Flight/Create", httpContent);
            }
            // Returns true if the statuscode is between 200 and 299
            return response.IsSuccessStatusCode;
        }

        //HOTEL Create, read, update, delete. -COMPLETE
        //GET
        public async Task<List<HotelApiModel>> GetAllHotels()
        {
            List<HotelApiModel> hotels = new List<HotelApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetAllHotels");
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        hotels = System.Text.Json.JsonSerializer.Deserialize<List<HotelApiModel>>(myContent);
                    }
                }
                return hotels;
            }
        }
        public async Task<List<HotelApiModel>> GetAllHotelsInCity(string location)
        {
            List<HotelApiModel> hotels = new List<HotelApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetAllHotelsIsCity/" + location);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        //string myContent = await content.ReadAsStringAsync();
                        //dynamic allHotels = JsonConvert.DeserializeObject(myContent);

                        string myContent = await content.ReadAsStringAsync();
                        hotels = System.Text.Json.JsonSerializer.Deserialize<List<HotelApiModel>>(myContent);
                    }
                }
                return hotels;
            }

        }
        public async Task<HotelApiModel> GetHotelByName(string name)
        {
            HotelApiModel hotel;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetHotelByName/" + name);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        //string myContent = await content.ReadAsStringAsync();
                        //dynamic allHotels = JsonConvert.DeserializeObject(myContent);

                        string myContent = await content.ReadAsStringAsync();
                        hotel = System.Text.Json.JsonSerializer.Deserialize<HotelApiModel>(myContent);
                    }
                }
                return hotel;
            }

        }
        public async Task<HotelApiModel> GetHotelById(int id)
        {
            HotelApiModel hotel;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetHotelById/" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {

                        string myContent = await content.ReadAsStringAsync();
                        hotel = System.Text.Json.JsonSerializer.Deserialize<HotelApiModel>(myContent);
                    }

                    return hotel;
                }
            }
        }
        //CREATE
        public async Task<bool> CreateHotel(HotelApiModel hotel)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(hotel);
            StringContent stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpContent httpContent = stringContent;

            HttpResponseMessage response = new HttpResponseMessage();
            using (client)
            {
                // Sends a POST request to create a vacation
                response = await client.PostAsync(this.uri + "Hotel/Create", httpContent);
            }
            // Returns true if the statuscode is between 200 and 299
            return response.IsSuccessStatusCode;
        }

        //PLANE Create, read, update, delete. -COMPLETE
        //GET
        public async Task<List<PlaneApiModel>> GetAllPlanes()
        {
            List<PlaneApiModel> planes = new List<PlaneApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Plane/GetAllPlanes");
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        planes = System.Text.Json.JsonSerializer.Deserialize<List<PlaneApiModel>>(myContent);
                    }
                }
                return planes;
            }
        }
        public async Task<PlaneApiModel> GetPlaneById(int id)
        {
            PlaneApiModel plane;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Plane/GetPlaneById/id?id=" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {

                        string myContent = await content.ReadAsStringAsync();
                        plane = System.Text.Json.JsonSerializer.Deserialize<PlaneApiModel>(myContent);
                    }

                    return plane;
                }
            }
        }
        //CREATE
        public async Task<bool> CreatePlane(PlaneApiModel plane)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(plane);
            StringContent stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpContent httpContent = stringContent;

            HttpResponseMessage response = new HttpResponseMessage();
            using (client)
            {
                // Sends a POST request to create a vacation
                response = await client.PostAsync(this.uri + "Plane/Create", httpContent);
            }
            // Returns true if the statuscode is between 200 and 299
            return response.IsSuccessStatusCode;
        }


        //ROOM Create, read, update, delete. -COMPLETE
        //GET
        public async Task<List<RoomApiModel>> GetAllRooms()
        {
            List<RoomApiModel> rooms = new List<RoomApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Room/GetAllRooms");
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        rooms = System.Text.Json.JsonSerializer.Deserialize<List<RoomApiModel>>(myContent);
                    }
                }
                return rooms;
            }
        }
        public async Task<List<RoomApiModel>> GetRoomsByHotelId(int id)
        {
            List<RoomApiModel> rooms = new List<RoomApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Room/GetRoomsByHotelId/" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        rooms = System.Text.Json.JsonSerializer.Deserialize<List<RoomApiModel>>(myContent);
                    }
                }
                return rooms;
            }
        }
        public async Task<RoomApiModel> GetRoomById(int id)
        {
            RoomApiModel room;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Room/GetRoomById/" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {

                        string myContent = await content.ReadAsStringAsync();
                        room = System.Text.Json.JsonSerializer.Deserialize<RoomApiModel>(myContent);
                    }

                    return room;
                }
            }
        }
        //CREATE
        public async Task<bool> CreateRoom(RoomApiModel room)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(room);
            StringContent stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpContent httpContent = stringContent;

            HttpResponseMessage response = new HttpResponseMessage();
            using (client)
            {
                // Sends a POST request to create a vacation
                response = await client.PostAsync(this.uri + "Room/Create", httpContent);
            }
            // Returns true if the statuscode is between 200 and 299
            return response.IsSuccessStatusCode;
        }


        //VACATION Create, read, update, delete. -COMPLETE
        //GET
        public async Task<List<VacationApiModel>> GetAllVacations()
        {
            List<VacationApiModel> vacations = new List<VacationApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Vacation/GetAllVacations");
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        vacations = System.Text.Json.JsonSerializer.Deserialize<List<VacationApiModel>>(myContent);
                    }
                }
                return vacations;
            }
        }
        public async Task<VacationApiModel> GetVacationById(int id)
        {
            VacationApiModel vacation;
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Vacation/GetVacationById/" + id);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {

                        string myContent = await content.ReadAsStringAsync();
                        vacation = System.Text.Json.JsonSerializer.Deserialize<VacationApiModel>(myContent);
                    }

                    return vacation;
                }
            }
        }
        //CREATE
        public async Task<bool> CreateVacation(VacationApiModel vacation)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(vacation);
            StringContent stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpContent httpContent = stringContent;

            HttpResponseMessage response = new HttpResponseMessage();
            using (client)
            {
                // Sends a POST request to create a vacation
                response = await client.PostAsync(this.uri + "Vacation/Create", httpContent);
            }
            // Returns true if the statuscode is between 200 and 299
            return response.IsSuccessStatusCode;
        }

    }
}
