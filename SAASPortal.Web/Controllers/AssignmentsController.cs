using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAASPortal.Core.Interfaces;

namespace SAASPortal.Web.Controllers
{
    public class AssignmentsController : Controller
    {
        private readonly IAssignmentService _assignmentService;

        // GET: AssignmentsController

        public AssignmentsController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }
        public async Task<IActionResult> Index()
        {
            var assignments = await _assignmentService.GetAllAssignmentsAsync();
            return View(assignments);
        }

        // GET: AssignmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssignmentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssignmentsController/Create
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

        // GET: AssignmentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssignmentsController/Edit/5
        [HttpPost]
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

        // GET: AssignmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssignmentsController/Delete/5
        [HttpPost]
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
