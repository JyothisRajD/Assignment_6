using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge6
{
    public partial class DepartmentPage : System.Web.UI.Page
    {
        BAL.Dep_Bal depbal = new BAL.Dep_Bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            depbal.DepName = TextBox3.Text;
            int i = depbal.InsertDepartment();
            if (i == 1)
            {
                TextBox3.Text = null;
                Label3.Text = "Inserted Successfully";
                
            }
        }
    }
}