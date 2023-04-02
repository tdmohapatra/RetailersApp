<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RetailersApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <asp:Button ID="btnUReg" runat="server" Text="ITEMS NAME REGISTRATION" OnClick="btnUReg_Click"/>
            <asp:Button ID="btnRefresh" runat="server" Text="REFRESH" OnClick="btnRefresh_Click" />
            <asp:Button ID="btnOrderItem" runat="server" Text="ORDER ITEMS" OnClick="btnOrderItem_Click"/>
            <asp:Button ID="btnEditItem" runat="server" Text="EDIT ITEMS" OnClick="btnEditItem_Click"/>
            <asp:Button ID="btnDisplay" runat="server" Text="DISPLAY" OnClick="btnDisplay_Click"  />
            <asp:Button ID="btnRemove" runat="server" Text="REMOVEITEM" OnClick="btnRemove_Click"  />
            <table>
                <tr>
                    <td>PRODUCT_CODE:</td>
                    <td><asp:TextBox ID="tbItem" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="btnSearch" runat="server"  Text="Search" OnClick="btnSearch_Click"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="lblDisplay" runat="server" Text="please enter  thr product Code!"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:GridView ID="grdvDisplay" runat="server"></asp:GridView><br /></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td><asp:Button ID="btnLogout" runat="server"  Text="LOGOUT" OnClick="btnLogout_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
