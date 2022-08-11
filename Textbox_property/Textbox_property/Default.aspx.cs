using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Textbox_property
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void txtchng(object sender, EventArgs e)
        {
            Response.Write("First Textbox text:" + TextBox1.Text);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Second Textbox text:" + TextBox2.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            Label2.Text = TextBox2.Text;
        }
    }
}