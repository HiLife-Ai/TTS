using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {

        // GET: Test
        public ActionResult Index()
        {
            compileEntities db = new compileEntities();
            Table2 class =  db.Table2();
    }
           
       
          
            return View();
}
        }
    }
