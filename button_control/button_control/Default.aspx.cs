using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace button_control
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com/");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("ImageButton1_Click");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="admin"&&TextBox2.Text=="admin")
            {
                Response.Redirect("Contact.aspx");
            }
            else
            {
                Response.Write("Username and password error");
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Clicked!!!");
        }
    }
}