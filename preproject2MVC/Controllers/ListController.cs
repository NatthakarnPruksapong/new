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
        linebotDBEntities db = new linebotDBEntities();
        // GET: List
        public ActionResult ListName()
        {
            
            ViewBag.query = db.customer.ToList();
            return View();
        }

        public ActionResult SearchListName()
        {
            var input = short.Parse(Request.Form["optionCheck"]);
            var user = db.customer.Where(x => x.u_status == input);
            ViewBag.query = user;
            return View("ListName");
        }
    }
}