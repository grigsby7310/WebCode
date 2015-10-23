using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        try
        {
            double annualHours = 0.0;
            double payRate = 0.0;
            double annualSalary = 0.0;

            annualHours = Convert.ToDouble(txtAnnualHours.Text);
            payRate = Convert.ToDouble(txtPayRate.Text);

            annualSalary = annualHours * payRate;

            lblAnnualSalary.Text = "Annual Salary is " + annualSalary.ToString("C");
        }
        catch(Exception)
        {
            lblAnnualSalary.Text = "Error! Both fields require a value!";  
        }
    }
}