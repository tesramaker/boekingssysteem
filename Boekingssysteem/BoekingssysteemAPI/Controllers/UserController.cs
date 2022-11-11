using BoekingssysteemAPI.BuisinessLogic;
using BoekingssysteemAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private UserManager _userManager;

        public UserController()
        {
            _userManager = new UserManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>


        // GET: api/<UserController>/GetAllUsers
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                return Ok(_userManager.GetAllUsers());
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // GET: api/<UserController>/GetUserById
        [HttpGet("GetUserById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<User>> GetUserById(int id)
        {
            try
            {
                return Ok(_userManager.GetUserById(id));
            }
            catch (Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        /// <summary>
        /// Post API requests
        /// </summary>

        // POST: api/<UserController>/Login/[Body] User
        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Guid> Login([FromBody] User user)
        {
            try
            {
                string encryptPassword = EncryptPassword(user);
                user.password = encryptPassword;
                user = _userManager.Login(user);

                if (!user.loginToken.Equals(Guid.Empty))
                {
                    user.loginToken = Guid.NewGuid();
                    if (_userManager.Edit(user))
                    {
                        return Ok(user.loginToken);
                    }
                }
                return NotFound("User not found!");
            }
            catch(Exception)
            {
                return NotFound("Something went wrong!");
            }
        }

        // POST: api/<UserController/Create/[Body] User
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Create([FromBody] User user)
        {
            try
            {
                user.loginToken = Guid.NewGuid();
                user.lastLoginDate = DateTime.Now;
                string encryptPassword = EncryptPassword(user);
                user.password = encryptPassword;

                return Ok(_userManager.Create(user));
            }
            catch
            {
                return NotFound($"Could not create account!");
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // PUT: api/<UserController/Edit/[Body] User
        [HttpPut("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Edit([FromBody] User user)
        {
            try
            {
                string encryptPassword = EncryptPassword(user);
                user.password = encryptPassword;

                return Ok(_userManager.Edit(user));
            }
            catch
            {
                return NotFound($"Could not upgrade {user.name}!");
            }
        } 

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // DELETE: api/<UserController/Delete/[Body] User
        [HttpPut("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> Delete([FromBody] User user)
        {
            try
            {
                return Ok(_userManager.Delete(user));
            }
            catch
            {
                return NotFound($"Could not delete {user.name}!");
            }
        }

        // DELETE: api/<UserController/DeleteByUserId/<id>
        [HttpPut("DeleteByUserId/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> DeleteByUserId(int id)
        {
            try
            {
                return Ok(_userManager.DeleteById(id));
            }
            catch
            {
                return NotFound("Something went wrong!");
            }
        }

        ///<summary>
        /// Other functions
        /// </summary>
        
        // Returns encrypted password
        public string EncryptPassword(User user)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(user.password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}
