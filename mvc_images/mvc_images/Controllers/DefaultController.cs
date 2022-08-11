using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_images.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Asp_DaniyalEntities db = new Asp_DaniyalEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(cat_tbl cat,HttpPostedFileBase img)
        {
            string path = uploadingimg(img);
            if(path.Equals("-1"))
            {
                ViewBag.error = "Image Could Not Upload!!!";
            }
            else
            {
                cat_tbl cat2 = new cat_tbl();
                cat2.cat_image = cat.cat_image;
                cat2.cat_name = cat.cat_name;
                cat2.cat_status = 1;
                db.cat_tbl.Add(cat2);
                db.SaveChanges();
                return RedirectToAction("view_cat");
            }

            return View();
        }

        private string uploadingimg(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0) 
            {
                string ext = Path.GetExtension(file.FileName);
                if(ext.ToLower().Equals(".jpg")||ext.ToLower().Equals(".jpeg")|| ext.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/image"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/image" + random + Path.GetFileName(file.FileName);
                    }
                    catch(Exception ex)
                    {
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('only jpg,jpeg or png formats are acceptable!!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please select a file');</script>");
                path = "-1";
            }
            return path;
        }

        public ActionResult view_cat(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = db.cat_tbl.Where(x => x.cat_status == 1).ToList();
            IPagedList<cat_tbl> li = list.ToPagedList(pageindex, pagesize);
            return View(li);
        }
    }
}