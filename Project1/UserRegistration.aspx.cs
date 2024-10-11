using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string exist = "select count(Reg_Id) from LoginTab where Username='" + TextBox8.Text + "'";
            string k = obj.Fun_Scalar(exist);
            int m = Convert.ToInt32(k);
            if (m > 0)
            {
                Label1.Visible = true;
                Label1.Text = "Please choose another username";
            }
            else
            {
                string sel = "select max(Reg_Id) from LoginTab";
                string maxregid = obj.Fun_Scalar(sel);
                int reg_id = 0;
                if (maxregid == "")
                {
                    reg_id = 1;
                }
                else
                {
                    int newregid = Convert.ToInt32(maxregid);
                    reg_id = newregid + 1;
                }

                string ins = "insert into UserRegtab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + "," + TextBox5.Text + "," + TextBox6.Text + ",'" + RadioButtonList1.SelectedItem.ToString() + "','active')";
                int i = obj.Fun_Non_Query(ins);
                if (i == 1)
                {
                    string inslog = "insert into LoginTab values(" + reg_id + ",'" + TextBox8.Text + "','" + TextBox9.Text + "','user')";
                    int j = obj.Fun_Non_Query(inslog);
                    Response.Redirect("Loginpage.aspx");
                }
            }
        }
    }
}