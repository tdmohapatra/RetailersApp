<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductInvoicePage.aspx.cs" Inherits="RetailersApp.ProductInvoicePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                         :PRODUCT INVOICE PAGE:
            <table>
                <tr>
                    <td>CustomerName:</td>
                    <td><asp:TextBox ID="tbname" runat="server"></asp:TextBox></td>
                <tr>
                    <td>ItemCode:</td>
                    <td><asp:DropDownList ID="ddlItems" runat="server"></asp:DropDownList></td>
                </tr>
                 <tr>
                    <td>ItemModel:</td>
                    <td><asp:TextBox runat="server" ID="tbIModel"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>BatchNo:</td>
                    <td><asp:TextBox ID="tbBatch" runat="server"></asp:TextBox></td>
                </tr>
                  <tr>
                    <td>MFG_Date:</td>
                    <td><asp:TextBox ID="tbMDate" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>EXP_Date:</td>
                    <td><asp:TextBox ID="tbEDate" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Quantity:</td>
                    <td><asp:TextBox ID="tbQty" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Rate</td>
                    <td><asp:TextBox ID="tbrate" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>   
                 <tr>
                    <td></td>
                    <td><asp:Button ID="btnRegister" Text="REGISTER" runat="server" OnClick="btnRegister_Click" /></td>
                     <td><a href="HomePage.aspx">Go to Home Page?</a></td>
                </tr>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
