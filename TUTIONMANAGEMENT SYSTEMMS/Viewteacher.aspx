<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewteacher.aspx.cs" Inherits="TUTIONMANAGEMENT_SYSTEMMS.Viewteacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

<asp:GridView ID="gvTeachers" runat="server" AutoGenerateColumns="False" DataKeyNames="TeacherID">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Address" HeaderText="Address" />
        <asp:BoundField DataField="Contact" HeaderText="Contact" />
        <asp:BoundField DataField="Class" HeaderText="Class" />
        <asp:BoundField DataField="Username" HeaderText="Username" />
        <asp:BoundField DataField="Password" HeaderText="Password" />
        <asp:BoundField DataField="Role" HeaderText="Role" />
    </Columns>
</asp:GridView>

         
    </div>

    </form>
</body>
</html>
