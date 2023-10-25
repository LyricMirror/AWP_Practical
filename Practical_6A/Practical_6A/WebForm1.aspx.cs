using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practical_6A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["C1"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(TextBox1.Text, con);
            SqlDataReader dr = cmd.ExecuteReader();
            ListBox1.Items.Clear();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    ListBox1.Items.Add(dr[i].ToString());
                }
            }
            dr.Close();
            con.Close();
        }
    }
}