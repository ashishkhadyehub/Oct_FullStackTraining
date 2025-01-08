using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullStackTraining.Sessions
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

//        CREATE TABLE[dbo].[DBUsers]
//        (

//    [Srno][int] IDENTITY(1,1) NOT NULL,

//    [Name] [nvarchar] (50) NULL,
//	[Contact][nvarchar] (50) NULL,
//	[Email][nvarchar] (50) NULL,
//	[City][nvarchar] (50) NULL,
//	[CreatedDate][date] NULL
//) ON[PRIMARY]

        //1.Create database table
        //2.Create UI form
        //3.Apply Required Validations
        //4.Setup connectionstring in web.config file
        //5.Create connection class in back end file
        //6.Write ado.net code to store data
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into DBUsers values (@name,@contact,@email,@city,@dt)", con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCity.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now.Date);

            con.Open();
            cmd.ExecuteNonQuery();

            txtContact.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            ddlCity.SelectedIndex = 0;

            Response.Write("<script>alert('Saved..!')</script>");
        }
    }
}