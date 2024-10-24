using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-8BF3B0H\SQLEXPRESS;database=Project1;Integrated security=True");
        }
        public int Fun_Non_Query(string sql)
        {
            if (con.State == ConnectionState.Open)//To check when to close the connection.
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fun_Scalar(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader Fun_exeReader(string sqlquery)//select ....Since datareader is operating,SqlDataReader is the return type of the function
        {
            if (con.State == ConnectionState.Open)//To check when to close the connection.
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();//Here con.Close() is not given since the data is reading ..hence if we give that command,all the read datas will be removed.
            return dr;
        }

        public DataSet Fun_exeAdapter(string sqlquery)//select...DataSet is a collection of DataTables or mirrorcopy of Database.
        {
            if (con.State == ConnectionState.Open)//To check when to close the connection.
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}