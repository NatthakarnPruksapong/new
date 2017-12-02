using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using preproject2MVC.Models;

namespace preproject2MVC.Controllers
{
    [Route("[controller]/[action]")]
    public class AddMenuController : Controller
    {
        linebotDBEntities db = new linebotDBEntities();
        // GET: AddMenu
        public ActionResult addMenu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMenuProuct(HttpPostedFileBase file)
        {
            string pic = Path.GetFileName(file.FileName.ToString());
            string path = Path.Combine(Server.MapPath("~/BG/"), pic);
            file.SaveAs(path);

            using (MemoryStream m = new MemoryStream())
            {
                file.InputStream.CopyTo(m);
                byte[] array = m.GetBuffer();
            }

            var addproduct = new product
            {
                p_name = Request.Form["name"],
                p_description = Request.Form["detail"],
                retail_price = short.Parse(Request.Form["retail"]),
                wholesale_price = short.Parse(Request.Form["wholesale"]),
                agent_price = short.Parse(Request.Form["agent_price"]),
                p_status = short.Parse(Request.Form["status"]),
                p_image = pic
            };

            db.product.Add(addproduct);
            db.SaveChanges();

            return RedirectToAction("Menu", "Menu");
        }
    }
}