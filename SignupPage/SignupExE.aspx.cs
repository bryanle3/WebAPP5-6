using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;
namespace WebAPP5_6
{
    public partial class SignupExE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtNewUser.Text.Trim();
            string password = txtNewPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblSignUpResult.Text = "Please enter both username and password.";
                return;
            }

            string path = Server.MapPath("~/App_Data/users.xml");
            XDocument doc;

            if (File.Exists(path))
            {
                doc = XDocument.Load(path);
            }
            else
            {
                // Create new document if it doesn't exist
                doc = new XDocument(new XElement("users"));
            }

            // Check for existing username
            bool userExists = doc.Descendants("user")
                                 .Any(u => u.Element("username")?.Value == username);

            if (userExists)
            {
                lblSignUpResult.Text = "Username already exists!";
                return;
            }

            ServiceReference1.ServiceClient encrypt_client = new ServiceReference1.ServiceClient();
            string encryptedPass = encrypt_client.Encrypt(password);

            XElement newUser = new XElement("user",
                new XElement("username", username),
                new XElement("password", encryptedPass)
            );

            doc.Root.Add(newUser);
            doc.Save(path);

            Response.Redirect("Placeholder.aspx");
        }
    }
}