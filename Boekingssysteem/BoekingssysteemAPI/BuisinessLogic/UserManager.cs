using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class UserManager
    {
        private UserService _userService;

        public UserManager()
        {
            _userService = new UserService();
        }

        public User Login(User user)
        {
            return _userService.Login(user);
        }

        public bool Create(User user)
        {
            return _userService.Create(user);
        }

        public bool Edit(User user)
        {
            return _userService.Edit(user);
        }

        public bool DeleteById(int id)
        {
            User user = _userService.GetUserById(id);
            return _userService.Delete(user);
        }

        public bool Delete(User user)
        {
            return _userService.Delete(user);
        }
    }
}
