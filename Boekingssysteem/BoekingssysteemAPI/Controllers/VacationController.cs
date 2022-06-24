using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacationController : Controller
    {
        private VacationManager _vacationManager;

        public VacationController()
        {
            _vacationManager = new VacationManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: api/<VacationController>/GetVacationById/<id>
        [HttpGet("GetVacationById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Vacation> GetVacationById(int id)
        {
            try
            {
                return Ok(_vacationManager.GetVacationById(id));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<VacationController>/GetVacationsByUserId/<id>
        [HttpGet("GetVacationsByUserId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Vacation> GetVacationsByUserId(int id)
        {
            try
            {
                return Ok(_vacationManager.GetVacationsByUserId(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<VacationController>/GetAllVacations
        [HttpGet("GetAllVacations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Vacation> GetAllVacations()
        {
            try
            {
                return Ok(_vacationManager.GetAllVacations());
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: api/<VacationController>/Create/[Body]<Hotel>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] Vacation vacation)
        {
            try
            {
                return Ok(_vacationManager.Create(vacation));
            }
            catch(Exception)
            {
                return NotFound("Something went wrong");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // POST: api/<VacationController>/Edit/[Body]<Hotel>
        [HttpPut("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Edit([FromBody] Vacation vacation)
        {
            try
            {
                return Ok(_vacationManager.Edit(vacation));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong");
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // POST: api/<VacationController>/Delete/{id}
        [HttpDelete("DeleteById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(_vacationManager.DeleteById(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong");
            }
        }


        // POST: api/<VacationController>/Delete/[Body]<Hotel>
        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete([FromBody] Vacation vacation)
        {
            try
            {
                return Ok(_vacationManager.Delete(vacation));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong");
            }
        }
    }
}
