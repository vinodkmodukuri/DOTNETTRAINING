using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDOTNETWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void brnusername_Click(object sender, EventArgs e)
        {
            Response.Write("Enter the user name" + txtusername.Text);

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}