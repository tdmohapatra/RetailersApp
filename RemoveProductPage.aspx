<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveProductPage.aspx.cs" Inherits="RetailersApp.RemoveProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <form id="form2" runat="server">
              <div>
                        ITEM STORE REGISTRATION:
            <table>
                   <tr>
                    <td>BatchNo:</td>
                    <td><asp:TextBox ID="tbBatch" runat="server"></asp:TextBox></td>
                      <td><asp:Button ID="btnDispaly" runat="server" Text="Display" OnClick="btnDispaly_Click"/></td>
                </tr>
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
                    <td><asp:Button ID="btnRegister" Text="REMOVE" runat="server" OnClick="btnRegister_Click" /></td>
                     <td><a href="HomePage.aspx">Go to Home Page?</a></td>
                </tr>
                </tr>
            </table>
        </div>
    </form>
        </div>
    </form>
</body>
</html>
