using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
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

        // GET: api/<HotelController>/GetAllHotelsInCity/<city>
        [HttpGet("GetAllHotelsIsCity/{city}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Hotel>> GetAllHotelsInCity(string city)
        {
            try
            {
                return Ok(_hotelManager.GetAllHotelsInCity(city));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<HotelController>/GetHotelById/{id}
        [HttpGet("GetHotelById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Hotel> GetHotelById(int id)
        {
            try
            {
                return Ok(_hotelManager.GetHotelById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // Get: api/<HotelController>/GetHotelByName/{name}
        [HttpGet("GetHotelByName/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Hotel> GetHotelByName(string name)
        {
            try
            {
                return Ok(_hotelManager.GetHotelByName(name));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: api/<HotelController>/Create/[Body]<Hotel>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Hotel hotel)
        {
            try
            {
                return Ok(_hotelManager.Create(hotel));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: api/<HotelController>/Edit/[body]Hotel
        [HttpPut("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Edit([FromBody] Hotel hotel)
        {
            try
            {
                return Ok(_hotelManager.Edit(hotel));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // DELETE: api/<HotelController>/DeleteById/{id}
        [HttpDelete("DeleteHotelById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> DeleteById(int id)
        {
            try
            {
                return Ok(_hotelManager.DeleteById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        //DELETE: api/<HotelController>/Delete/[Body] hotel
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Delete([FromBody] Hotel hotel)
        {
            try
            {
                return Ok(_hotelManager.Delete(hotel));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }
    }
}
