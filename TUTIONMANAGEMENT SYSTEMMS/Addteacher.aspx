<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addteacher.aspx.cs" Inherits="TUTIONMANAGEMENT_SYSTEMMS.Addteacher" %>

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
        <label>Contact:</label>
        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox><br />
        <label>Class:</label>
        <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
        <br />
            <label>Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Role"></asp:Label>
        :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAddTeacher" runat="server" Text="Add Teacher" OnClick="btnAddTeacher_Click" />
    </div>
</form>

     
</body>
</html>
