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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Flight>> GetAllFLights()
        {
            try
            {
                return Ok(_flightManager.GetAllFlights());
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<FlightController>/GetAllFlightsToCity/<city>
        [HttpGet("GetAllFlightsToCity/{city}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Flight>> GetAllFlightsToCity(string city)
        {
            try
            {
                return Ok(_flightManager.GetAllFlightsToCity(city));
            }
            catch(Exception)
            {

                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<FlightController>/GetFlightById/<id>
        [HttpGet("GetFlightById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Flight> GetFlightById(int id)
        {
            try
            {
                return Ok(_flightManager.GetFlightById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: api/<FlightController>/Create/[Body]<Flight>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Flight flight)
        {
            try
            {
                return Ok(_flightManager.Create(flight));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: api/<FlightAPIController>/Edit/[Body]<Flight>
        [HttpPut("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Edit([FromBody] Flight flight)
        {
            try
            {
                return Ok(_flightManager.Edit(flight));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>
        
        // DELETE: api/<FlightController>/DeleteById/<id>
        [HttpDelete("DeleteById/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> DeleteById(int id)
        {
            try
            {
                return Ok(_flightManager.DeleteById(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // DELETE: api/<FlightController>/DeleteFlight/[Body] Flight
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Delete([FromBody] Flight flight)
        {
            try
            {
                return Ok(_flightManager.Delete(flight));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }
    }
}
