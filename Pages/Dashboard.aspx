<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebAPP5_6.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Welcome to the Dashboard!</h2>
            <asp:Label ID="lblUser" runat="server" Font-Bold="True" /><br />
            <asp:Label ID="lblRole" runat="server" />
            <p>You are now logged in.</p>
        </div>
    </form>
</body>
</html>
