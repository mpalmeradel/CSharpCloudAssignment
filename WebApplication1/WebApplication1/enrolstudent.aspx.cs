using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public partial class enrolstudent : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();

        List<Course> courses;
        List<Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Course> courses = dt.viewCourses();
            List<Student> students = dt.viewStudents();

            foreach (Course c in courses)
                CourseDropDownList.Items.Add(c.CourseID);

            foreach (Student s in students)
                StudentDropDownList.Items.Add(s.StudentID);

        }

        protected void EnrolButton_Click(object sender, EventArgs e)
        {
            string courseID = CourseDropDownList.SelectedValue;
            string studentID = StudentDropDownList.SelectedValue;

            int result = dt.enroll(courseID, studentID);

            if (result > 0)
                MessageLabel.Text = "New enrolment information saved.";
            else
                MessageLabel.Text = "New enrolment information NOT saved.";

            CourseDropDownList.Items.Clear();
            StudentDropDownList.Items.Clear();

            List<Course> courses = dt.viewCourses();
            List<Student> students = dt.viewStudents();

            foreach (Course c in courses)
                CourseDropDownList.Items.Add(c.CourseID);

            foreach (Student s in students)
                StudentDropDownList.Items.Add(s.StudentID);
        }
    }
}