using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPP5_6.AuthModels;
using WebAPP5_6.Services;

namespace WebAPP5_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var request = new LoginRequest
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };

            var authService = new AuthService();
            var response = authService.Authenticate(request);
            if (response != null)
            {
                Session["username"] = response.Username;
                Session["sessionId"] = response.SessionID;
                Session["permissions"] = response.Permissions;

                Response.Redirect("Dashboard.aspx"); // Change to your next page
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }

        }
    }
}