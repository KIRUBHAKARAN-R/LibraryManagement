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
    public partial class Student : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DUMICIE2\\SQLEXPRESS;Initial Catalog=Lib;Integrated Security=True");

        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "insert into Book values ( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "') ";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label5.Text = "Student Details Has Saved..!!";

                }

                else

                {

                    Label5.Text = "Failed To Save Student Details ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label5.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }

            TextBox1.Text = "";

            TextBox2.Text = "";

            TextBox3.Text = "";

            TextBox4.Text = "";

            

        }
    }
    }
