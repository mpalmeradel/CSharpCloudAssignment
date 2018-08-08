<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstudents.aspx.cs" Inherits="WebApplication1.viewstudents" %>
<%@Import namespace="WebApplication1.TafeDBServiceReference" %>
<%@Import namespace="WebApplication1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

    <%
        
        Tafe_DataTier dt = new Tafe_DataTier();

        List<Student> students = dt.viewStudents();        

         %>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>View Students</h1>
    </div>
    </form>

    <%foreach(Student s in students)
        {
            %> <br /> Student Name:  <% = s.StudentName %> (ID = <% = s.StudentID %>) <%
        }

                 %>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
