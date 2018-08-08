using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public partial class studenttimetable : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = dt.viewStudents();

            foreach (Student s in students)
                StudentDropDownList.Items.Add(s.StudentID);

            TimetableListBox.Items.Clear();

        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {
            String id = StudentDropDownList.SelectedValue;
            List<Course> enrolmentsForStudent = dt.getEnrolmentsForStudent(id);
            foreach (Course c in enrolmentsForStudent)
                TimetableListBox.Items.Add(c.CourseName + "(ID: " + c.CourseID + ")");

            StudentDropDownList.Items.Clear();
            List<Student> students = dt.viewStudents();

            foreach (Student s in students)
                StudentDropDownList.Items.Add(s.StudentID);
        }
    }
}