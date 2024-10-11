using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Project1
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select C_Id,C_Name from CategoryTab";
                DataSet cmd = obj.Fun_exeAdapter(s);
                DropDownList1.DataSource = cmd;
                DropDownList1.DataTextField = "C_Name";
                DropDownList1.DataValueField = "C_Id";
                DropDownList1.DataBind();

                Bind_Grid();
            }
            
        }
        public void Bind_Grid()
        {
            string str = "select * from ProductTab where C_Id=" + DropDownList1.SelectedItem.Value + "";
            DataSet cmd = obj.Fun_exeAdapter(str);
            GridView1.DataSource = cmd;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //For the DropDownList to select index give the event SelectedIndexChanged
            //To change Label according to Item,put AutoPostBack True and give an if condition to pageload program.
            //To display information about one Id from DropDownlist in GridView
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
            TextBox cid = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            TextBox pname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox pprice = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox pdescription = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            FileUpload fileUpload = (FileUpload)GridView1.Rows[i].FindControl("fileUploadPhoto");
            TextBox ptype = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox pstatus = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            TextBox pstock = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            string p = "";

            // Check if a file has been uploaded
            if (fileUpload.HasFile)
            {
                p = "~/ProdPhoto/" + fileUpload.FileName;
                fileUpload.SaveAs(MapPath(p));
                //// Get the uploaded file's name
                //string filename = Path.GetFileName(fileUpload.PostedFile.FileName);

                //// Define the file path to save the uploaded image in the "CatPhoto" folder
                //string filepath = Server.MapPath("~/ProdPhoto/" + filename);

                //// Save the uploaded file to the server in the "CatPhoto" folder
                //fileUpload.SaveAs(filepath);
                //p = filename;
            }
            else
            {
                HiddenField hfPhoto = (HiddenField)GridView1.Rows[i].FindControl("hfPhoto");
                p = hfPhoto.Value;
            }
            string strup = "update ProductTab set C_Id=" + cid.Text + ",P_Name='" + pname.Text + "',P_Price=" + pprice.Text + ",P_Description='" + pdescription.Text + "',P_Image='" + p + "',P_Type='" + ptype.Text+ "',P_Status='" + pstatus.Text+ "',P_Stock='" + pstock.Text+"' where P_Id=" + getid + "";
            int j = obj.Fun_Non_Query(strup);
            if (j != 0)
            {
                Bind_Grid();
            }

            GridView1.EditIndex = -1;
            Bind_Grid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string p = "~/ProdPhoto/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into ProductTab values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'"+TextBox4.Text+"','"+p+"','"+TextBox5.Text+ "','Available','" + TextBox6.Text+"')";
            int i = obj.Fun_Non_Query(ins);
            if (i != 0)
            {
                Label1.Visible = true;
                Label1.Text = "Inserted";
            }
            Bind_Grid();
            Panel1.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomepage.aspx");
        }
    }
}