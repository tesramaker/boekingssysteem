using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        private Manager _manager = new Manager();
        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: FlightAPIController
        public ActionResult<List<Flight>> GetAllFlights()
        {
            return _manager.GetAllFLights();
        }

        // GET: FlightAPIController/Details/5
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
        public ActionResult CreateNewFlight(IFormCollection collection)
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
        public ActionResult Edit(int id)
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
