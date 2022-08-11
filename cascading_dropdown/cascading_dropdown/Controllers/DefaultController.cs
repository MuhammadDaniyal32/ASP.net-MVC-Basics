using cascading_dropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cascading_dropdown.Controllers
{
    public class DefaultController : Controller
    {
        Asp_DaniyalEntities db = new Asp_DaniyalEntities();
        // GET: Default
        public ActionResult Index()
        {
            List<SelectListItem> disname = new List<SelectListItem>();
           Class1 clas1 = new Class1();
            List<disease_tbl> dis_tbl = db.disease_tbl.ToList();
            dis_tbl.ForEach(x =>
            {
                disname.Add(new SelectListItem { Text = x.des_name, Value = x.des_ID.ToString() });
            });

            clas1.des_Name = disname;

            return View(clas1);
        }
        [HttpPost]
        public ActionResult Index(string dis_id)
        {
            int disid;
            List<SelectListItem> docname = new List<SelectListItem>();
            if(!string.IsNullOrEmpty(dis_id))
            {
                disid = Convert.ToInt32(dis_id);
                List<Docter_tbl> doc = db.Docter_tbl.Where(x => x.des_fk_ID == disid).ToList();
                doc.ForEach(x =>
                {
                    docname.Add(new SelectListItem { Text = x.doc_Name, Value = x.doc_ID.ToString() });
                });
                
            }
            return Json(docname,JsonRequestBehavior.AllowGet);
        }
    }
}