using EmployeesCrudOp.Data;
using EmployeesCrudOp.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;


namespace EmployeesCrudOp.Controllers
{
    public class EmployeesController : Controller
    {
        //public EmployeeContext db = new EmployeeContext();

        EmployeeContext db = new EmployeeContext();


        public ActionResult Index(string sortOrder, int? page)
        {
            EmployeeContext db = new EmployeeContext();
            int pageSize = 5;
            int pageIndex = page ?? 1;

            IQueryable<Employees> employeesQuery = db.Employee;
           employeesQuery = employeesQuery.OrderBy(m => m.firstName);

            var employees = employeesQuery.ToPagedList(pageIndex, pageSize);

            return View(employees);
        }


        [HttpGet]
        public ActionResult Create()
        {
            var model = new EmployeeViewModel();
            model.employeeTypes = GetEmployeeTypes();
            return View(model);
        }

        private IEnumerable<SelectListItem> GetEmployeeTypes()
        {
            var employeeTypes = new List<SelectListItem>
    {
        //new SelectListItem { Value = "0", Text = "--Select Employee Type--" },
        new SelectListItem { Value = "1", Text = "FrontEnd Devloper" },
        new SelectListItem { Value = "2", Text = "BackEnd Devloper" },
        new SelectListItem { Value = "3", Text = "Designer" },
        new SelectListItem { Value = "4", Text = "Tester" },
        new SelectListItem { Value = "5", Text = "BDE" },
        new SelectListItem { Value = "6", Text = "HR" },
    };
            return employeeTypes;
        }




        [HttpPost]
        public ActionResult Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employees
                {
                    firstName = model.firstName,
                    lastName = model.lastName,
                    age = model.age,
                    gender = model.gender,
                    mobileNumber = model.mobileNumber,
                    email = model.email,
                    employeeType = model.employeeType,
                    joiningDate = model.joiningDate
                };

                db.Employee.Add(employee);
                    db.SaveChanges();

                return RedirectToAction("Index");
            }
            model.employeeTypes = GetEmployeeTypes();
            return View(model);
        }


        public ActionResult Edit(string Id)
        {
            int EmpId = Convert.ToInt32(Id);
            var Emp = db.Employee.Find(EmpId);

            var model = new EmployeeViewModel
            {
                employeeId = Emp.employeeId,
                firstName = Emp.firstName,
                lastName = Emp.lastName,
                age = Emp.age,
                gender = Emp.gender,
                mobileNumber = Emp.mobileNumber,
                email = Emp.email,
                employeeType = Emp.employeeType,
                joiningDate = Emp.joiningDate,
                employeeTypes = GetEmployeeTypes()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = db.Employee.Find(model.employeeId);
                if (data != null)
                {
                    data.firstName = model.firstName;
                    data.lastName = model.lastName;
                    data.age = model.age;
                    data.gender = model.gender;
                    data.mobileNumber = model.mobileNumber;
                    data.email = model.email;
                    data.employeeType = model.employeeType;
                    data.joiningDate = model.joiningDate;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            model.employeeTypes = GetEmployeeTypes(); // Repopulate employeeTypes
            return View(model);
        }



        //public ActionResult Delete(String Id)
        //{
        //    var Empid = Convert.ToInt32(Id);
        //    var Emp = db.Employee.Find(Empid);


        //    var model = new EmployeeViewModel
        //    {
        //        employeeId = Emp.employeeId,
        //        firstName = Emp.firstName,
        //        lastName = Emp.lastName,
        //        age = Emp.age,
        //        gender = Emp.gender,
        //        mobileNumber = Emp.mobileNumber,
        //        email = Emp.email,
        //        employeeType = Emp.employeeType,
        //        joiningDate = Emp.joiningDate
        //    };
        //    return View(model);

        //}

     [HttpGet]
        public ActionResult Delete(int Id)
        {
            var data = db.Employee.Find(Id);
            if (data == null)
            {
                return HttpNotFound();
            }
            db.Employee.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}