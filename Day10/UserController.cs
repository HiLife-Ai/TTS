using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day9.Models;

namespace Day9.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            sskEntities2 db = new sskEntities2();
            List<Order> orderlist = db.Orders.ToList();
            List<OrderViewModel> orderVMList = orderlist.Select(x => new OrderViewModel
            {
                CustomerName = x.CustomerName,
                CustomerID = x.CustomerID
            }).ToList();
            return View(orderVMList);
        }

        public ActionResult Blue(int CustomerID)
        {
            sskEntities2 db = new sskEntities2();
            Order order = db.Orders.SingleOrDefault(x => x.CustomerID == CustomerID);
            CustomerViewModel orderVM = new CustomerViewModel();


            orderVM.CustomerName = order.CustomerName;
            orderVM.Phoneno = order.Phoneno;
            orderVM.Mobiletype = order.detail.Mobiletype;
            
            return View(orderVM);
        }
    }
}