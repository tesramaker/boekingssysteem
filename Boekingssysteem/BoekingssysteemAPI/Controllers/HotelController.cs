using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        [HttpGet("Get All Hotels Near {city}")]
        //[ValidateAntiForgeryToken]
        public ActionResult<IEnumerable<Hotel>> GetAllHotelsNearCity(string city)
        {
            return _hotelManager.GetAllHotelsNearCity(city);
        }

        // GET: HotelController/Details/5
        [HttpGet("Get Hotel by {id}")]
        //[ValidateAntiForgeryToken]
        public ActionResult<Hotel> GetHotelById(int id)
        {
            return new Hotel();
        }

        /// <summary>
        /// POST API requests
        /// </summary>
        
        // POST: HotelController/Create
        [HttpPost("Create new hotel")]
        //[ValidateAntiForgeryToken]
        public ActionResult<Hotel> Create(IFormCollection collection)
        {
            try
            {
                return new Hotel();
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: FlightAPIController/Edit/5
        [HttpPut("Edit excisting hotel")]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // DELETE: HotelController/Delete/5
        [HttpDelete("Delete hotel")]
        //[ValidateAntiForgeryToken]
        public ActionResult<bool> Delete(int id, IFormCollection collection)
        {
            try
            {
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
