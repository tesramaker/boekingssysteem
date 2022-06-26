using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

                        Plane plane = new Plane(json["id"].Value<int>(), json["airline"].Value<string>(), json["seats"].Value<int>(), 0);
                        return plane;
                    }
                }
            }
            
        }
    }
}
