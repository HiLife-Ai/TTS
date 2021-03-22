using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBind.Models;

namespace ModelBind.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HttpGet]
        public ActionResult Index()
        {
            KelvinEntities db = new KelvinEntities();

            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");
            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewModel model)
        {
           
                KelvinEntities db = new KelvinEntities();
                List<Department> list = db.Departments.ToList();
                ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");

                Employee emp = new Employee();
                emp.Address = model.Address;
                emp.EmpName = model.EmpName;
                emp.DepartmentId = model.DepartmentId;

                db.Employees.Add(emp);
                db.SaveChanges();

                int latestEmpId = emp.EmpId;


                Site site = new Site();
                site.SName = model.SName;
                site.EmpId = latestEmpId;

                db.Sites.Add(site);
                db.SaveChanges();
            
           
            return View(model);
        }
    }
}