# WebAPP5-6
This project includes the following components that I implemented:

- ✅ Login functionality using `LoginRequest` and `LoginResponse` classes
- ✅ Authentication logic via `AuthService.cs`
- ✅ Session handling using ASP.NET `Session` objects
- ✅ Protected pages (`Dashboard.aspx`) with session validation
- ✅ Display of logged-in user's info and role
- ✅ Basic file organization using folders like `AuthModels` and `Services`

 How to Run
1. Open the solution in **Visual Studio**.
2. Set `Login.aspx` or `Pages/Login.aspx` as the **start page**.
3. Run the project (Ctrl + F5).
4. Enter one of the test users below to log in.
5. Upon successful login, you will be redirected to the **Dashboard**.

>  Make sure to update redirect paths if you've moved `.aspx` files into folders like `/Pages/`.

## 🔐 Test Users

| Username | Password   | Role  |
|----------|------------|-------|
| admin    | admin123   | admin |
| user1    | pass1      | user  |
| user2    | pass2      | user  |

These users are stored in the mock user list inside `AuthService.cs`.
