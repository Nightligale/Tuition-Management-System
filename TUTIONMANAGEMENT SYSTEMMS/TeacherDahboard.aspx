<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherDahboard.aspx.cs" Inherits="TUTIONMANAGEMENT_SYSTEMMS.TeacherDahboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome, <asp:Label ID="lblTeacherName" runat="server"></asp:Label></h2>
            <h3>Student List</h3>
            <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentID">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Class" HeaderText="Class" />
                    <asp:BoundField DataField="EducationalStatus" HeaderText="Educational Status" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
