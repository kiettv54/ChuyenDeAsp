<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  

   
    <div>
    
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </p>
    
    </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large"  Text="Đăng nhập"></asp:Label>
<br />
<br />
     &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtu" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="PassWord:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtp" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button CssClass="btn btn-primary" Width="20%" ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" />
&nbsp;&nbsp;
        <input id="Reset1" Class="btn btn-primary" style="width:20%" type="reset" value="Reset" /><br />
        <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="btnloginGG" CssClass="btn btn-primary" Width="30%" Text="Login with Google" runat="server" OnClick="Login" BackColor="Red" ForeColor="White" />

       <%--<asp:Button ID="btnGoogle" runat="server" Text="Google Login" OnClick="btnGoogle_Click" />--%>
</asp:Content>
   
   