using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dropdown_List
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem Male = new ListItem("Male", "1");
                ListItem Female = new ListItem("Female", "2");

                DropDownList1.Items.Add(Male);
                DropDownList1.Items.Add(Female);
            }
            if(!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedItem.Text;
            Response.Write("You Selected:" + DropDownList1.SelectedItem.Text);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    Response.Write("Text=" + li.Text + ", ");
                    Response.Write("Value=" + li.Value + ", ");
                    Response.Write("Index=" + CheckBoxList1.Items.IndexOf(li).ToString());
                    Response.Write("<br/>");
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in ListBox2.Items)
            {
                if(li.Selected)
                {
                    Response.Write("Text is:" + li.Text + "<br>");
                    Response.Write("----------------------------");
                    Response.Write("<br>");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1) 
            {
                Response.Write("text is:" + ListBox1.SelectedItem.Text + "<br/>");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar1.SelectedDate.ToString("D");
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.IsOtherMonth||e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Cyan;
            }
        }
    }
}