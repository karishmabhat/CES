using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class MyCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 if (!IsPostBack)
            {
                LoadCourses();
            }

        }

       void LoadCourses()
{
    SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    int studentId = Convert.ToInt32(Session["StudentID"]);

    string query = @"select Courses.CourseName
                     from Enrollments
                     join Courses on Enrollments.CourseId = Courses.CourseId
                     where StudentID=@sid";

    SqlCommand cmd = new SqlCommand(query, con);

    cmd.Parameters.AddWithValue("@sid", studentId);

    SqlDataAdapter da = new SqlDataAdapter(cmd);

    System.Data.DataTable dt = new System.Data.DataTable();

    da.Fill(dt);

    GridView1.DataSource = dt;
    GridView1.DataBind();
}
}
}
