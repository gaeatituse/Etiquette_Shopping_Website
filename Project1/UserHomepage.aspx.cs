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
    public partial class UserHomepage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cat = "select * from CategoryTab";
                DataSet cmd = obj.Fun_exeAdapter(cat);
                DataList1.DataSource = cmd;
                DataList1.DataBind();
            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
             int id = Convert.ToInt32(e.CommandArgument);
             Session["uid"] = id.ToString();
             Response.Redirect("UserProdPage.aspx");
        }
    }
    
}