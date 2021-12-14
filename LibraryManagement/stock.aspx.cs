using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // compulsory for ado.net

using System.Data.SqlClient; // compulsory for ado.net

namespace LibraryManagement
{
    public partial class stock : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DUMICIE2\\SQLEXPRESS;Initial Catalog=Lib;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string s = "select * from dbo.Book[Data]";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = "select * from dbo.Book[Data] where Stock='" + DropDownList1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet("SqlDataSource1");
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
           
            }
        }
    }


        
    