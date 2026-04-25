using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class StudentRegister : System.Web.UI.Page
    {
       protected void btnregister_Click1(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

            string query = "insert into Students(Name,Email,Password) values(@n,@e,@p)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", txtname.Text);
            cmd.Parameters.AddWithValue("@e", txtemail.Text);
            cmd.Parameters.AddWithValue("@p", txtpass.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ClientScript.RegisterStartupScript(
this.GetType(),
"alert",
"swal('Registered Successfully!','Please login now','success').then(()=>{ window.location='StudentLogin.aspx';});",
true);
        }
    }
}