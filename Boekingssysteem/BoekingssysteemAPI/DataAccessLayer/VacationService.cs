using BoekingssysteemAPI.DbConnection;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.DataAccessLayer
{
    public class VacationService
    {
        private BoekingssysteemContext dbConnection;

        public VacationService()
        {
            dbConnection = new BoekingssysteemContext(@"Server = localhost; Database = Boekingssysteem; Trusted_Connection = True;");
        }

        public Vacation GetVacationById(int id)
        {
            try
            {
                return dbConnection.Vacation.Single(item => item.id.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Vacation> GetVacationsByUserId(int id)
        {
            try
            {
                return dbConnection.Vacation.Where<Vacation>(item => item.userId == id).ToList<Vacation>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Vacation> GetAllVacations()
        {
            try
            {
                return dbConnection.Vacation.ToList<Vacation>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Create(Vacation vacation)
        {
            try
            {
                dbConnection.Vacation.Add(vacation);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Edit(Vacation vacation)
        {
            try
            {
                dbConnection.Vacation.Update(vacation);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Vacation vacation)
        {
            try
            {
                dbConnection.Vacation.Remove(vacation);
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

