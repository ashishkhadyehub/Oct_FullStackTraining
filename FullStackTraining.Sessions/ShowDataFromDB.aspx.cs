﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class ShowDataFromDB : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            getUserData();
        }

        protected void getUserData()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select top 1 * from DBUsers order by Srno DESC",con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();    
            if(sdr.HasRows)
            {
                sdr.Read();
                txtName.Text = sdr.GetValue(1).ToString();
                txtContact.Text = sdr.GetValue(2).ToString();
                txtEmail.Text = sdr.GetValue(3).ToString();
                txtCity.Text = sdr.GetValue(4).ToString();
                imgProfilePhoto.ImageUrl = sdr.GetValue(6).ToString();
                thumbImg.ImageUrl = sdr.GetValue(7).ToString();
            }
        }
    }
}