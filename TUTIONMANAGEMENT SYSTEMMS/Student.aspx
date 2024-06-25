<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="TUTIONMANAGEMENT_SYSTEMMS.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


         
        <label>Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <label>Address:</label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
        <label>Class:</label>
        <asp:TextBox ID="txtClass" runat="server"></asp:TextBox><br />
        <label>Educational Status:</label>
        <asp:DropDownList ID="ddlStatus" runat="server">
            <asp:ListItem Text="Excellent" Value="Excellent"></asp:ListItem>
            <asp:ListItem Text="Good" Value="Good"></asp:ListItem>
            <asp:ListItem Text="Average" Value="Average"></asp:ListItem>
            <asp:ListItem Text="Poor" Value="Poor"></asp:ListItem>
        </asp:DropDownList>
            <br />
            <label>Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Role"></asp:Label>
            :<asp:TextBox ID="txtrole" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" />
    </div>

    </form>
</body>
</html>
