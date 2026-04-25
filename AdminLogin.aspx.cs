using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "admin123")
            {
                Session["Admin"] = txtuser.Text;
                Response.Redirect("AddCourse.aspx");
            }
            else
            {
               ClientScript.RegisterStartupScript(
this.GetType(),
"alert",
"swal('Invalid Admin','Username or Password is incorrect','error');",
true);
            }
        }
    }
}