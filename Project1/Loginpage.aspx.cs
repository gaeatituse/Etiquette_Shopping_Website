using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class Loginpage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string login = "select count(Reg_Id) from LoginTab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obj.Fun_Scalar(login);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from LoginTab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string regid = obj.Fun_Scalar(str1);
                Session["userid"] = regid;
                string str2 = "select L_Type from LoginTab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtype = obj.Fun_Scalar(str2);
                if (logtype == "admin")
                {
                    Response.Redirect("AdminHomepage.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("UserHomepage.aspx");
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid Username and Password";
            }
        
        }
    }
}