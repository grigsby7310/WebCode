<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUserActivity.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmUserActivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 435px">
    
        <asp:ImageButton ID="ImageButton1" runat="server" Height="116px" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmMain.aspx" Width="423px" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="177px" Width="580px">
            <asp:Label ID="Label1" runat="server" Text="User Activity"></asp:Label>
            <br />
            <asp:GridView ID="grdUserActivity" runat="server">
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
