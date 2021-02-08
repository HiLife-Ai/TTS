using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day6.Models;

namespace Day6.Controllers
{
    public class D6Controller : Controller
    {
        // GET: D6
        public ActionResult Index()
        {
            Models.sivaEntities1 db = new Models.sivaEntities1();

            List<Employee> employeelist = db.Employees.Include("the virtual property name ").ToList();
            D6Class employeeVM = new D6Class();
            List<Employee> employeeVMList = employeelist.Select(x => new D6Class
            { EmpName = x.EmpName,
              EmployeeID = x.EmployeeID,
               Address = x.Address,
                DepartmentID = x.DepartmentID,
                 DepartmentName = x.Departments.DepartmentName }).ToList(); 
                       return View();
        }
    }

    internal class D6Model
    {
    }
}