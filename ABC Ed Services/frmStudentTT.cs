using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using ABC_Ed_Services.TafeDBServiceReference;

namespace ABC_Ed_Services
{
    public partial class frmStudentTT : Form
    {
        private List<Student> students;

        public frmStudentTT()
        {
            InitializeComponent();
        }

        private void frmStudentTT_Load(object sender, EventArgs e)
        {
            
            cbStudents.Text = "-Select Student-";
            Tafe_DataTier dt = new Tafe_DataTier();
            students = dt.viewStudents();
            
            foreach (Student s in students)
            {
                cbStudents.Items.Add(s.StudentID);
            }
           
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tafe_DataTier dt = new Tafe_DataTier();

            lbCourses.Items.Clear();
            string id = cbStudents.SelectedItem.ToString();

            foreach (Student s in students)
            {
                if (s.StudentID == id) { 
                    txtName.Text = s.StudentName;
                    txtDateEnrolled.Text = s.DateEnrolled.ToString("d");
                }
            }

            List<Course> enrolmentsForStudent = dt.getEnrolmentsForStudent(id);
            
            if (enrolmentsForStudent.Count == 0)
                lbCourses.Items.Add("--------- NO ENROLLMENTS ----------");
            else
            {
                foreach (Course c in enrolmentsForStudent)
                    lbCourses.Items.Add(c.CourseName);
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}