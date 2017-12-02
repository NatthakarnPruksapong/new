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
        linebotDBEntities db = new linebotDBEntities();
        // GET: Menu
        public ActionResult Menu()
        {
            
            ViewBag.querymenu = db.product.ToList();
            //ViewBag.query = db.product.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult DeleteMenu()
        {
            var id = Int32.Parse(Request.Form["pd_id"]);
            var deleteOrder = db.product.Where(x => x.p_id == id).FirstOrDefault();

            db.product.Remove(deleteOrder);
            db.SaveChanges();
            return RedirectToAction("Menu","Menu");
        }

    }
}