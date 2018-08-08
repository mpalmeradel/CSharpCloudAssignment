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
   
    public partial class frmCourses : Form
    {
        private List<Course> courses;

        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            Tafe_DataTier dt = new Tafe_DataTier();
            courses = dt.viewCourses();

            foreach (Course s in courses)
            {
                lbCourses.Items.Add(s.CourseID + " --> " + s.CourseName);
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}