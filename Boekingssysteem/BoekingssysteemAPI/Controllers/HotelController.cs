using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class HotelController : Controller
    {
        private HotelManager _hotelManager;

        public HotelController()
        {
            _hotelManager = new HotelManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: GetAllHotelsNearCity
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult<Hotel> GetAllHotelsNearCity(string city)
        {
            return _hotelManager.GetAllHotelNearCity(city);
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// POST API requests
        /// </summary>
        
        // POST: HotelController/Create
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

        // DELETE: HotelController/Delete/5
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
