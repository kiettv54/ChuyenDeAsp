using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
    public Connection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection conn = new SqlConnection("Data Source=ABTT-20190809TW;Initial Catalog=kiemtra;Integrated Security=True");
    public string mahoa(string pass)
    {
        return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
    }
}