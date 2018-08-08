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
    public partial class frmBilling : Form
    {
        private List<Student> students;
        private Tafe_DataTier dt;

        public frmBilling()
        {
            dt = new Tafe_DataTier();
            InitializeComponent();
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new Tafe_DataTier();
            List<Course> courses;
            lbCourses.Items.Clear();
            string id = cbStudents.SelectedItem.ToString();
            
            List<Student> students = dt.viewStudents();
            foreach (Student s in students)
                if (s.StudentID.Trim() == id.Trim())
                    this.txtName.Text = s.StudentName;
            
            courses = dt.getEnrolmentsForStudent(id);

            Decimal total = 0.0M;
            
            if (courses.Count == 0)
                lbCourses.Items.Add("--------- NO ENROLLMENTS ----------");
            else
                foreach (Course c in courses)
                {
                    lbCourses.Items.Add(c.CourseName);
                    total += c.Cost;
                }
            txtCost.Text = total.ToString("C");
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            cbStudents.Text = "-Select Student-";
            students = dt.viewStudents();
            foreach (Student s in students)
            {
                cbStudents.Items.Add(s.StudentID);
            }
        }
    }
}