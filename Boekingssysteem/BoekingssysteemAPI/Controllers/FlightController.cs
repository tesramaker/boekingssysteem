using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class FlightController : Microsoft.AspNetCore.Mvc.Controller
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
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult<List<Flight>> GetAllFlights()
        {
            return _flightManager.GetAllFLights();
        }

        // GET: FlightAPIController/Details/5
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult GetFlightById(int id)
        {
            return View();
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: FlightAPIController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: FlightAPIController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int id)
        {
            return View();
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteFlightById(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
