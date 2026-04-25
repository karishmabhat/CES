using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class ViewEnrollments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      if (!IsPostBack)
            {
                LoadEnrollments();
            }

        }

        void LoadEnrollments()
        {

            SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

            string query = @"

            SELECT Students.Name,
                   Students.Email,
                   Courses.CourseName

            FROM Enrollments

            JOIN Students ON Enrollments.StudentID = Students.StudentID
            JOIN Courses ON Enrollments.CourseID = Courses.CourseID

            ";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}