using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using ASPSnippets.GoogleAPI;
using System.Web.Script.Serialization;
public partial class _Default : System.Web.UI.Page
{
    Connection kn = new Connection();
    private string clientId= "802999425299-84l6eemfgt73fob9b7mt6k0lo70mn5os.apps.googleusercontent.com";
    private string clientSecret = "S5MbbH_3b6tPb9a3-VROwVST";
    protected void Page_Load(object sender, EventArgs e)
    {
        loadGoogleData();
    }

    private void loadGoogleData()
    {
        GoogleConnect.ClientId = clientId;
        GoogleConnect.ClientSecret = clientSecret;
        GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

        if (!this.IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.Fetch("me", code);
                GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                CheckLoginGoogle(profile);
                
                Response.Redirect("Info.aspx");
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }
           
        }
    }
    private void CheckLoginGoogle(GoogleProfile profile)
    {
        string user = profile.Id;
        kn.conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from tbluser where username='" +user + "'", kn.conn);
        DataTable tb = new DataTable();
        da.Fill(tb);
        if (tb.Rows.Count  < 1)
        {
            string pass = kn.mahoa(user);
            string query = "insert into tblUser(UserName,Pass,NameUser,Email,Img) values ('" + user + "','" + pass + "','"+profile.Name+"','"+profile.Email+"','"+profile.Picture.ToString()+"')";
            SqlCommand sql = new SqlCommand(query, kn.conn);
            sql.ExecuteNonQuery();
           

        }
        Session["name"] = user;
        Session["allow"] = true;
        UpDateData(user);
        kn.conn.Close();
        Response.Redirect("Info.aspx");
    }
    private void UpDateData(string user)
    {
        DateTime dt = DateTime.Now;
        string hostName = Dns.GetHostName();

        string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
        System.Web.HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser;

        string query2 = "update  tblUser set TimeLogin ='" + dt.ToString() + "', HostName='" + hostName + "', IPAddress='" + myIP + "', NameBrowser='" + browser.Browser + "' where UserName ='" + user + "'";
        SqlCommand sql2 = new SqlCommand(query2, kn.conn);
        sql2.ExecuteNonQuery();
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string user = txtu.Text;
        string pass = kn.mahoa( txtp.Text);
        if(user =="" || pass == "")
        {
            Response.Write("<script>alert('Username hoặc Password chưa được nhập')</script>");
        }
        else
        {
            kn.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblUser where UserName='" + user + "' and Pass='" + pass + "'", kn.conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                Session["name"] = user;
                UpDateData(user);
                kn.conn.Close();

                Response.Redirect("Info.aspx");

            }
            else Response.Write("<script>alert('Username hoặc Password chưa đúng')</script>");
        }
       
    }
    protected void btnGoogle_Click(object sender, EventArgs e)
    {

    }
    protected void Login(object sender, EventArgs e)
    {
        GoogleConnect.Authorize("profile", "email");
    }
}