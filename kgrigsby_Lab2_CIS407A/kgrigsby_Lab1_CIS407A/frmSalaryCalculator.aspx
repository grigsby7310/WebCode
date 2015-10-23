<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/kgrigsby_Lab1_CIS407A/Images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/kgrigsby_Lab1_CIS407A/frmMain.aspx">HyperLink</asp:HyperLink>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Annual Hours:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAnnualHours" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pay Rate:" width="86px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculateSalary_Click" Text="Calculate Salary" />
        <br />
        <br />
        <asp:Label ID="lblAnnualSalary" runat="server" Text="$"></asp:Label>
    
    </div>
    </form>
</body>
</html>
