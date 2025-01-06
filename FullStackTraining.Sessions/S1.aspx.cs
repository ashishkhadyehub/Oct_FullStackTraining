using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class S1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //20 mins=default expiry time in case of inactivity
            Session["Name"] = txtName.Text;
            Session["Contact"]=txtContact.Text;
            //Session.Timeout = 60;
            Response.Redirect("S2.aspx");
        }
    }
}