using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //composition declaration of 'dsUserLogin' variable to capture user information
        dsUser dsUserLogin;
        // declaration of 'SecurityLevel' string
        string SecurityLevel;
        /* Sends captured information from login to 'VerifyUser' function of 'clsDataLayer' class
         for verification*/
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        // If verification finds no matching name, authentication fails
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            return;
        }
        // Allows previously declared 'SecurityLevel' string to be set to a single character
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // Determines security level of login to either "A", "U", or determines an error
        switch (SecurityLevel)
        {
            case "A":
                /* If security level of login is "A", login receives access to sight in 
                 accordance with "A" security level*/
                e.Authenticated = true;
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                /* If security level of login is "U", login receives access to sight in 
                 accordance with "U" security level*/
                e.Authenticated = true;
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}