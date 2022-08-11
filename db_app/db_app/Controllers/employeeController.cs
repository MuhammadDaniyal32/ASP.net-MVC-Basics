using db_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace db_app.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Index(int id)
        {
            empContext emcont = new empContext();
            Employee emp = emcont.Employees.Single(x => x.cont_ID == id);
            return View(emp);
        }
    }
}