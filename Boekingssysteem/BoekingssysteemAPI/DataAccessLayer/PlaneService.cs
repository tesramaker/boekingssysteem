using System.Data.Common;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class PlaneService
    {
        private DbConnect _dbConnection;

        public PlaneService()
        {
            _dbConnection = new DbConnect();
        }
    }
}
