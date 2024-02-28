using EmployeesCrudOp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeesCrudOp.Controllers
{
    public class EmployeesController : Controller
    {
        public EmployeeContext db = new EmployeeContext();
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new Employees();

            var items = new List<SelectListItem>
    {
        new SelectListItem { Value = "1", Text = "pappu 1" },
        new SelectListItem { Value = "2", Text = "pppu 2" },
        new SelectListItem { Value = "3", Text = "pu 3" },
        // Add more items as needed
    };

            ViewBag.SelectListItems = items;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Employees Emp)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(Emp);
                db.SaveChanges();

                return RedirectToAction("Index"); 
            }

            return View(Emp); 
        }



    }
}