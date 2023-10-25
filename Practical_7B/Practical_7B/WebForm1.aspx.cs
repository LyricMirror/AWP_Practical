using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_7B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr =
            ConfigurationManager.ConnectionStrings["C1"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            string InsertQuery = "insert into Branch values(@ADDRESS, @CITY, @NAME, @STATE, @ZIP_CODE)";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@ADDRESS", TextBox1.Text);
            cmd.Parameters.AddWithValue("@CITY", TextBox2.Text);
            cmd.Parameters.AddWithValue("@NAME", TextBox3.Text);
            cmd.Parameters.AddWithValue("@STATE", TextBox4.Text);
            cmd.Parameters.AddWithValue("@ZIP_CODE", TextBox5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label6.Text = "Record Inserted Successfuly.";
            con.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr =
            ConfigurationManager.ConnectionStrings["C1"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            string InsertQuery = "delete from branch where NAME=@NAME";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@NAME", TextBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label6.Text = "Record Deleted Successfuly.";
            con.Close();
        }
    }
}