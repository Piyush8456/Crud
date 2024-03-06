using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeesCrudOp.Models
{
    public class EmployeeViewModel
    {
        public int employeeId { get; set; }

        [Required(ErrorMessage = "Please Enter Valid First Name.")]
        [StringLength(15, MinimumLength = 3)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Last Name.")]
        [StringLength(15, MinimumLength = 3)]
        public string lastName { get; set; }


        [Required(ErrorMessage = "A Valid Age Is Required.")]
        [Range(20, 60)]
        public int age { get; set; }


        [Required(ErrorMessage = "Please Enter Valid Mobile number.")]
        [StringLength(13, MinimumLength = 10)]
        public string mobileNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Email Address.")]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Gender is Required.")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Please Choose Employee Role.")]
        public int employeeType { get; set; }

        public IEnumerable<SelectListItem> employeeTypes { get; set; }

        [Required(ErrorMessage = "Joining Date Is Required.")]
        [DataType(DataType.Date)]
        public DateTime joiningDate { get; set; }

    
    }
}