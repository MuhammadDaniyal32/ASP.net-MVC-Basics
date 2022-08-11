using html_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_helper.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            new_tblEntities db = new new_tblEntities();
            List<Department_tbl> list = db.Department_tbl.ToList();
            ViewBag.deplist = new SelectList(list, "Dep_ID", "Dep_Name");
            return View();
        }
        [HttpPost]
        public ActionResult saverecord (Class1 cls)
        {
            try
            {
                new_tblEntities db = new new_tblEntities();
                Employee_tbl emp = new Employee_tbl();
                emp.Emp_name = cls.Emp_name;
                emp.Address = cls.Address;
                emp.Dep_ID = cls.Dep_ID;
                db.Employee_tbl.Add(emp);
                db.SaveChanges();
                int lastestempid = emp.Emp_ID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }
    }
}