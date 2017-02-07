using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("IndexDemo");
        }

        public ActionResult GetData(int? id)
        {
            ViewBag.data = "The data given is..." + id + "";
            return View();
        }

        public ActionResult Greet(string userName)
        {
            ViewBag.wish = string.Concat("Hello ", userName);
            return View();
        }

        [Route("Home/Greet1/userName/{userName}/{address?}")]
        public ActionResult Greet1(string userName, string address)
        {
            ViewBag.wish1 = string.Concat("Hello ", userName, " Address : ", address);
            return View();
        }

        [Route("Home/Greet2/userName/{userName}")]
        public ActionResult Greet2(string userName)
        {
            ViewBag.wish1 = string.Concat("Hello ", userName, " Address : New Jersey");
            return View("Greet1");
        }
        public ActionResult EmployeeForm()
        {
            return View();
        }

        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee();
            emp.EmpID = Convert.ToInt32(Request.Form["txtEmpId"]);
            emp.FirstName = Request.Form["txtFirstName"];
            emp.LastName = Request.Form["txtLastName"];
            emp.Salary = Convert.ToDouble(Request.Form["txtSalary"]);
            ViewBag.emp = emp;
            return View();
        }

        public ActionResult STEmployeeForm()
        {
            
            return View();
        }

        [Route("Home/STDisplayEmployee")]
        public ActionResult STDisplayEmployee(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                return View(emp);
            }
                
            else
            {
                return View("STEmployeeForm",emp);
            }
                
        }

        [Route("Home/STDisplayCollection")]
        public ActionResult DisplayCollection()
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee { EmpID = 1, FirstName = "User1", LastName = "User1", Salary = 1000 };
            Employee emp2 = new Employee { EmpID = 1, FirstName = "User2", LastName = "User2", Salary = 2000 };
            empList.Add(emp1);
            empList.Add(emp2);

            return View(empList);
        }

    }
}