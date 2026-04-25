using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
            {
                // ❌ Not logged in → redirect
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                // ✅ Logged in → show only logout
                lihome.Visible = false;
                lilogin.Visible = false;
                liregister.Visible = false;
                liadmin.Visible = false;
                lilogout.Visible = true;
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}