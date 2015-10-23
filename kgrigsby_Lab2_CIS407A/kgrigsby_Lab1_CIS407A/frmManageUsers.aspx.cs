using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"),
txtUserName.Text, txtPassword.Text, ddlSecurityLevel.SelectedValue))
        {
            lblError.Text = "The user was successfully added!";
            grdUsers.DataBind();
        }
        else
            lblError.Text = "The user was not added!";
    }
    
}