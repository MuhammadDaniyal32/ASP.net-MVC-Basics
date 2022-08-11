using email_sending.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace email_sending.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 clas)
        {

            WebMail.Send("m.daniyalnoor32@gmail.com", clas.Name + "Your Invited in Funeral.", clas.Message + "<br/><br/> Mobile Number:" + clas.Mobile + "<br/><br/> Email Address:" + clas.Email,
                null, null, null, true, null, null, null, null, null, clas.Email);
            ModelState.Clear();
            return View();
        }

        
    }
}