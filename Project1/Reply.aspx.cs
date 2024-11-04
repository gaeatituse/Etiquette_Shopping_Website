using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Project1
{
    public partial class Reply : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel1 = "select U_Email from UserRegTab where U_Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.Fun_exeReader(sel1);
            while (dr.Read())
            {
                Label1.Text = dr["U_Email"].ToString();
            }
        }

        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody =body;
            message.Subject =subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName,yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select U_Name from UserRegTab where U_Id=" + Session["uid"] + "";
            string i = obj.Fun_Scalar(sel);
            string sel1 = "select U_Email from UserRegTab where U_Id=" + Session["uid"] + "";
            string j = obj.Fun_Scalar(sel1);
            SendEmail2("Etiquette", "etiqutte2024@gmail.com", "cqik qryo hthp ihwd", i, j, TextBox3.Text, TextBox4.Text);

            string up = "update FeedbackTab set F_status='Inactive' where U_Id=" + Session["uid"] + " and F_status='Active'";
            int k = obj.Fun_Non_Query(up);
            if (k == 1)
            {
                Label2.Text = "Mail sent";
            }
        }
    }
}