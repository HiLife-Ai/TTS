using Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framework.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Sample> employeeList = new List<Sample>();
            Sample Test = new Sample();

            employeeList.Add(new Sample { EmployeeID = 1, Name = "Rose", Department = "IT" });
            employeeList.Add(new Sample { EmployeeID = 2, Name = "Lotus", Department = "Sales" });
            employeeList.Add(new Sample { EmployeeID = 3, Name = "Lilly", Department = "QA" });
            employeeList.Add(new Sample { EmployeeID = 4, Name = "Doria", Department = "Inventry" });

            //  ViewBag.EmployeeList  = employeeList;

            ViewData["EmployeeList"] = employeeList;

            ViewBag.EmployeeNameVB = "Priya";

            ViewData["EmployeeNameVD"] = "Rose";

            TempData["EmployeeNameTD"] = "Lotus";

            TempData.Keep();

            return View();
        }

        public ActionResult SecondPage()
        {
            TempData.Keep();
            return View();
        }
    }
}
