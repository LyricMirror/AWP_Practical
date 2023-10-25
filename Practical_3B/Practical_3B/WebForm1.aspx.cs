using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_3B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("stdetail.xml"));
            if (ds != null && ds.HasChanges())
            {
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataBind();
            }
        }
    }
}