using Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Binding.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            RazorEntities db = new RazorEntities();

            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");
            return View();
        }
        public ActionResult SaveRecord(ClassView model)
        {
            try
            {
                RazorEntities db = new RazorEntities();
                Employee emp = new Employee();
                emp.EmpName = model.EmpName;
                emp.Address = model.Address;
                emp.DepartmentId = model.DepartmentId;

                db.Employees.Add(emp);

                db.SaveChanges();

                int latestEmpId = emp.EmpId;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");
            
        }
    }
}