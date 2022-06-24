using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        // GET: api/<PlaneController>/GetPlaneById/id
        [HttpGet("GetPlaneById/id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Plane> GetPlaneById(int id)
        {
            try
            {
                return Ok(_planeManager.GetPlaneById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// POST API requests
        /// </summary>
        
        // POST: api/<PlaneController>/Create/[Body] Plane
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Plane plane)
        {
            try
            {
                return Ok(_planeManager.Create(plane));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>
        
        // POST: PlaneController/Edit/[body]Hotel
        [HttpPut("EditPlane")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Edit([FromBody] Plane plane)
        {
            try
            {
                return Ok(_planeManager.Edit(plane));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // POST: PlaneController/DeleteById/id
        [HttpDelete("DeleteById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> DeleteById(int id)
        {
            try
            {
                return Ok(_planeManager.DeleteById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }        
        
        // POST: PlaneController/Delete/[body] Plane
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Delete([FromBody] Plane plane)
        {
            try
            {
                return Ok(_planeManager.Delete(plane));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }
    }
}
