using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Name = "Priyanga";

            List<string> list = new List<string>();
            list.Add("Priyanga");
            list.Add("Hamsala");
            list.Add("Ajay");
            list.Add("Mahasakthi");

            ViewBag.NameList = List;

            return View();
        }
    }
}