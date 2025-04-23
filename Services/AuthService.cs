using System;
using System.Collections.Generic;
using System.Linq;
using WebAPP5_6.AuthModels;

namespace WebAPP5_6.Services
{
    public class AuthService
    {
        //Testing (Replace with real database later)
        private static List<(string Username, string Password, string Permissions)> Users = new List<(string, string, string)>
        {
            ("admin", "admin123", "admin"),
            ("user1", "pass1", "user"),
            ("user2", "pass2", "user")
        };

        public LoginResponse Authenticate(LoginRequest request)
        {
            var user = Users.FirstOrDefault(u =>
                u.Username == request.Username && u.Password == request.Password);

            if (user == default)
            {
                return null; // Invalid login
            }

            return new LoginResponse
            {
                Username = user.Username,
                SessionID = Guid.NewGuid().ToString(), // Generate unique session ID
                Permissions = user.Permissions
            };
        }
    }
}