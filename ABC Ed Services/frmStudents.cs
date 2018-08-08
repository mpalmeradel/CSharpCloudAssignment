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
    public partial class frmStudents : Form
    {
        private List<Student> students;

        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
         
            Tafe_DataTier dt = new Tafe_DataTier();
            students = dt.viewStudents();
            
            foreach (Student s in students)
            {
                lbStudents.Items.Add(s.StudentID + " --> " + s.StudentName);
            }
        }
    }
}
