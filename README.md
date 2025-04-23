✅ What’s Implemented

✅ Login functionality using LoginRequest and LoginResponse classes

✅ Sign-Up functionality that stores user credentials in App_Data/users.xml

✅ Password encryption using a service (ServiceClient.Encrypt())

✅ Authentication logic via AuthService.cs

✅ Session handling using ASP.NET Session objects

✅ Dashboard.aspx page protected by session validation

✅ Displays logged-in user info and role-based access

✅ Clean folder organization (AuthModels, Services, etc.)

🚀 How to Run the Project
Open the solution in Visual Studio.

Set either Pages/Login.aspx or Pages/SignUp.aspx as the start page.

Press Ctrl + F5 to run without debugging.

You can either:

Sign up to create a new user

Or log in using an existing account (see below)

Note: If you've moved .aspx files into folders like /Pages/, make sure your redirect paths and Start Page are updated accordingly.

🔐 Sign-Up Flow
Navigate to the Sign-Up page

Enter a unique username and a password

The password is encrypted and saved into App_Data/users.xml

If the username already exists, an error message will be shown

Admin Account: Admin Admin123

