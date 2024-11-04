using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Project1
{
    public partial class Paymentpage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into FeedbackTab values(" + Session["userid"] + ",'" + TextBox1.Text + "','Not Responded','Active')";
            int a = obj.Fun_Non_Query(ins);
            if (a == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Feedback Submitted";
            }
        }
    }
}