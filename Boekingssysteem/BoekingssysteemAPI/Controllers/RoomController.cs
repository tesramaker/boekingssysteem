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

        /// <summary>
        /// Get API requests
        /// </summary>
        
        // Get: api/<HotelController>/GetAllRooms
        [HttpGet("GetAllRooms")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Room>> GetAllRooms()
        {
            try
            {
                return Ok(_roomManager.GetAllRooms());
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // Get: api/<HotelController>/GetRoomById/{id}
        [HttpGet("GetRoomById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Room>> GetRoomById(int id)
        {
            try
            {
                return Ok(_roomManager.GetRoomById(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // Get: api/<HotelController>/GetRoomsByHotelId/{id}
        [HttpGet("GetRoomsByHotelId/{id}")]
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

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: api/<RoomController>/Create/[Body]<Room>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Room room)
        {
            try
            {
                return Ok(_roomManager.Create(room));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: api/<RoomController>/Edit/[Body]<Room>
        [HttpPut("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Edit([FromBody] Room room)
        {
            try
            {
                return Ok(_roomManager.Edit(room));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // DELETE: api/<RoomController>/DeleteById/<id>
        [HttpDelete("DeleteById/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> DeleteById(int id)
        {
            try
            {
                return Ok(_roomManager.DeleteById(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // DELETE: api/<RoomController>/DeleteFlight/[Body] Room
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Delete([FromBody] Room room)
        {
            try
            {
                return Ok(_roomManager.Delete(room));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }
    }
}
