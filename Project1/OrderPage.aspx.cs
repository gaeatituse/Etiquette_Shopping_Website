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
    public partial class OrderPage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select sum(TotalPrize) from OrderTab";
            string cmd = obj.Fun_Scalar(s);
            int n = Convert.ToInt32(cmd);
            string bins = "insert into BillTab values(" + Session["userid"] + ",'" + DateTime.UtcNow.ToString("yyyy/MM/dd") + "'," + n + ")";
            int j = obj.Fun_Non_Query(bins);
            Response.Redirect("BillPage.aspx");
        }
    }
}