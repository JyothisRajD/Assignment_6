using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge6
{
    public partial class DesignationPage : System.Web.UI.Page
    {
        BAL.Des_Bal desBal = new BAL.Des_Bal();
        BAL.Dep_Bal depBal = new BAL.Dep_Bal(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = depBal.ViewDep();
                DropDownList1.DataTextField = "DepartmentName";
                DropDownList1.DataValueField = "DepartmentId";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("-select-", "0"));

                
                GridView1.DataSource = desBal.ViewDes();
                GridView1.DataBind();

                
            }

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = desBal.ViewDes();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int desgn_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox designation = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            string deptment = (GridView1.Rows[e.RowIndex].FindControl("dropdown2") as DropDownList).SelectedItem.Value;

            desBal.DesName=designation.Text;
            desBal.DepId = Convert.ToInt32(deptment);
            desBal.DesId = desgn_id;
          
            int i = desBal.UpdateDes();
            GridView1.EditIndex = -1;
            GridView1.DataSource = desBal.ViewDes();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = desBal.ViewDes();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int desgn_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            desBal.DesId = desgn_id;
            int i = desBal.DeleteDes();
            GridView1.DataSource = desBal.ViewDes();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            desBal.DesName = TextBox3.Text;
            desBal.DepId=Convert.ToInt32(DropDownList1.SelectedValue);
            int i = desBal.InsertDesignation();
            GridView1.DataSource = desBal.ViewDes();
            GridView1.DataBind();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                DropDownList dropDown = new DropDownList();
                dropDown = (DropDownList)e.Row.FindControl("dropdown2");
                if(dropDown != null)
                {
                    dropDown.DataSource = depBal.ViewDep();
                    dropDown.DataTextField = "DepartmentName";
                    dropDown.DataValueField = "DepartmentId";
                    dropDown.DataBind();

                    ((DropDownList)e.Row.FindControl("dropdown2")).SelectedValue=DataBinder.Eval(e.Row.DataItem,"DesignationId").ToString();
                }
            }
        }
    }
}