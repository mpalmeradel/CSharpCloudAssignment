using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public partial class displaybill : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();
        List<Student> students;
        List<Course> courses;
        Decimal bill;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Tafe_DataTier
            dt = new Tafe_DataTier();

            //List<Student>
            students = dt.viewStudents();
            
            // for some reason, these contents are repeatedly added to drop down list! Why?
            foreach (Student s in students)
                StudentDropDownList.Items.Add(s.StudentID);
            
            courses = new List<Course>();
            bill = 0;
            
        }

        protected void StudentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // THIS EVENT ISN'T CALLED AND I DON'T KNOW WHY

                string id = StudentDropDownList.SelectedItem.ToString();

                List<Student> students = dt.viewStudents();
                foreach (Student s in students)
                    if (s.StudentID.Trim() == id.Trim())
                        StudentNameLabel.Text = s.StudentName;

                courses = dt.getEnrolmentsForStudent(id);

                foreach (Course c in courses)
                {
                    CoursesListBox.Items.Add(c.CourseName);
                    bill += c.Cost;
                }

                CostLabel.Text = "Cost is " + bill.ToString();

                StudentNameLabel.DataBind();
                CoursesListBox.DataBind();
                CostLabel.DataBind();

            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {

                CoursesListBox.Items.Clear();
                bill = 0;

                string id = StudentDropDownList.SelectedValue.ToString();
                
                //string id = StudentDropDownList.SelectedIndex.ToString();

                List<Student> students = dt.viewStudents();
                foreach (Student s in students)
                    if (s.StudentID.Trim() == id.Trim())
                        StudentNameLabel.Text = s.StudentName + "(ID = " + id + ")";
                
                courses = dt.getEnrolmentsForStudent(id);

                foreach (Course c in courses)
                {
                    CoursesListBox.Items.Add(c.CourseName);
                    bill += c.Cost;
                }

                // This is necessary for some reason - I am obvously not understanding something
                // important to the life cycle of this page
                StudentDropDownList.Items.Clear();
                foreach (Student s in students)
                    StudentDropDownList.Items.Add(s.StudentID);

                CostLabel.Text = "Cost is " + bill.ToString();

            //StudentNameLabel.DataBind();
            //CoursesListBox.DataBind();
            //CostLabel.DataBind();
            }
            catch (Exception ex)
            {
                CostLabel.Text = ex.Message.ToString();
                CostLabel.DataBind();
            }
        }
    }
}