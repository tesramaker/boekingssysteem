using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
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

        //TODO Add ProducesResponseTypes AND handeling of them

        // GET: PlaneController
        [HttpGet("GetPlaneById/id")]
        public ActionResult<Plane> GetPlaneById(int id)
        {
            return _planeManager.GetPlaneById(id);
        }

        /// <summary>
        /// POST API requests
        /// </summary>
        
        // POST: api/<PlaneController/<Plane>
        [HttpPost("CreatePlane")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Plane plane)
        {
            try
            {
                return _planeManager.Create(plane);
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>
        
        // POST: PlaneController/Edit/5
        [HttpPut("EditPlane")]
        public ActionResult<bool> Edit([FromBody] Plane plane)
        {
            try
            {
                return _planeManager.Edit(plane);
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // POST: PlaneController/Delete/5
        [HttpDelete("delete/id")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                return _planeManager.Delete(id);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
