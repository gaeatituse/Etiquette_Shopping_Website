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
    public partial class BillPage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string bill = "select UserRegTab.U_Id,UserRegTab.U_Name,UserRegTab.U_Address,UserRegTab.U_Pincode,BillTab.Bill_Id,BillTab.Bill_Date,BillTab.GrandTotal from UserRegTab join BillTab on UserRegTab.U_Id=BillTab.U_Id where BillTab.U_Id=" + Session["userid"] + "";
            SqlDataReader  dr= obj.Fun_exeReader(bill);
            while (dr.Read())
            {
                Label1.Text = dr["U_Name"].ToString();
                Label2.Text = dr["U_Address"].ToString();
                Label3.Text = dr["U_Pincode"].ToString();
                Label4.Text = dr["Bill_Id"].ToString();
                Label5.Text = dr["Bill_Date"].ToString();
                Label6.Text = dr["GrandTotal"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Balance_amountService.ServiceClient ob = new Balance_amountService.ServiceClient();
            int bal = Convert.ToInt32(ob.balance_check(TextBox1.Text));
            string gt= "select GrandTotal from BillTab where U_Id=" + Session["userid"] + "";
            SqlDataReader dr = obj.Fun_exeReader(gt);
            string userid = Session["userid"].ToString();
            int t = 0;
            while (dr.Read())
            {
                t = Convert.ToInt32(dr["GrandTotal"]);
            }
            if (bal > t)
            {
                string x = bal.ToString();
                string y = t.ToString();
                string upbal = ob.balance_update(x,y);
                string up = "update PaymentTab set Balance_amount='" + upbal + "' where U_Id=" + Session["userid"] + "";
                int i = obj.Fun_Non_Query(up);
                Response.Redirect("Paymentpage.aspx");


            }
            else
            {
                Label7.Visible = true;
                Label7.Text = "Insufficient balance";
            }
        }
    }
}