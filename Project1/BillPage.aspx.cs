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
    }
}