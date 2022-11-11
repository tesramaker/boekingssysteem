using BoekingssysteemAPI.Authorization;
using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class UserService
    {
        private BoekingssysteemContext dbConnection;

        public UserService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return dbConnection.User.ToList<User>();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public User GetUsersById(int id)
        {
            try
            {
                return dbConnection.User.Single<User>(item => item.id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User Login(User user)
        {
            try
            {
                User tempUser = new User();
                tempUser = dbConnection.User.Single<User>(item => item.name == user.name && item.password == user.password);
                return tempUser;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                return dbConnection.User.Single<User>(item => item.id.Equals(id));
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Create(User user)
        {
            try
            {
                dbConnection.User.Add(user);
                dbConnection.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Edit(User user)
        {
            try
            {
                dbConnection.User.Update(user);
                dbConnection.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Delete(User user)
        {
            try
            {
                dbConnection.User.Remove(user);
                dbConnection.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
