using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class SelectedIndexChangedExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCity.Text = ddlCity.SelectedItem.Text;
        }
    }
}