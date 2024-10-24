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
    public partial class ViewCart : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Grid();
            }
        }
        public void Bind_Grid()
        {
            string grid = "select * from CartTab where U_Id="+Session["userid"]+"";
            DataSet cmd = obj.Fun_exeAdapter(grid);
            GridView1.DataSource = cmd;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from CartTab where Cart_Id=" + getid + "";
            int cmd = obj.Fun_Non_Query(del);

            Bind_Grid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string price = "select P_Price from CartTab where Cart_Id=" + getid + "";
            string unitprice = obj.Fun_Scalar(price);
            

            TextBox txtquantity = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string strup = "update CartTab set Quantity=" + txtquantity.Text + ",TotalPrize=" + Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(unitprice) + " where Cart_Id="+getid+"";
            int j = obj.Fun_Non_Query(strup);

            GridView1.EditIndex = -1;
            Bind_Grid();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Cart_Id) from CartTab";
            string cmd = obj.Fun_Scalar(s);
            int n = Convert.ToInt32(cmd);
            for(int i = 1; i <= n; i++)
            {
                string se = "select * from CartTab where Cart_Id=" + i + "";
                SqlDataReader dr = obj.Fun_exeReader(se);
                int pid=0,uid=0,quantity=0,totalprice=0;
                while (dr.Read())
                {
                    pid = Convert.ToInt32(dr["P_Id"]);
                    uid = Convert.ToInt32(dr["U_Id"]);
                    quantity = Convert.ToInt32(dr["Quantity"]);
                    totalprice =Convert.ToInt32(dr["TotalPrize"]);
                }
                string oins="insert into OrderTab values("+pid+","+uid+","+quantity+","+totalprice+",'"+DateTime.UtcNow.ToString("yyyy-MM-dd") +"','Ordered')";
                int j = obj.Fun_Non_Query(oins);
                string cdel = "delete from CartTab where Cart_Id=" + i + "";
                int k = obj.Fun_Non_Query(cdel);    
            }
            Response.Redirect("OrderPage.aspx");
            
        }
    }
}