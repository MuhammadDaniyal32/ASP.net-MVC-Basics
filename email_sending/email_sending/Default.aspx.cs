using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Email_sending
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
                msg.IsBodyHtml = true;
                SmtpClient clt = new SmtpClient("smtp.gmail.com", 587);
                clt.EnableSsl = true;
                clt.Credentials = new System.Net.NetworkCredential("m.daniyalnoor32@gmail.com", "");
                clt.Send(msg);
                Label5.Text = "Email Has Sent Succefully!";
            }
            catch(Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
    }
}