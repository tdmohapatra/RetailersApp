<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistrationPage.aspx.cs" Inherits="RetailersApp.UserRegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
                <tr>
                    <td>USER_NMAE:</td>
                    <td><asp:TextBox ID="tbNmae" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>USER_EMAIL:</td>
                    <td><asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>PASSWORD:</td>
                    <td><asp:TextBox ID="tbPwd" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>USER_PHN:</td>
                    <td><asp:TextBox ID="tbPhn" runat="server" TextMode="Phone"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td></td>
                    <td><asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="btnRegister_Click"/></td>
                      <td><a href="UserLoginPage.aspx">Go To Login page</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
