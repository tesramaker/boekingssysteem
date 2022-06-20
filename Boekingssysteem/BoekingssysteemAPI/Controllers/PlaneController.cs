using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class PlaneController : Controller
    {
        private PlaneManager _planeManager;

        public PlaneController()
        {
            _planeManager = new PlaneManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: PlaneController
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult<List<Plane>> GetFlightToCity([FromBody] string city)
        {
            return _planeManager.GetFlightToCity(city);
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: PlaneController/Create
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
        
        // POST: PlaneController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
        /// DELETE API requests
        /// </summary>

        // POST: PlaneController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
