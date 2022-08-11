using InventoryManagmentSystem2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace InventoryManagmentSystem2.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private inventoryDBEntities db = new inventoryDBEntities();

        // GET: Users
        
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.role);
                return View(users.ToList());            
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            if (user.status == Convert.ToByte(1))
            {
                ViewBag.ac = "Active";
            }
            else
            {
                ViewBag.ac = "Inactive";
            }

            return View(user);
        }

        // GET: Users/Create
        [Authorize(Roles = "Admin,User,Developer")]
        public ActionResult Create()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "Active", Value = "1" });
            li.Add(new SelectListItem() { Text = "In-Active", Value = "0" });
            ViewBag.ad = new SelectList(li, "Value", "Text");
            ViewBag.u_roleid = new SelectList(db.roles, "r_id", "r_name");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User,Developer")]
        public ActionResult Create([Bind(Include = "u_id,username,password,u_name,phone,email,status,u_roleid")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.u_roleid = new SelectList(db.roles, "r_id", "r_name", user.u_roleid);
            return View(user);
        }

        // GET: Users/Edit/5
        [Authorize(Roles = "Admin,Developer")] 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "Active", Value = "1" });
            li.Add(new SelectListItem() { Text = "In-Active", Value = "0" });
            ViewBag.ad = new SelectList(li, "Value", "Text");
            ViewBag.u_roleid = new SelectList(db.roles, "r_id", "r_name", user.u_roleid);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Edit([Bind(Include = "u_id,username,password,u_name,phone,email,status,u_roleid")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.u_roleid = new SelectList(db.roles, "r_id", "r_name", user.u_roleid);
            return View(user);
        }

        // GET: Users/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            if (user.status == Convert.ToByte(1))
            {
                ViewBag.ac = "Active";
            }
            else
            {
                ViewBag.ac = "Inactive";
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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