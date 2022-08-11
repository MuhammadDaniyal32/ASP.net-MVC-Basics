using Delete_record.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delete_record.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            AspCrudEntities db = new AspCrudEntities();
            List<Department> list = db.Departments.ToList();
            ViewBag.dep_list = new SelectList(list, "Dep_ID", "Dep_Name");
            List<Class1> list_class = db.Employees.Where(x => x.IsDeleted == false).Select(x => new Class1 { Name = x.Name, DepartmentName = x.Department.DepartmentName, Address = x.Address, EmployeeId = x.EmployeeId }).ToList();
            ViewBag.emp_list = list_class;
            return View();
        }

        public JsonResult DeleteEmp(int empid)
        {
            AspCrudEntities db = new AspCrudEntities();

            bool result = false;
            Employee emp = db.Employees.SingleOrDefault(x => x.IsDeleted == false && x.EmployeeId == empid);
            if(emp !=null)
            {
                emp.IsDeleted = true;
                db.SaveChanges();
                result = true;
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}