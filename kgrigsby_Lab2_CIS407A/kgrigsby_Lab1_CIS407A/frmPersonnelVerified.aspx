<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerified.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmPersonnelVerified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/kgrigsby_Lab1_CIS407A/frmMain.aspx">HyperLink</asp:HyperLink>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="650px">
            <asp:Label ID="Label1" runat="server" Text="Information to Submit:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmViewPersonnel.aspx" Text="View Personnel" />
        </asp:Panel>
    </form>
</body>
</html>
