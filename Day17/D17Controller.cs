using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day17.Models;

namespace Day17.Controllers
{
    public class D17Controller : Controller
    {
        // GET: D17
        public ActionResult Index()
        {

            MSBEntities1 db = new MSBEntities1();
            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId","DepartmentName");

            return View();
        }
        public ActionResult SaveRecord(EmployeeViewModel model) 
        {
           try {



                MSBEntities1 db = new MSBEntities1();
                Employee emp = new Employee();
                emp.Name = model.Name;
                emp.Address = model.Address;
                emp.DepartmentId = model.DepartmentId;


                db.Employees.Add(emp);

                db.SaveChanges();
                int latestEmpId = emp.EmployeeId;




               

            }

            catch (Exception ex) 
            {
               
            
             throw ex;


           }

            return RedirectToAction("Index");
           
             
        }
    }
}