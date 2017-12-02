using preproject2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace preproject2MVC.Controllers
{
    [Route("[controller]/[action]")]
    public class LoginController : Controller
    {
        linebotDBEntities db = new linebotDBEntities();
        // GET: Login
        public ActionResult login()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult LoginInToWeb()
        {
            var check = db.administrator.ToList();
            foreach (var r in check)
            {
                if (r.ad_id == Request.Form["ad_name"] && r.ad_password == Request.Form["ad_psw"])
                {
                    return RedirectToAction("Order", "Order");
                }
            }
            return View();
        }
    }
}