using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4B
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtSave_Click(object sender, EventArgs e)
        {
            Label1.Text = "Your Name is " + txtName.Text + " and you are from " +
            txtcity.Text;
        }
    }
}