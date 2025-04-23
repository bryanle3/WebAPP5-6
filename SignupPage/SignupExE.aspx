<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignupExE.aspx.cs" Inherits="WebAPP5_6.SignupExE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h3>Sign Up</h3>
<asp:TextBox ID="txtNewUser" runat="server" Placeholder="Username"></asp:TextBox><br />
<asp:TextBox ID="txtNewPass" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox><br />
<asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" /><br />
<asp:Label ID="lblSignUpResult" runat="server" ForeColor="Green"></asp:Label>

        </div>
    </form>
</body>
</html>
