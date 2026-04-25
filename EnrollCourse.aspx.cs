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
    public partial class EnrollCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentID"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }

            if (!IsPostBack)
            {
                LoadCourses();
            }
        }

        void LoadCourses()
        {

            SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

            string q = "SELECT * FROM Courses";

            SqlDataAdapter da = new SqlDataAdapter(q, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            RepeaterCourses.DataSource = dt;
            RepeaterCourses.DataBind();
        }

        protected void EnrollCourse_Click(object sender, EventArgs e)
{
    int studentId = Convert.ToInt32(Session["StudentID"]);
    int courseId = Convert.ToInt32(((Button)sender).CommandArgument);

    SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    // Check if already enrolled
    string checkQuery = "SELECT COUNT(*) FROM Enrollments WHERE StudentID=@sid AND CourseID=@cid";

    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
    checkCmd.Parameters.AddWithValue("@sid", studentId);
    checkCmd.Parameters.AddWithValue("@cid", courseId);

    con.Open();

    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

    if (count > 0)
    {
        // Already enrolled alert
        ClientScript.RegisterStartupScript(
        this.GetType(),
        "alert",
        "swal({title:'Already Enrolled', text:'You already enrolled in this course', icon:'warning'});",
        true);
    }
    else
    {
        // Insert enrollment
        string insertQuery = "INSERT INTO Enrollments(StudentID,CourseID) VALUES(@sid,@cid)";

        SqlCommand cmd = new SqlCommand(insertQuery, con);

        cmd.Parameters.AddWithValue("@sid", studentId);
        cmd.Parameters.AddWithValue("@cid", courseId);

        cmd.ExecuteNonQuery();

        ClientScript.RegisterStartupScript(
        this.GetType(),
        "alert",
        "swal({title:'Success', text:'Course Enrolled Successfully', icon:'success'});",
        true);
    }

    con.Close();
}

    }
}