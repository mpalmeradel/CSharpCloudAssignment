<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enrolstudent.aspx.cs" Inherits="WebApplication1.enrolstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Enrol Student</h1>
    </div>

        <table style="width: 100%;">
            <tr>
                <td>Course</td>
                <td>Student</td>
                
            </tr>
            <tr>
                <td><asp:DropDownList ID="CourseDropDownList" runat="server"></asp:DropDownList></td>
                <td><asp:DropDownList ID="StudentDropDownList" runat="server"></asp:DropDownList></td>
                
            </tr>
            <tr>
            <td><asp:Button ID="EnrolButton" runat="server" Text="Enrol" onClick="EnrolButton_Click"/><br /> </td>
                </tr>
            <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        </table>

    </form>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
