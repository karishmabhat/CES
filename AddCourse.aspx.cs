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
    public partial class AddCourse : System.Web.UI.Page
    {
              protected void btnadd_Click(object sender, EventArgs e)
        {
 SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

            string q = "INSERT INTO Courses(CourseName,Description) VALUES(@c,@d)";

            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@c", txtcourse.Text);
            cmd.Parameters.AddWithValue("@d", txtdesc.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ClientScript.RegisterStartupScript(
this.GetType(),
"alert",
"swal({title:'Success', text:'Course Added Successfully', icon:'success'}).then(function(){ window.location='AddCourse.aspx'; });",
true);

        }
    }
}