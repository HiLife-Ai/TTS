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
            LovsanEntities1 db = new LovsanEntities1();
            List<lovsan2> list = db.lovsan2.ToList();
            ViewBag.Lovsan2list = new SelectList(list, "DepartmentID", "DepartmentName");

            return View();
        }
    }
}