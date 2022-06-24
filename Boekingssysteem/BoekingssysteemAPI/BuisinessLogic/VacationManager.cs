using BoekingssysteemAPI.DataAccessLayer;
using BoekingssysteemAPI.Model;

namespace BoekingssysteemAPI.BuisinessLogic
{
    public class VacationManager
    {
        private VacationService _vacationService;

        public VacationManager()
        {
            _vacationService = new VacationService();
        }

        public Vacation GetVacationById(int id)
        {
            return _vacationService.GetVacationById(id);
        }

        public Vacation GetVacationByUserId(int userId)
        {
            return _vacationService.GetVacationByUserId(userId);    
        }

        public List<Vacation> GetAllVacations()
        {
            return _vacationService.GetAllVacations();
        }

        public bool Create(Vacation vacation)
        {
            return _vacationService.Create(vacation);
        }

        public bool Edit(Vacation vacation)
        {
            return _vacationService.Edit(vacation);
        }

        public bool DeleteById(int id)
        {
            Vacation vacation = _vacationService.GetVacationById(id);
            return _vacationService.Delete(vacation);            
        }

        public bool Delete(Vacation vacation)
        {
            return _vacationService.Delete(vacation);
        }
    }
}
