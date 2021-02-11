using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trust.Models;


namespace Trust.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            taskEntities1 db = new taskEntities1();
            List<company> companylist = db.companies.ToList();
            Decode companyVM = new Decode();

            List<Decode> companyVMList = companylist.Select(x => new Decode
            {
                COMPANY_NAME = x.COMPANY_NAME,
                COMPANY_ID = x.COMPANY_ID,
                COMPANY_CITY = x.COMPANY_CITY,
                ITEM_NAME = x.food.ITEM_NAME
            }).ToList();

            return View(companyVMList);
        }

       
        
    }

}