<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studenttimetable.aspx.cs" Inherits="WebApplication1.studenttimetable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Student Time Table</h1>
    </div>

        Select Student <br />
        <asp:DropDownList ID="StudentDropDownList" runat="server"></asp:DropDownList> <br />
        <asp:Button ID="GenerateButton" runat="server" Text="Generate Timetable" OnClick="GenerateButton_Click" /> <br />
        <asp:ListBox ID="TimetableListBox" runat="server" Height="308px" Width="391px"></asp:ListBox>


    </form>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
