using Microsoft.AspNetCore.Mvc;
using MVCDb.Models;

namespace MVCDb.Controllers
{
    public class DeptController : Controller
    {
        IDept repos;
        public DeptController(IDept _repos)
        {
            repos=_repos;
        }

        public IActionResult List()
        {
            var data =repos.GetAllDepts();
            return View(data);
        }
        public IActionResult Display(int id)
		{
            var data=repos.FindDept(id);
            return View(data);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Create(Dept dept)
        {
			if (ModelState.IsValid)
			{
                repos.AddDept(dept);
                return RedirectToAction("List");
			}
            return View(dept);
        }

		[HttpGet]
        public IActionResult Edit(int id)
		{
            var data = repos.FindDept(id);
            return View();
		}

        [HttpPost]
        public IActionResult Edit(Dept dept)
        {
			if (ModelState.IsValid)
			{
                repos.EditDept(dept);
                return RedirectToAction("List");
			}
            return View(dept);
        }

		[HttpGet]
        public IActionResult Delete(int id)
		{
            var data = repos.FindDept(id);
            return View(data);
		}

		[HttpPost]
        public IActionResult Delete(Dept dept)
        {
            repos.DeleteDept(dept.Id);
            return RedirectToAction("List");
        }

    }

}
