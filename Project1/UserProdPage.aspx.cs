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
    public partial class UserProdPage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Data();
            }   

        }
        public void Bind_Data()
        {
            string psel = "select * from ProductTab where C_Id=" + Session["uid"] + "";
            DataSet cmd = obj.Fun_exeAdapter(psel);
            DataList1.DataSource = cmd;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id1 = Convert.ToInt32(e.CommandArgument);
            Session["pid"] = id1.ToString();
            Response.Redirect("ViewProductDetails.aspx");
        }
    }
}