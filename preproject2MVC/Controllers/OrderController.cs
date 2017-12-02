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
            var innerJoinQuery =
            (from c in db.customer
             join o in db.order_list on c.line_id equals o.line_id where o.payment==0
             select  new customer_order { name = c.u_name, date = o.o_date, idorder = o.o_id, status = o.o_status }).ToList();
            
            return View("Order", innerJoinQuery);
       
        }

        [HttpPost]
        public ActionResult Search()
        {
            var input = short.Parse(Request.Form["optionCheck"]);
            var order = db.order_list.Where(x => x.o_status == input).ToList();
            ViewBag.query = order;
            return View("Order");
        }

        [HttpPost]
        public ActionResult HOrder()
        {
            var eiei = Int32.Parse(Request.Form["o_id"]);
            var order = db.order_list.Where(x => x.o_id == eiei).FirstOrDefault();
            var detailOrder = db.products_in_order.Where(y => y.o_id == order.o_id);
            var user = db.customer.Where(z => z.line_id == order.line_id).FirstOrDefault();
            ViewBag.queryorder = order;
            ViewBag.querydetailOrder = detailOrder;
            ViewBag.queryuser = user;
            return View();
        }

        [HttpPost]
        public ActionResult ChangeStatus()
        {
            /*var id = Int32.Parse(Request.Form["o_id"]);
            var order = db.order_list.Where(x => x.o_id == id).FirstOrDefault();
            order.o_status = short.Parse(Request.Form["option"]);
            
            db.SaveChanges();*/
            return View("Order");
        }
    }
}