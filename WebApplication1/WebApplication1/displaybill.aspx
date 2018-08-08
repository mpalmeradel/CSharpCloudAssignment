<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaybill.aspx.cs" Inherits="WebApplication1.displaybill" %>
<%@Import namespace="WebApplication1.TafeDBServiceReference" %>
<%@Import namespace="WebApplication1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <%
        

        
         %>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Display Bill </h1>

        <asp:Button ID="Button1" runat="server" Text="Calculate Bill" OnClick="Button1_Click" />
        <asp:DropDownList ID="StudentDropDownList" runat="server"  OnSelectedIndexChanged="StudentDropDownList_SelectedIndexChanged" AppendDataBoundItems="False" CausesValidation="False" ValidateRequestMode="Inherit" />
        <br /><asp:Label ID="StudentNameLabel" runat="server" Text="Label"></asp:Label>
        <br /><asp:ListBox ID="CoursesListBox" runat="server" Height="153px" Width="550px"></asp:ListBox>
        <br /><asp:Label ID="CostLabel" runat="server" Text="Label"></asp:Label>
        
    </div>
    </form>
        

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
