<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newstudent.aspx.cs" Inherits="WebApplication1.newstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>New Student</h1>

        <table style="width: 100%;">
            <tr>
                <td>Student Name</td>
                <td><asp:TextBox ID="StudentNameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Student ID</td>
                <td><asp:TextBox ID="StudentIDTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="AddButton" runat="server" Text="Add Student" OnClick="AddButton_Click" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>

    </div>
    </form>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
