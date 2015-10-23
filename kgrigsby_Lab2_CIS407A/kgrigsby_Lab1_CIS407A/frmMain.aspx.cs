using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* Uses the 'SaveUserActivity' method of the 'clsDataLayer' class to save user input
        to the database and to the 'frmPersonnel' page.*/
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");
        if (Session["SecurityLevel"] == "A")
        {
            linkbtnNewEmployee.Visible = true;
            linkbtnViewUserActivity.Visible = true;
            linkbtnEditEmployees.Visible = true;
            linkbtnManageUsers.Visible = true;
            imgbtnNewEmployee.Visible = true;
            imgbtnViewUserActivity.Visible = true;
            imgbtnEditEmployees.Visible = true;
            imgbtnManageUsers.Visible = true;
        }
        else 
        {
            linkbtnNewEmployee.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            linkbtnEditEmployees.Visible = false;
            linkbtnManageUsers.Visible = false;
            imgbtnNewEmployee.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            imgbtnEditEmployees.Visible = false;
            imgbtnManageUsers.Visible = false;
        }

    }
}