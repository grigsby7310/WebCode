<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" Width="393px" />
    
    </div>
        <asp:Panel runat="server" Height="1235px" Width="500px">
            <asp:ImageButton ID="imgbtnCalculator" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Calculator.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmSalaryCalculator.aspx" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Personnel.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmPersonnel.aspx" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="88px" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Activity.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmUserActivity.aspx" Width="105px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmUserActivity.aspx">View User Activity</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/ViewPersonnel.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmViewPersonnel.aspx" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnSearch" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Search.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmSearchPersonnel.aspx" />
            &nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Edit.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmEditPersonnel.aspx" Width="128px" />
            &nbsp;&nbsp;
            <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/Gears.JPG" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmManageUsers.aspx" Width="135px" />
            &nbsp;
            <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/kgrigsby_Lab1_CIS407A/frmManageUsers.aspx">Manage Users</asp:LinkButton>
        </asp:Panel>
    </form>
</body>
</html>
