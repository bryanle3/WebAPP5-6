using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP5_6
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] != null && Session["permissions"] != null)
                {
                    lblUser.Text = $"Welcome, {Session["username"]}!";
                    lblRole.Text = $"Role: {Session["permissions"]}";
                }
                else
                {
                    // If session is missing, redirect to login
                    Response.Redirect("Login.aspx");

                }
            }
        }
    }
}