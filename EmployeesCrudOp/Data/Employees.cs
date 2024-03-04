using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace EmployeesCrudOp.Data
{
    public class Employees
    {
        [Key]

       
        public int employeeId { get; set; }


        public string firstName { get; set; }


        public string lastName { get; set; }

        public int age { get; set; }

     
        public string mobileNumber { get; set; }

        public string email { get; set; }

        public string gender { get; set; }


        public int employeeType { get; set; }
        public IEnumerable<SelectListItem> employeeTypes { get; set; }

        [DataType(DataType.Date)]
        public DateTime joiningDate { get; set; }

    }
}