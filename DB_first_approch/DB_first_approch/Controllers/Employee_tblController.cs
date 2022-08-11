using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DB_first_approch.Models;

namespace DB_first_approch.Controllers
{
    public class Employee_tblController : Controller
    {
        private Asp_DaniyalEntities db = new Asp_DaniyalEntities();

        // GET: Employee_tbl
        public ActionResult Index()
        {
            return View(db.Employee_tbl.ToList());
        }

        // GET: Employee_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_tbl employee_tbl = db.Employee_tbl.Find(id);
            if (employee_tbl == null)
            {
                return HttpNotFound();
            }
            return View(employee_tbl);
        }

        // GET: Employee_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee_tbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Emp_ID,Name,Address,Age,Salary,Worktype")] Employee_tbl employee_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Employee_tbl.Add(employee_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee_tbl);
        }

        // GET: Employee_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_tbl employee_tbl = db.Employee_tbl.Find(id);
            if (employee_tbl == null)
            {
                return HttpNotFound();
            }
            return View(employee_tbl);
        }

        // POST: Employee_tbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Emp_ID,Name,Address,Age,Salary,Worktype")] Employee_tbl employee_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee_tbl);
        }

        // GET: Employee_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_tbl employee_tbl = db.Employee_tbl.Find(id);
            if (employee_tbl == null)
            {
                return HttpNotFound();
            }
            return View(employee_tbl);
        }

        // POST: Employee_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_tbl employee_tbl = db.Employee_tbl.Find(id);
            db.Employee_tbl.Remove(employee_tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
