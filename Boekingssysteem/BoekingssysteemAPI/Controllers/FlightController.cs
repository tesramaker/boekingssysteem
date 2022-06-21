using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Views;
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

        // GET: FlightAPIController
        [HttpGet("Get All flights to {city}")]
        //[ValidateAntiForgeryToken]
        public ActionResult<List<Flight>> GetAllFlightsToCity(string city)
        {
            return _flightManager.GetAllFlightsToCity(city);
        }

        // GET: FlightAPIController/Details/5
        [HttpGet("Get Flight by {id}")]
        //[ValidateAntiForgeryToken]
        public ActionResult<Flight> GetFlightById(int id)
        {
            return new Flight();
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: FlightAPIController/Create
        [HttpPost("Create new flight")]
        //[ValidateAntiForgeryToken]
        public ActionResult<Flight> Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return new Flight();
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: FlightAPIController/Edit/5
        [HttpPut("Edit excisting flight")]
        //[ValidateAntiForgeryToken]
        public ActionResult<Flight> Edit(int id)
        {
            return new Flight();
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        [HttpDelete("Delete flight")]
        //[ValidateAntiForgeryToken]
        public ActionResult<bool> DeleteFlightById(int id, IFormCollection collection)
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
