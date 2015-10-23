<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmViewPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmMain.aspx" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Personnel"></asp:Label>
            <br />
            <asp:GridView ID="grdViewPersonnel" runat="server">
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
