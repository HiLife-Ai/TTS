using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public string Contact(string Name)
        {
            return "Name vgvg=" + Name; 
        }
    }
}