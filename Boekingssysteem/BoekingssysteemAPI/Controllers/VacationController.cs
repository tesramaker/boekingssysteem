using BoekingssysteemAPI.BuisinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoekingssysteemAPI.Controllers
{
    public class VacationController : Controller
    {
        private VacationManager _vacationManager;

        public VacationController()
        {
            _vacationManager = new VacationManager();
        }

        /// <summary>
        /// Get API requests
        /// </summary>

        // GET: VacationController
        [HttpGet]
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// POST API requests
        /// </summary>

        // POST: VacationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// PUT API requests
        /// </summary>

        // POST: VacationController/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// DELETE API requests
        /// </summary>

        // DELETE: VacationController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
