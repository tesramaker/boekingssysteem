using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.Authorization
{
    static public class IsLoggedIn
    {
        static private BoekingssysteemContext dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");

        static public bool LoginTokenCheck(string username, Guid loginToken)
        {
            try
            {
                if(dbConnection.User.Single<User>(item => item.name == username && item.loginToken == loginToken) != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
