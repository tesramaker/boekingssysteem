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

        public async Task<List<Flight>> GetAllFlights()
        {
            List<Flight> flights = new List<Flight>();
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
                        dynamic allFlights = JsonConvert.DeserializeObject(myContent);

                        for(int i = 0; i < allFlights.Count; i++)
                        {
                            var _flight = allFlights[i];
                            var jsonPlane = (JObject)_flight;

                            Plane p = await this.getPlaneById(jsonPlane["planeId"].Value<int>());
                            Flight flight = new Flight(jsonPlane["id"].Value<int>(), p, jsonPlane["cost"].Value<double>(), jsonPlane["fromLocation"].Value<string>(), jsonPlane["departDate"].Value<DateTime>(), jsonPlane["toLocation"].Value<string>(), jsonPlane["arrivalDate"].Value<DateTime>(), 0);
                            flights.Add(flight);
                        }
                    }
                }
                return flights;
            } 
        }

        public async Task<List<Flight>> GetAllFlightsToCity(string location)
        {
            List<Flight> flights = new List<Flight>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Flight/GetAllFlightsToCity/" + location);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        dynamic allFlights = JsonConvert.DeserializeObject(myContent);

                        for (int i = 0; i < allFlights.Count; i++)
                        {
                            var _flight = allFlights[i];
                            var jsonPlane = (JObject)_flight;

                            Plane p = await this.getPlaneById(jsonPlane["planeId"].Value<int>());
                            Flight flight = new Flight(jsonPlane["id"].Value<int>(), p, jsonPlane["cost"].Value<double>(), jsonPlane["fromLocation"].Value<string>(), jsonPlane["departDate"].Value<DateTime>(), jsonPlane["toLocation"].Value<string>(), jsonPlane["arrivalDate"].Value<DateTime>(), 0);
                            flights.Add(flight);
                        }
                    }
                }
                return flights;
            }
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
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
                        dynamic allHotels = JsonConvert.DeserializeObject(myContent);

                        for (int i = 0; i < allHotels.Count; i++)
                        {
                            var _hotel = allHotels[i];
                            var jsonHotel = (JObject)_hotel;

                            Hotel hotel = new Hotel(jsonHotel["name"].Value<string>(), jsonHotel["city"].Value<string>(), 0, 0, new Room(0, 0, 0, 0, 0));
                            hotels.Add(hotel);
                        }
                    }
                }
                return hotels;
            }

        }

        public async Task<List<Hotel>> GetAllHotelsByCity(string location)
        {
            List<Hotel> hotels = new List<Hotel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetAllHotelsIsCity/" + location);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        dynamic allHotels = JsonConvert.DeserializeObject(myContent);

                        for (int i = 0; i < allHotels.Count; i++)
                        {
                            var _hotel = allHotels[i];
                            var jsonHotel = (JObject)_hotel;

                            Hotel hotel = new Hotel(jsonHotel["name"].Value<string>(), jsonHotel["city"].Value<string>(), 0, 0, new Room(0, 0, 0, 0, 0));
                            hotels.Add(hotel);
                        }
                    }
                }
                return hotels;
            }

        }


        public async Task<Plane> getPlaneById(int id)
        {

            HttpClient client = new HttpClient();
            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Plane/GetPlaneById/id?id="+id.ToString());
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();

                        var json = (JObject)JsonConvert.DeserializeObject(myContent);

                        //int _id = json["id"].Value<int>();
                        //var _airline = json["airline"].Value<string>();
                        //var _seats = json["seats"].Value<int>();

                        Plane plane = new Plane(json["id"].Value<int>().ToString(), json["airline"].Value<string>(), json["seats"].Value<int>(), 0);
                        return plane;
                    }
                }
            }
            
        }

        public async Task<List<HotelApiModel>> GetHotelsByCity(string city)
        {
            List<HotelApiModel> hotels = new List<HotelApiModel>();
            HttpClient client = new HttpClient();

            using (client)
            {
                HttpResponseMessage response = await client.GetAsync(this.uri + "Hotel/GetAllHotelsIsCity/" + city);
                using (response)
                {
                    HttpContent content = response.Content;
                    using (content)
                    {
                        string myContent = await content.ReadAsStringAsync();

                        // Creates a list of HotelApiModel objects based on the incoming JSON response
                        hotels = System.Text.Json.JsonSerializer.Deserialize<List<HotelApiModel>>(myContent);
                    }
                }
                return hotels;
            }
        }

        public async Task<bool> CreateVacation(VacationApiModel vacation)
        {
            HttpClient client = new HttpClient();

            // Turnes a Object into a JSON string
            string json = JsonConvert.SerializeObject(vacation);
            // Creates a stringContent class which is used in a HttpContent object
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
