using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_crud.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Asp_DaniyalEntities entity = new Asp_DaniyalEntities();
            List<Customer_tbl> emp = entity.Customer_tbl.ToList();

            emp.Insert(0, new Customer_tbl());
            return View();
        }
        [HttpPost]
        public JsonResult insert(Customer_tbl emp)
        {
            using (Asp_DaniyalEntities entity = new Asp_DaniyalEntities())
            {
                entity.Customer_tbl.Add(emp);
                entity.SaveChanges();
            }
            return Json(emp);
        }
        [HttpPost]

        public ActionResult update(Customer_tbl emp)
        {
            using (Asp_DaniyalEntities entity = new Asp_DaniyalEntities())
            {
               Customer_tbl update = (from c in entity.Customer_tbl
                              where c.ID == emp.ID
                              select c).FirstOrDefault();
                update.Name = emp.Name;
                update.Country = emp.Country;
                entity.SaveChanges();  
                }
            return new EmptyResult();
        }
        [HttpPost]
        public ActionResult delete(int cust_id)
        {
            using (Asp_DaniyalEntities entity = new Asp_DaniyalEntities())
            {
                Customer_tbl delete = (from c in entity.Customer_tbl
                                       where c.ID == cust_id
                                       select c).FirstOrDefault();
                entity.Customer_tbl.Remove(delete);
                entity.SaveChanges();
            }
            return new EmptyResult();
        }
    }
}