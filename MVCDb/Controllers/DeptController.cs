using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCDb.Models;

namespace MVCDb.Controllers
{
    public class DeptController : Controller
    {
        IDept repos;
        /*DB1045Context db=new DB1045Context();*/
        public DeptController(IDept _repos)
        {
            repos=_repos;
        }

        public IActionResult List()
        {
			try
			{
                var data = repos.GetAllDepts();
                return View(data);
            }
			catch (Exception ex)
			{
                ViewBag.ExceptionMessage = ex.Message;
                return View("Error");
			}
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
			try
			{
                if (ModelState.IsValid)
                {
                    repos.AddDept(dept);
                    return RedirectToAction("List");
                }
                return View(dept);
            }
            catch(Exception e)
			{
                ViewBag.ExceptionMessage=e.InnerException.Message;
                return View("Error");
			}
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
        
        /*public JsonResult DuplicateDept(int id)
        {
            bool yesno = db.Depts.Any(e => e.Id == id);
            
            return Json(!yesno);
        }*/
    }

}
