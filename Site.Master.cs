using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CES
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["StudentID"] != null)
            {
                lihome.Visible = false;
                lilogout.Visible = true;
                lilogin.Visible = false;
                liregister.Visible = false;
                liadmin.Visible = false;
                
            }
            else
            {
                lihome.Visible= true;
                lilogout.Visible = false;
                lilogin.Visible = true;
                liregister.Visible = true;
                liadmin.Visible = true;
                
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }
}