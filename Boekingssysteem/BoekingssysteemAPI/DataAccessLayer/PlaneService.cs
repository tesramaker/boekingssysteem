using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;
using System.Data.Common;


namespace BoekingssysteemAPI.DataAccessLayer
{
    public class PlaneService
    {
        private BoekingssysteemContext dbConnection;

        public PlaneService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public Plane GetPlaneById(int id)
        {
            try
            {
                 return dbConnection.Plane.Single(item => item.id.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Create(Plane plane)
        {
            try
            {
                dbConnection.Plane.Add(plane);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Edit(Plane plane)
        {
            try
            {
                dbConnection.Plane.Update(plane);
                dbConnection.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Delete(Plane plane)
        {
            try
            {
                dbConnection.Plane.Remove(plane);
                dbConnection.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
