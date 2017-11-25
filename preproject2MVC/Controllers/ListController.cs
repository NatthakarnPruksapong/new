using preproject2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace preproject2MVC.Controllers
{
    [Route("[controller]/[action]")]
    public class ListController : Controller
    {
        // GET: List
        public ActionResult ListName()
        {
            linebotDBEntities db = new linebotDBEntities();

            ViewBag.query = db.customer.ToList();
            return View();
        }
    }
}