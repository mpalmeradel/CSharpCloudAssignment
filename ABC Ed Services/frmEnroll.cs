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
    public partial class frmEnroll : Form
    {
        private List<Student> students;
        private List<Course> courses;

        private Tafe_DataTier dt;

        public frmEnroll()
        {
            InitializeComponent();
            dt = new Tafe_DataTier();
        }

        private void frmEnroll_Load(object sender, EventArgs e)
        {
            cbStudents.Text = "-Select Student-";
            students = dt.viewStudents();
            foreach(Student s in students)
            {
                cbStudents.Items.Add(s.StudentID);
            }

            cbCourses .Text = "-Select Course-";
            courses = dt.viewCourses();
            foreach (Course c in courses)
            {
                cbCourses.Items.Add(c.CourseID);
            }

        }


        private void btnEnroll_Click(object sender, EventArgs e)
        {
            dt = new Tafe_DataTier();
            int rowsInserted = dt.enroll(cbCourses.SelectedItem.ToString(),cbStudents.SelectedItem.ToString());
            if (rowsInserted > 0)
            {
                MessageBox.Show("New Enrollment Information Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New Enrollment Information NOT Saved", "Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbStudents.SelectedItem.ToString();
            foreach (Student s in students)
                if (s.StudentID.Trim() == id.Trim())
                {
                    this.txtStudName.Text = s.StudentName;
                    this.txtDateEnrolled.Text = s.DateEnrolled.ToString("d");
                }   
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbCourses.SelectedItem.ToString();
            foreach (Course c in courses)
                if (c.CourseID.Trim() == id.Trim())
                {
                    txtCourseName.Text = c.CourseName;
                    this.txtCost.Text = c.Cost.ToString("C");
                }
            
        }
    }
}