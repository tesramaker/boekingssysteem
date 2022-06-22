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

        public bool Create(IFormCollection collection)
        {
            //TODO Create Create methode in _vacationService
            //_vacationService.Create(collection);
            return true;
        }
    }
}
