using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP5_6.AuthModels
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public string Username { get; set; }
        public string SessionID { get; set; }
        public string Permissions { get; set; }
    }
}