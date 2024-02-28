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

            model.EmployeeType = new List<SelectListItem>
    {
        new SelectListItem { Text = "FrontEnd Devloper", Value = "FrontEnd Devloper" },
        new SelectListItem { Text = "BackEnd Devloper", Value = "BackEnd Devloper" },
        new SelectListItem { Text = "FullStack Devloper", Value = "FullStack Devloper" },
        new SelectListItem { Text = "Designer", Value = "Designer" },
        new SelectListItem { Text = "Tester", Value = "Tester" },
        new SelectListItem { Text = "BDE", Value = "BDE" },
        new SelectListItem { Text = "HR", Value = "HR" },

    };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Employees Emp)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(Emp.EmployeeType.ToString());
                db.SaveChanges();

                return RedirectToAction("Index"); 
            }

            return View(Emp); 
        }



    }
}