using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kgrigsby_Lab1_CIS407A_frmUserActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Declares the DataSet
            dsUserActivity myDataSet = new dsUserActivity();
            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.accdb"));
            // Sets the DataGrid to the DataSource based on the table
            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];
            // Binds the DataGrid
            grdUserActivity.DataBind();
        }
    }
}