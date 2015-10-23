<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="kgrigsby_Lab1_CIS407A_frmManageUsers" %>

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
        <asp:Panel ID="Panel1" runat="server" Width="509px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Manage Users"></asp:Label>
            <br />
            <br />
            User Name:&nbsp;&nbsp;
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Security Level:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlSecurityLevel" runat="server">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>U</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add User" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Current Users:"></asp:Label>
            <asp:GridView ID="grdUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="AccessDataSource1">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                    <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <EmptyDataTemplate>
                    UserID
                </EmptyDataTemplate>
            </asp:GridView>
            <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/kgrigsby_Lab1_CIS407A/PayrollSystem_DB.accdb" SelectCommand="SELECT * FROM [tblUserLogin]" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = @UserID" UpdateCommand="UPDATE [tblUserLogin] SET [UserName]=?, [UserPassword]=?, [SecurityLevel]=? WHERE [UserID] = @UserID"></asp:AccessDataSource>
           
            <br />
        </asp:Panel>
    </form>
</body>
</html>
