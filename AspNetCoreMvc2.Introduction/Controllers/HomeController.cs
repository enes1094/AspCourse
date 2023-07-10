using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using AspNetCoreMvc2.Introduction.Filters;
using AspNetCoreMvc2.Introduction.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first application";
        }
        [HandleExceptionAtribute(ViewName ="DivideByZeroError",ExceptionType = typeof (DivideByZeroException))]
        public ViewResult Index2()
        {
            throw new DivideByZeroException();
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Enes",LastName="Tikici",CityId=6},
                new Employee{Id=2,FirstName="Hamza",LastName="Tikici",CityId=6},
                new Employee{Id=3,FirstName="Zehra",LastName="Tikici",CityId=34},
            };

            List<string> cities = new List<string> { "Istanbul", "Ankara" };
            var model = new emloyeeListViewModel
            {
                Employees = employees,
                cities = cities
            };
            return View(model);
        }

        public IActionResult Index4()
        {
            return StatusCode(200);
        }

        public IActionResult Index5()
        {
            return StatusCode(400); 
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Enes",LastName="Tikici",CityId=6},
                new Employee{Id=2,FirstName="Hamza",LastName="Tikici",CityId=6},
                new Employee{Id=3,FirstName="Zehra",LastName="Tikici",CityId=34},
            };

            return Json(employees);
        }

        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Enes",LastName="Tikici",CityId=6},
                new Employee{Id=2,FirstName="Hamza",LastName="Tikici",CityId=6},
                new Employee{Id=3,FirstName="Zehra",LastName="Tikici",CityId=34},
            };

            List<string> cities = new List<string> { "Istanbul", "Ankara" };
            var model = new emloyeeListViewModel
            {
                Employees = employees,
                cities = cities
            };
            return View(model);
        }

        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Enes",LastName="Tikici",CityId=6},
                new Employee{Id=2,FirstName="Hamza",LastName="Tikici",CityId=6},
                new Employee{Id=3,FirstName="Zehra",LastName="Tikici",CityId=34},
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirstName.ToLower().Contains(key));

            return Json(result);
        }

        public ViewResult EmployeeForm()
        {
            return View();
        }

        public string RouteData(int id)
        {
            return id.ToString();
        }
    }
}