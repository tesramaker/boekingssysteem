using BoekingssysteemAPI.Views;
using System.Data.Common;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class VacationService
    {
        private DbConnection _dbConnection;

        public VacationService()
        {
            //_dbConnection = new DbConnection
        }

        public Vacation GetVacationById(int id)
        {
            return new Vacation();
        }
        public Vacation GetVacationByUserId(int userId)
        {
            return new Vacation();
        }
    }
}
