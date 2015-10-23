using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If login has "A" security level, reveal submit button
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
            // If login does not have "A" security level, hide submit button
        }
        else
        {
            btnSubmit.Visible = false;
        }
    }
    bool validatedState = true;
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        try{
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;

        
            if (Request["txtFirstName"].ToString().Trim() == "")
            {
                validatedState = false;
                txtFirstName.Focus();
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "You must enter your first name!";
                lblError.BackColor = System.Drawing.Color.Red;
            }
            else if (Request["txtLastName"].ToString().Trim() == "")
            {
                validatedState = false;
                txtLastName.Focus();
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "You must enter your last name!";
                lblError.BackColor = System.Drawing.Color.Red;
            }
            else if (Request["txtPayRate"].ToString().Trim() == "")
            {
                validatedState = false;
                txtPayRate.Focus();
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "You must enter your pay rate!";
                lblError.BackColor = System.Drawing.Color.Red;
            }
            else if (Request["txtStartDate"].ToString().Trim() == "")
            {
                validatedState = false;
                txtStartDate.Focus();
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "You must enter your start date!";
                lblError.BackColor = System.Drawing.Color.Red;
            }
            else if (Request["txtEndDate"].ToString().Trim() == "")
            {
                validatedState = false;
                txtEndDate.Focus();
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "You must enter your end date!";
                lblError.BackColor = System.Drawing.Color.Red;
            }
            else if (Request["txtStartDate"].ToString().Trim() != "" && Request["txtEndDate"].ToString().Trim() != "")
            {
                DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
                DateTime endDate = DateTime.Parse(Request["txtEndDate"]);
                if (DateTime.Compare(startDate, endDate) > 0)
                {
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = "The end date must be a later date than the start date.";
                    //The Msg text will be displayed in lblError.Text after all the error messages are concatenated
                    validatedState = false;
                    //Boolean value - test each textbox to see if the data entered is valid, if not set validState=false. 
                    //If after testing each validation rule, the validatedState value is true, then submit to frmPersonnelVerified.aspx, if not, then display error message
                }
                else
                {
                    validatedState = true;
                    lblError.Visible = false;
                    Session["txtFirstName"] = txtFirstName.Text;
                    Session["txtLastName"] = txtLastName.Text;
                    Session["txtPayRate"] = txtPayRate.Text;
                    Session["txtStartDate"] = txtStartDate.Text;
                    Session["txtEndDate"] = txtEndDate.Text;
                    Response.Redirect("frmPersonnelVerified.aspx");
                }
            }
        }
        catch(HttpUnhandledException)
        {
            Session["txtStartDate"] = " ";
            Session["txtEndDate"] = " ";
        }
    }
}