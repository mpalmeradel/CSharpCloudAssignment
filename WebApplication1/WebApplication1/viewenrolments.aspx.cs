using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public partial class viewenrolments : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();
        List<Course> courses;

        protected void Page_Load(object sender, EventArgs e)
        {
            courses = dt.viewCourses();
            foreach (Course c in courses)
                CourseDropDownList.Items.Add(c.CourseID);
            CourseListBox.Items.Clear();
        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            String id = CourseDropDownList.SelectedValue;

            List<Student> students = dt.getStudentEnrolledInCourse(id);

            foreach (Student s in students)
                CourseListBox.Items.Add(s.StudentName + " --> " + s.StudentID);


            CourseDropDownList.Items.Clear();
            foreach (Course c in courses)
                CourseDropDownList.Items.Add(c.CourseID);

        }
    }
}