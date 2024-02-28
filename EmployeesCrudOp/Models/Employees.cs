using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeesCrudOp.Models
{
    public class Employees
    {
        [Key]

        public int EmployeeId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int Age { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }


        public string Gender { get; set; }

        public string[] Genders = new[] { "Male", "Female", };

        public List<SelectListItem> EmployeeType { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? JoiningDate { get; set; }


    }
}