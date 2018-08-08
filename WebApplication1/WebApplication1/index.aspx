<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Main Page</h1>
        <h3>Student Related Options</h3> 
        <a href="newstudent.aspx">Enter New Student</a><br />
        <a href="viewstudents.aspx">View All Students</a><br />
        <a href="studenttimetable.aspx">Student Time Table</a><br />
        <h3>Course Related Options</h3>
        <a href="newcourse.aspx">Enter New Course</a><br />
        <a href="viewcourses.aspx">View All Courses</a><br />
        <a href="enrolstudent.aspx">Enrol A Student In Course</a><br />
        <a href="viewenrolments.aspx">View Enrolments In Course</a><br />
        <a href="displaybill.aspx">Display Bill For Student</a><br />

    </div>
    </form>
</body>
</html>
