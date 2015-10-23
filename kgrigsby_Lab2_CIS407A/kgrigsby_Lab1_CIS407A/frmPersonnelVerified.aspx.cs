using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Takes input information from the user in the frmPersonnel.aspx page
        and sets it in the mulitline textbox window of the frmPersonnelVerified.aspx page 
        in the format listed below.*/
        txtVerifiedInfo.Text = Session["txtFirstName"].ToString()+
            "\n" + Session["txtLastName"].ToString()+
            "\n" + Session["txtPayRate"].ToString()+
            "\n" + Session["txtStartDate"].ToString()+
            "\n" + Session["txtEndDate"].ToString();

        // If database connection allowd information to be saved, print the affirmative message
        // If not, print the negative message
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
        Session["txtFirstName"].ToString(),
        Session["txtLastName"].ToString(),
        Session["txtPayRate"].ToString(),
        Session["txtStartDate"].ToString(),
        Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was successfully saved!";
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was NOT saved.";
        }
    }
}