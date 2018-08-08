<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewenrolments.aspx.cs" Inherits="WebApplication1.viewenrolments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>View Enrolments</h1>
    </div>

        Select Course <br />
        <asp:DropDownList ID="CourseDropDownList" runat="server"></asp:DropDownList> <br />
        <asp:Button ID="GenerateButton" runat="server" Text="Generate" OnClick="GenerateButton_Click" /> <br />
        <asp:ListBox ID="CourseListBox" runat="server" Height="309px" Width="375px"></asp:ListBox>

    </form>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
