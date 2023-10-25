using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Practical_7A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string connStr = ConfigurationManager.ConnectionStrings["C1"].ConnectionString;
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from authors", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DropDownList1.DataSource = dr;
                DropDownList1.DataTextField = "Auname";
                DropDownList1.DataValueField = "phoneno";
                DropDownList1.DataBind();
                con.Close();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}