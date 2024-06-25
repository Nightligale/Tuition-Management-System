<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="TUTIONMANAGEMENT_SYSTEMMS.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            
            <h2>Dashboard</h2>
            <h3>Class with the most excellent students: </h3>
            <asp:Label ID="lblMostExcellentClass" runat="server"></asp:Label><br />
            <h3>Class with the average students: </h3>
            <asp:Label ID="lblAverageClass" runat="server"></asp:Label><br />
            <h3>Class with the poor students: </h3>
            <asp:Label ID="lblPoorClass" runat="server"></asp:Label><br />


        </div>
    </form>
</body>
</html>
