<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewcourses.aspx.cs" Inherits="WebApplication1.viewcourse" %>
<%@Import namespace="WebApplication1.TafeDBServiceReference" %>
<%@Import namespace="WebApplication1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     <%
        
        Tafe_DataTier dt = new Tafe_DataTier();

        List<Course> courses = dt.viewCourses();        

         %>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>View Courses</h1>
    </div>
    </form>

    <%
        foreach(Course c in courses)
        {%>
            <br />Course Name : <%= c.CourseName %> (ID = <% =c.CourseID %> )
        <%}
         %>

    <h4>
            <a href="index.aspx">Go Back</a>
    </h4>
</body>
</html>
