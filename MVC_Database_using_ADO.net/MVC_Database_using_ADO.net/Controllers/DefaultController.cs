using MVC_Database_using_ADO.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database_using_ADO.net.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Asp_DaniyalEntities db = new Asp_DaniyalEntities();
            emp_tbl emp = db.emp_tbl.SingleOrDefault(x => x.Emp_id == 1);
            Class1 cl = new Class1();
            cl.Emp_id = emp.Emp_id;
            cl.Dep_id = emp.Dep_id;
            cl.Name = emp.Name;
            cl.Address = emp.Address;
            return View(cl);
        }
    }
}