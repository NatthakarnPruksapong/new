using preproject2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace preproject2MVC.Controllers
{
    [Route("[controller]/[action]")]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menu()
        {
            linebotDBEntities db = new linebotDBEntities();
            //ViewBag.query = db.product.ToList();
            return View();
        }
    }
}