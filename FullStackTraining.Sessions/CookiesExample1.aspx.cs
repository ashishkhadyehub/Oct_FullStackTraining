﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class CookiesExample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"]=txtName.Text;
            cookie["Contact"]=txtContact.Text;

            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);

            Response.Redirect("CookiesExample2.aspx");

        }
    }
}