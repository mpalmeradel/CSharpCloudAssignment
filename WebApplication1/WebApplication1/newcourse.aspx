<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newcourse.aspx.cs" Inherits="WebApplication1.newcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>New Course</h1>
    </div>

        <table style="width: 100%;">
        <tr>
            <td>Course ID</td>
            <td><asp:TextBox ID="CourseIDTextBox" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Course Name</td>
            <td><asp:TextBox ID="CourseNameTextBox" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Course Cost</td>
            <td><asp:TextBox ID="CourseCostTextBox" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td><asp:Button ID="AddButton" runat="server" Text="Add Course" OnClick="AddButton_Click" /></td>
            <td>&nbsp;</td>
            
        </tr>
    </table>
    <asp:Label ID="MessageLabel" runat="server"></asp:Label>

    </form>
    
    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
