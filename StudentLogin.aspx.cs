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
    public partial class StudentLogin : System.Web.UI.Page
    {
         protected void btnlogin_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

            string query = "select * from Students where Email=@e and Password=@p";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@e", txtemail.Text);
            cmd.Parameters.AddWithValue("@p", txtpass.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

             if (dr.Read())
            {
                 Session["StudentID"] = dr["StudentID"].ToString();
                Session["email"] = dr["Email"].ToString();

                Response.Redirect("EnrollCourse.aspx");
            }
            else
            {
ClientScript.RegisterStartupScript(
this.GetType(),
"alert",
"swal({title:'Invalid Login', text:'Wrong Email or Password', icon:'error', button:'Try Again'});",
true);
                
            }

            con.Close();
        }
    }
}