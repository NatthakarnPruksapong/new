using preproject2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace preproject2MVC.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        linebotDBEntities db = new linebotDBEntities();
        // GET: Order
        public ActionResult Order()
        {
            ViewBag.query = db.order_list.ToList();
            return View();
        }
    }
}