<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSearchPersonnel.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmSearchPersonnel" %>

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
        <asp:Label ID="Label1" runat="server" Text="Search for employees by last name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmViewPersonnel.aspx" Text="Search" />
    </form>
</body>
</html>
