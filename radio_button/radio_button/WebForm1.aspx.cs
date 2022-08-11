using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace radio_button
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBox1.Checked = true;
            RadioButton1.Checked = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Response.Write(RadioButton1.Text);
            }
            else if(RadioButton2.Checked)
            {
                Response.Write(RadioButton2.Text);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StringBuilder choice = new StringBuilder();
            if(CheckBox1.Checked)
            {
                choice.Append(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                choice.Append(","+CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                choice.Append(","+CheckBox3.Text);
            }
            if (CheckBox4.Checked)
            {
                choice.Append(","+CheckBox4.Text);
            }
            if (CheckBox5.Checked)
            {
                choice.Append(","+CheckBox1.Text);
            }
            Response.Write("Your Selection:" + choice.ToString());
        }
    }
}