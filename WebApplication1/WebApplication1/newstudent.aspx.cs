using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public partial class newstudent : System.Web.UI.Page
    {
        Tafe_DataTier dt = new Tafe_DataTier();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {

            int result = dt.insertStudent (StudentIDTextBox.Text, StudentNameTextBox.Text, DateTime.Now);
            string studentName = StudentNameTextBox.Text;

            if (result == 1)
            {
                MessageLabel.Text = "Student " + studentName + " successfully added.";
            }
            else
            {
                MessageLabel.Text = "Student " + studentName + " was not added.";
            }
        }
    }
}