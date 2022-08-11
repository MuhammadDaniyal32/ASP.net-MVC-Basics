using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_with_DB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@" Data Source=LAB07-180;Initial Catalog=ASP_Daniyal;User ID=sa;Password=aptech");
            con.Open();
            string query = "select count(1) from Login_tbl where User_name='" + TextBox1.Text + "'AND Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count==1)
            {
                Session["User_name"] = TextBox1.Text;
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                Label1.Visible = true;
            }
        }
    }
}