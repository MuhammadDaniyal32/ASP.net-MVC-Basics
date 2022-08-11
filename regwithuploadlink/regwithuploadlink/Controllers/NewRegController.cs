using regwithuploadlink.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace regwithuploadlink.Controllers
{
    public class NewRegController : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 uc,HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Data Source=LAB07-172;Initial Catalog=Asp_Daniyal;Persist Security Info=True;User ID=sa;Password=***********"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            string sqlquery = "insert into user_img(Uname,Uemail,Upwd,Gender,Uimg) Values (@uname,@uemail,@upwd,@ugender,@uimg)";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlcon);
            sqlcon.Open();
            sqlcom.Parameters.AddWithValue("@uname", uc.Uname);
            sqlcom.Parameters.AddWithValue("@uemail", uc.Uemail);
            sqlcom.Parameters.AddWithValue("@upwd", uc.Upwd);
            sqlcom.Parameters.AddWithValue("@ugender", uc.Gender);
            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/image/"), filename);
                file.SaveAs(imgpath);
            }

            sqlcom.Parameters.AddWithValue("@uimg", "~/image/" + file.FileName);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();

            ViewData["Mesg"] = "user record" + uc.Uname + "is saved successfully";
            return View();
        }
    }
}