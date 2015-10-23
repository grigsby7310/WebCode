<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" />
    
    </div>
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/kgrigsby_Lab1_CIS407A/frmMain.aspx" OnAuthenticate="Login1_Authenticate" style="text-align: center" TitleText="Please enter your UserName and Password in order to log into the system.">
        </asp:Login>
    </form>
</body>
</html>
