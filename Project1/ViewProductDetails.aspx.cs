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
    public partial class ViewProductDetails : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string pdet = "select * from ProductTab where P_Id=" + Session["pid"] + "";
                SqlDataReader dr = obj.Fun_exeReader(pdet);
                while (dr.Read())
                {
                    Label1.Text = dr["P_Name"].ToString();
                    Image1.ImageUrl = dr["P_Image"].ToString();
                    Label2.Text = dr["P_Price"].ToString();
                    Label3.Text = dr["P_Description"].ToString();
                    Label4.Text = dr["P_Type"].ToString();
                    Label5.Text = dr["P_Status"].ToString();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string add = "select max(Cart_Id) from CartTab";
            string maxcartid = obj.Fun_Scalar(add);
            int cartid = 0;
            if (maxcartid=="")
            {
                cartid = 1;
            }
            else
            {
                int newcartid = Convert.ToInt32(maxcartid);
                cartid = newcartid + 1;
            }
            string ins = "insert into CartTab values(" + cartid + "," + Session["userid"] + "," + Session["pid"] + ",'"+Image1.ImageUrl+"',"+Convert.ToInt32(Label2.Text)+"," + Convert.ToInt32(TextBox1.Text) + "," + Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label2.Text) + ")";
            int cmd = obj.Fun_Non_Query(ins);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomepage.aspx");
        }
    }
}