using MVC_VIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_VIEW.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                cont_Id = 101,
                Name="Daniyal",
                Address="abc",
                Mobile="02134345345"
            };

            return View(emp);
        }
    }
}