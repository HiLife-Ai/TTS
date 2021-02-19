using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayEleven.Models;


namespace DayEleven.Controllers
{
    public class ElevenController : Controller
    {
        // GET: Eleven
        public ActionResult Index()
        {
            LovsanEntities2 db = new LovsanEntities2();
            List<lovsan2> list = db.lovsan2.ToList();
            ViewBag.Lovsan2list = new SelectList(list, "DepartmentID", "DepartmentName");

            return View();
        }

        public ActionResult SaveRecord(EmployeeViewModel model)
        {


            try
            {


                LovsanEntities2 db = new LovsanEntities2();
                lovsan emp = new lovsan();
                emp.EmpName = model.EmpName;
                emp.Address = model.Address;
                emp.DepartmentID = model.DepartmentID;


                db.lovsans.Add(emp);

                db.SaveChanges();

                int latestEmpID = emp.EmpID;




            }

            catch (Exception ex)
            {

                throw ex;
            }





            return RedirectToAction("Index");

        }
    }
}