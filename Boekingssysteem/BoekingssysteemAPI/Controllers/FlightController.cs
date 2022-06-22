using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private FlightManager _flightManager;

        public FlightController()
        {
            _flightManager = new FlightManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: api/<Flightcontroller>/GetAllFLights
        [HttpGet("GetAllflights")]
        public ActionResult<IEnumerable<Flight>> GetAllFLights()
        {
            return _flightManager.GetAllFlights();
        }

        // GET: api/<FlightController>/GetAllFlightsToCity/<city>
        [HttpGet("GetAllFlightsToCity/{city}")]
        public ActionResult<IEnumerable<Flight>> GetAllFlightsToCity(string city)
        {
            return _flightManager.GetAllFlightsToCity(city);
        }

        // GET: api/<FlightController>/GetFlightById/<id>
        [HttpGet("GetFlightById/{id}")]
        public ActionResult<Flight> GetFlightById(int id)
        {
            return _flightManager.GetFlightById(id);
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: api/<FlightController>/Create/[Body]<Flight>
        [HttpPost("Create new flight")]
        //[ValidateAntiForgeryToken]
        public ActionResult<bool> Create([FromBody] Flight flight)
        {
            try
            {
                return _flightManager.Create(flight);
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: api/<FlightAPIController>/Edit/[Body]<Flight>
        [HttpPut("Edit excisting flight")]
        //[ValidateAntiForgeryToken]
        public ActionResult<bool> Edit([FromBody] Flight flight)
        {
            try
            {
                _flightManager.Edit(fligth);
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>
        
        // DELETE: api/<FlightController>/DeleteFlight/<id>
        [HttpDelete("Delete/id")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
