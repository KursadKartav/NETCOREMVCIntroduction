using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreMvcIntroduction.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMvcIntroduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello kesko";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id=1,FirstName="Emre",LastName="Kesko",CityId=6},
                new Employee {Id=2,FirstName="Mehmet",LastName="Kesko",CityId=6},
                new Employee {Id=3,FirstName="Ömer",LastName="Kesko",CityId=6}
            };

            List<string> cities = new List<string> { "Istanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };

            return View(model);
        }
        public StatusCodeResult Index4() //Hatalar için kullanılan result. Bunlar için IActionResult kullanabiliriz yine.
        {
            return NotFound();
        }
        public StatusCodeResult Index5()
        {
            return Ok();
        }
        public RedirectResult Index6() //Index6 ile aynı işlemi yapar.
        {
            return Redirect("/Home/Index3");
        }
        public IActionResult Index7()
        {
            return RedirectToAction("Index3");
        }
        public IActionResult Index8()
        {
            return RedirectToRoute("Default");
        }
        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Id = 1, FirstName = "Emre", LastName = "Kesko", CityId = 6 },
                new Employee { Id = 2, FirstName = "Mehmet", LastName = "Kesko", CityId = 6 },
                new Employee { Id = 3, FirstName = "Ömer", LastName = "Kesko", CityId = 6 }
            };
            return Json(employees);
        }
        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id=1,FirstName="Emre",LastName="Kesko",CityId=6},
                new Employee {Id=2,FirstName="Mehmet",LastName="Kesko",CityId=6},
                new Employee {Id=3,FirstName="Ömer",LastName="Kesko",CityId=6}
            };

            List<string> cities = new List<string> { "Istanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };

            return View(model);
        }
        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Id = 1, FirstName = "Emre", LastName = "Kesko", CityId = 6 },
                new Employee { Id = 2, FirstName = "Mehmet", LastName = "Kesko", CityId = 6 },
                new Employee { Id = 3, FirstName = "Ömer", LastName = "Kesko", CityId = 6 }
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirstName.ToLower().Contains(key)); //isimleri filtrele
            return Json(result);
        }
        public ViewResult EmployeeForm() //Model binding çalışma yöntemini gösterdik.index 10 daki işlemi burda uygulayıp formu oraya aktardık.
        {
            return View();
        }
        public string RouteData(int? id)
        {
            return id.ToString();
        }

    }
}