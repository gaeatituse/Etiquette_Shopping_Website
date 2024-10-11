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
    public partial class CategoryEdit : System.Web.UI.Page
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
            string grid = "select * from CategoryTab";
            DataSet cmd = obj.Fun_exeAdapter(grid);
            GridView1.DataSource = cmd;
            GridView1.DataBind();
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
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            FileUpload fileUpload = (FileUpload)GridView1.Rows[i].FindControl("fileUploadPhoto");
            TextBox txtdescription = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string p = "";

            // Check if a file has been uploaded
            if (fileUpload.HasFile)
            {
                p = "~/CatPhoto/" + fileUpload.FileName;
                fileUpload.SaveAs(MapPath(p));
                //// Get the uploaded file's name
                //string filename = Path.GetFileName(fileUpload.PostedFile.FileName);

                //// Define the file path to save the uploaded image in the "CatPhoto" folder
                //string filepath = Server.MapPath("~/CatPhoto/" + filename);

                //// Save the uploaded file to the server in the "CatPhoto" folder
                //fileUpload.SaveAs(filepath);

                //// Set the path for saving into the database (relative path)
                //p = filename;
            }
            else
            {
                HiddenField hfPhoto = (HiddenField)GridView1.Rows[i].FindControl("hfPhoto");
                p = hfPhoto.Value;
            }
            string strup = "update CategoryTab set C_Name='" + txtname.Text + "',C_Photo='"+p+"',C_Description='" + txtdescription.Text + "',C_Status='"+txtstatus.Text+"' where C_Id=" + getid + "";
            int j = obj.Fun_Non_Query(strup);
            if (j != 0)
            {
                Bind_Grid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string p = "~/CatPhoto/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into CategoryTab values('" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','Available')";
            int i = obj.Fun_Non_Query(ins);
            if (i != 0)
            {
                Label1.Visible = true;
                Label1.Text = "Inserted";
            }
            Bind_Grid();
            Panel1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomepage.aspx");
        }
    }
}