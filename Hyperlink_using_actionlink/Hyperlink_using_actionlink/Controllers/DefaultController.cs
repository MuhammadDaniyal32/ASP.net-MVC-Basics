using Hyperlink_using_actionlink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hyperlink_using_actionlink.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Asp_DaniyalEntities1 db = new Asp_DaniyalEntities1();
            List<emp_tbl> emp = db.emp_tbl.ToList();
            Class1 emp_class = new Class1();
            List<Class1> emp_list = emp.Select(x => new Class1
            {
                Emp_name = x.Emp_name,
                Emp_id = x.Emp_id
            }).ToList();
            return View(emp_list);
        }

        public ActionResult Detail(int Emp_id)
        {
            Asp_DaniyalEntities1 db = new Asp_DaniyalEntities1();
            emp_tbl emp = db.emp_tbl.SingleOrDefault(x => x.Emp_id == Emp_id);
            Class1 emp_class = new Class1();
            emp_class.Emp_name = emp.Emp_name;
            emp_class.Dep_name = emp.Dep_tbl.Dep_name;
            emp_class.Address = emp.Address;
            return View(emp_class);
        }
    }
}