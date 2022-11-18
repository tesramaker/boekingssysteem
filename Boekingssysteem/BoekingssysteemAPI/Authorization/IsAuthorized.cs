using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.Authorization
{
    public class IsAuthorized
    {
        User user;
        private BoekingssysteemContext _dbConnection;

        public IsAuthorized(User user)
        {
            this._dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
            this.user = user;
        }

        public bool AccessLevel(int accessLevel)
        {
            return false;
        }
    }
}
