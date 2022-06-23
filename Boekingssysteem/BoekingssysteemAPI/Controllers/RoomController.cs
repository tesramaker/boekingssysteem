using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {
        private RoomManager _roomManager;

        public RoomController()
        {
            _roomManager = new RoomManager();
        }


        // Get: api/<HotelController>/GetRoomsByHotelId/{id}
        [HttpGet("GetRoomByHotelId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Room>> GetRoomsByHotelId(int id)
        {
            try
            {
                return Ok(_roomManager.GetRoomsByHotelId(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }
    }
}
