using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Drop_down_list_database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAB07-172; Initial Catalog=Asp_Daniyal;User ID=sa;password=aptech");
                SqlCommand cmd = new SqlCommand("Select * from state", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("Select Country");

            SqlConnection con = new SqlConnection(@"Data Source=LAB07-172; Initial Catalog=Asp_Daniyal;User ID=sa;password=aptech");
            SqlCommand cmd = new SqlCommand("Select * from Country where city_Id=" + DropDownList2.SelectedItem.Value, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select State");

            SqlConnection con = new SqlConnection(@"Data Source=LAB07-172; Initial Catalog=Asp_Daniyal;User ID=sa;password=aptech");
            SqlCommand cmd = new SqlCommand("Select * from state where Country_id=" + DropDownList1.SelectedItem.Value, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DropDownList2.DataSource = dt;
             DropDownList2.DataBind();
        }
    }
}