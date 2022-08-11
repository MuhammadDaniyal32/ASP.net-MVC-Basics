using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using InventoryManagmentSystem2;
using InventoryManagmentSystem2.Models;

namespace InventoryManagmentSystem2.Controllers
{ 
    public class Auth_Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            //inventoryDBEntities db = new inventoryDBEntities();
            //var data = db.st_getlogindata(user.u_name, user.password);
            //foreach (var item in data)
            //{
            //    if (item.u_name == user.u_name && item.password == user.password)
            //    {
            //        Session["name"] = user.u_name;
            //        return RedirectToAction("Main");
            //    }
            //    else
            //    {
            //        ViewBag.test = "Please Enter Valid Username And Password!!!";
            //    }
            //}

            using (var context =new inventoryDBEntities())
            {
                if (context.Users.Any(x => x.u_name == user.u_name && x.password == user.password))
                {
                    FormsAuthentication.SetAuthCookie(user.u_name, false);
                    Session["name"] = user.u_name;
                  
                    return RedirectToAction("Main");
                }
                else
                {
                    ModelState.AddModelError("", "Please Enter Valid Username And Password!!!");
                }
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("name");
            return RedirectToAction("Index", "Auth_");
        }
        [Authorize]
        public ActionResult Main()
        {
            
                return View();
            
        }
    }
}