using Binding2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Binding2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            RazorEntities1 db = new RazorEntities1();

            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");

            return View();
        }
        [HttpPost]
        public ActionResult Index(ClassView1 model)
        {
            if (ModelState.IsValid == true)
            {
                
                    //write your code here
                
            }
            RazorEntities1 db = new RazorEntities1();

            List<Department> list = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");


            return View(model);

        }
    }
}