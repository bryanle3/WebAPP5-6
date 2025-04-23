using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Xml.Linq;
using WebAPP5_6.AuthModels;

namespace WebAPP5_6.Services
{
    public class AuthService
    {
        //Testing (Replace with real database later)
        private List<(string Username, string Password, string Permissions)> LoadUsersFromXml()
        {
            string path = HostingEnvironment.MapPath("~/App_Data/users.xml");

            if (!File.Exists(path))
                throw new FileNotFoundException("users.xml not found at: " + path);

            XDocument doc = XDocument.Load(path);

            var users = doc.Descendants("user")
                .Select(u => (
                    Username: (string)u.Element("username"),
                    Password: (string)u.Element("password"),
                    Permissions: u.Element("permissions") != null ? (string)u.Element("permissions") : "user"
                ))
                .ToList();

            return users;
        }

        public LoginResponse Authenticate(LoginRequest request)
        {
            var users = LoadUsersFromXml();

            // Call the encryption service to encrypt the password before comparing
            var encrypt_client = new ServiceReference1.ServiceClient();
            string encryptedPassword = encrypt_client.Encrypt(request.Password);

            // Match user
            var user = users.FirstOrDefault(u =>
                u.Username == request.Username &&
                u.Password == encryptedPassword
            );

            if (user == default)
                return null; // invalid login

            return new LoginResponse
            {
                Username = user.Username,
                SessionID = Guid.NewGuid().ToString(),
                Permissions = user.Permissions
            };
        }
    }
}