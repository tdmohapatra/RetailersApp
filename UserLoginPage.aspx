<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLoginPage.aspx.cs" Inherits="RetailersApp.UserLoginPage" %>

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
                    <td>USER_NAME:</td>
                    <td><asp:TextBox ID="tbNmae" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>PASSWORD:</td>
                    <td><asp:TextBox ID="tbPwd" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td></td>
                    <td><asp:Button ID="btnLogin" Text="LOGIN" runat="server" OnClick="btnLogin_Click" /></td>
                     <td><a href="UserRegistrationPage.aspx">RegisterNow?</a></> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
