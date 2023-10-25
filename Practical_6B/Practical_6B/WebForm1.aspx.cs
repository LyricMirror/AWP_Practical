using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Practical_6B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["c1"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("Select Ename, Esal from Emp", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Label1.Text += reader["Ename"].ToString() + " " + reader["Esal"].ToString() + "<br>";
            }
            reader.Close();
            con.Close();
        }
    }
}