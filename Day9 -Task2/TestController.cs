using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day9.Models;

namespace Day9.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            sskEntities1 db = new sskEntities1();
            List<Order> orderlist = db.Orders.ToList();
            CustomerViewModel orderVM = new CustomerViewModel();
            List<CustomerViewModel> orderVMList = orderlist.Select(x => new CustomerViewModel 
            { 
            CustomerName = x.CustomerName,
             CustomerID = x.CustomerID,
              Phoneno = x.Phoneno,
               MobileID = x.MobileID,
               Mobiletype = x.detail.Mobiletype }).ToList();


            return View(orderVMList);
        }
    }
}

  


    