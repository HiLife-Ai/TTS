using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel.Models;

namespace DataModel.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

            [HttpGet]
        public ActionResult Index()
        {
            KelvinEntities1 db = new KelvinEntities1();

            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");


            List<ClassView> listEmp = db.Employees.Where(x => x.IsDeleted == false).Select(x => new ClassView
            {
              EmpName = x.EmpName,
              DepartmentName = x.Department.DepartmentName,
              Address = x.Address,
              EmpId = x.EmpId
            }).ToList();


            ViewBag.EmployeeList = listEmp;

            return View();
        }
        [HttpPost]
        public ActionResult Index(ClassView model)
        {
try
            {
           
            KelvinEntities1 db = new KelvinEntities1();
           
           
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

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(model);
        }

        public ActionResult DeleteEmployee(int EmployeeId)
        {
            KelvinEntities1 db = new KelvinEntities1();
            bool result = false;
            Employee emp = db.Employees.SingleOrDefault(x => x.IsDeleted == false && x.EmpId == EmployeeId);
            if (emp != null)
            {
                emp.IsDeleted = true;
                db.SaveChanges();
                result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
            
        }
    }
}