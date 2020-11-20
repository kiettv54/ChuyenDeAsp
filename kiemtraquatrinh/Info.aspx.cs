using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Info : System.Web.UI.Page
{ 
    Connection kn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        load(Session["name"].ToString());
        //load("kiet");
    }
    void load(string user)
    {
        try
        {
            kn.conn.Open();
            string query = "select UserName,NameUser,Email,Img,NameBrowser,IPAddress,HostName,TimeLogin from tblUser where UserName='"+user+"'";

            SqlDataAdapter data = new SqlDataAdapter(query, kn.conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            kn.conn.Close();
            grvInfo.DataSource = ds;
            grvInfo.DataBind();
        }
        catch
        {

        }
    }

    protected void grvInfo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   
}