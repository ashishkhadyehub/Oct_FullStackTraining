using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //Response.Redirect("QueryString2.aspx?name="+txtName.Text+"&contact="+txtContact.Text+"");
            Response.Redirect($"QueryString2.aspx?name={txtName.Text}&contact={txtContact.Text}");
        }
    }
}