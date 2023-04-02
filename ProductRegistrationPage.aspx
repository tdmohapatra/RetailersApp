<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRegistrationPage.aspx.cs" Inherits="RetailersApp.ProductRegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                PRODUCT REGISTRATION PAGE<br />
            <br />
&nbsp;<table>
                <tr>
                   <td>ITEM_CODE:</td>
                    <td><asp:TextBox ID="tbItemCode" runat="server"></asp:TextBox></td>
                </tr> 
                 <tr>
                   <td>ITEM_NAME:</td>
                    <td><asp:TextBox ID="tbItemName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                   <td></td>
                    <td><asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="btnRegister_Click" /></td>
                    <td><a href="HomePage.aspx">GO to Home Page>></a></td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
