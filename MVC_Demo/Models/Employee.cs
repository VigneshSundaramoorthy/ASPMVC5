using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Emp ID is mandatory")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage = "Enter four digit Employee ID")]
        public int EmpID { get; set; }

        [Required(ErrorMessage = "FirstName is mandatory")]
        [StringLength(10,ErrorMessage = "Maximun Firstname lenght is 10")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Salary is Mndatory")]
        public double Salary { get; set; }

    }
}