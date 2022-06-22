using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;
using System.Linq;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class FlightService
    {
        private BoekingssysteemContext dbConnection;

        public FlightService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public List<Flight> GetAllFlightsToCity(string city)
        {
            try
            {
                // TODO This needs to be tested
                return dbConnection.Flight.Where<Flight>(item => item.toLocation == city).ToList<Flight>();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public Flight GetFlightById(int id)
        {
            try
            {
                return dbConnection.Flight.Single<Flight>(item => item.id == id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<Flight> GetAllFlights()
        {
            try
            {
                return dbConnection.Flight.ToList<Flight>();
            }
        }
        //TODO create update and delete
    }
}
