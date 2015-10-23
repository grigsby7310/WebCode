using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Includes namespaces to enable database access
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
	public clsDataLayer()
	{
	}
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Declarations of composition to be used to instantiate objects
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Instantiation of OleDbConnection 'sqlConn'
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Instantiation of OledbDataAdapter 'sqlDA'
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
        // Instantiation of dsUserActivity 'DS'
        DS = new dsUserActivity();
        //The 'Fill' method of 'sqlDA' class used with a parameter to access the table in the dataset
        sqlDA.Fill(DS.tblUserActivity);
        // The method will return information from the UserActivity Dataset
        return DS;
    }
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Instantiation fo OleDbConnection 'conn'
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
        GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;
        /*try
        {
            // Instantiation of OleDbConnection 'conn' object to establish connection to database
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            // 'strSQL variable allows users to input data into the application
            strSQL = "Insert into tblPersonnel " +
            "(FirstName, LastName) values ('" +
            FirstName + "', '" + LastName + "')";
            // Turns data entered in the textbox into appropriate data form
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Allows an action to take place based on data entered into database
            command.ExecuteNonQuery(); 
            strSQL = "Update tblPersonnel " +
            "Set PayRate=" + PayRate + ", " +
            "StartDate='" + StartDate + "', " +
            "EndDate='" + EndDate + "' " +
            "Where ID=(Select Max(ID) From tblPersonnel)";
            // Turns data entered in the textbox into appropriate data form
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Allows an action to take place based on data entered into database
            command.ExecuteNonQuery();

            // Closes the connection to the database
            conn.Close();
            recordSaved = true;*/
        // ** NEW ** declaration of myTransaction variable of OleDbTransaction to an assignment of 'null'
        OleDbTransaction myTransaction = null;

        try
        {

            // instantiatiion of OleDbConnection 'conn'
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            // ** NEW ** Using dot notation to use the OleDbConection to begin database transaction
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;
            // 'strSQL' variable allows users to input data into the application
            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";

            // Turns data entered in the textbox into appropriate data form
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Allows an action to take place based on data entered into database
            command.ExecuteNonQuery();

            // 'strSQL' variable allows users to input data into the application
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";

            // Turns data entered in the textbox into appropriate data form
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Allows an action to take place based on data entered into database
            command.ExecuteNonQuery();
            // ** NEW ** Permanently adds entered data into the database
 myTransaction.Commit();

            // Terminates the connection to the database through instantiated variable
            conn.Close();

        recordSaved = true;

        }
        catch (Exception ex)
        {
            // ** NEW ** If any unhandled exception occurrs, delete any information entered
            myTransaction.Rollback();

            recordSaved = false;

        }

        return recordSaved;

    }
    public static dsPersonnel GetPersonnel(string Database, string strSearch) 
    {
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Instantiation of OleDbConnection 'sqlConn'
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Instantiation of OledbDataAdapter 'sqlDA'
        if (strSearch == null || strSearch.Trim() == "")
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        else
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        // Instantiation of dsUserActivity 'DS'
        DS = new dsPersonnel();
        //The 'Fill' method of 'sqlDA' class used with a parameter to access the table in the dataset
        sqlDA.Fill(DS.tblPersonnel);
        // The method will return information from the UserActivity Dataset
        return DS;
    }
    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // Declares composition variables to dataset, connection to the database, and database adapter
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // instantiates previously declared variable as object
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        // instantiates previously declared variable as object
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);
        // instantiates previously declared variable as object
        DS = new dsUser();
        // allows adapter to be filled with information from database table
        sqlDA.Fill(DS.tblUserLogin);
        // returns information that verifies a user in the tblUser table
        return DS;
    }
    public static bool SaveUser(string Database, string UserName, string Password, string SecurityLevel)
    {
        bool recordSaved;

        try
        {

            // instantiatiion of OleDbConnection 'conn'
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;


            strSQL = "Insert into tblUserLogin " +
                     "(UserName, UserPassword, SecurityLevel) values ('" +
                     UserName + "', '" + Password + "','" + SecurityLevel + "')";

            

            // Turns data entered in the textbox into appropriate data form
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Allows an action to take place based on data entered into database
            command.ExecuteNonQuery();

            // Terminates the connection to the database through instantiated variable
            conn.Close();

            recordSaved = true;

        }
        catch (Exception ex)
        {
            recordSaved = false;

        }

        return recordSaved;
    }
}