using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ABC_Ed_Services.TafeDBServiceReference;

namespace ABC_Ed_Services
{
    public partial class frmViewEnrollments : Form
    {
        List<Course> courses;

        public frmViewEnrollments()
        {
            InitializeComponent();
        }

        private void frmViewEnrollments_Load(object sender, EventArgs e)
        {
            cbCourses.Text = "-Select Courset-";
            Tafe_DataTier dt = new Tafe_DataTier();

            courses = dt.viewCourses();

            foreach (Course c in courses)
            {
                cbCourses.Items.Add(c.CourseID);
            }
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();
            string id = cbCourses.SelectedItem.ToString();

            foreach(Course c in courses)
                if (c.CourseID.Trim() == id.Trim()) { 
                    this.txtName.Text = c.CourseName;
                    this.txtCost.Text = c.Cost.ToString("C");
                    }

            Tafe_DataTier dt = new Tafe_DataTier();
            List<Student> students = dt.getStudentEnrolledInCourse(id);

            if (students.Count == 0)
                lbStudents.Items.Add("--------- NO ENROLLMENTS ----------");
            else
                foreach (Student s in students)
                    this.lbStudents.Items.Add(s.StudentName + " --> " + s.StudentID);
        }
    }
}