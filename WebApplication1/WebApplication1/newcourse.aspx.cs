using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class newcourse : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal cost = Decimal.Parse(CourseCostTextBox.Text);
                int result = dt.insertCourse(CourseIDTextBox.Text, CourseNameTextBox.Text, cost);
                if (result == 1)
                    MessageLabel.Text = "Course successfully added.";
                else
                    MessageLabel.Text = "Course was NOT added.";
            }
            catch
            {
                MessageLabel.Text = "Course was NOT added.";
            }
        }
    }
}