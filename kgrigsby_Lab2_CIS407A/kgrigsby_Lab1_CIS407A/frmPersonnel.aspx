<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmPersonnel" %>

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
        <asp:Panel ID="Panel1" runat="server" Height="292px" HorizontalAlign="Left" Width="549px">
            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Field must be populated!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Field must be populated!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="71px"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Field must be populated!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Start Date:" width="71px"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Incorrect date format! (mm/dd/yyyy)" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$" ControlToValidate="txtStartDate"></asp:RegularExpressionValidator>
            &nbsp;<br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="End Date:" width="71px"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate" ErrorMessage="Incorrect date format! (mm/dd/yyyy)" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
