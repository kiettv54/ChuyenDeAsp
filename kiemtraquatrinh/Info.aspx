<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Info.aspx.cs" Inherits="Info" %>

<!DOCTYPE html>

<html>
<head runat="server">
     <title>Bài kiểm tra quá trình lần 1</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
  
   <style>
       nav{
           background-color:deepskyblue;
       }
   </style>

</head>
<body>
   
 <nav class="navbar navbar-expand-sm">
  
  <div  style="margin-left:auto;">
      <a style="color:black;"  href="Logout.aspx"><i class="fas fa-sign-out-alt fa-fw"></i>Logout</a>
   
  </div>  
</nav>
    <div class="container" style="margin-top:30px">
  <div class="row">
   
    <div >
      
      <br>
     
     <form id="form1" runat="server">
    <div>
      <div>
   
        <br />
       
        <br />
        <asp:GridView ID="grvInfo" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" OnSelectedIndexChanged="grvInfo_SelectedIndexChanged" style="background-color: #FFFFFF">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="Tên tài khoản" />
                <asp:BoundField DataField="NameUser" HeaderText="Họ tên" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:ImageField DataImageUrlField="Img" HeaderText="Hình">
                </asp:ImageField>
                <asp:BoundField DataField="NameBrowser" HeaderText="Loại Browser" />
                <asp:BoundField DataField="IPAddress" HeaderText="Địa chỉ IP" />
                <asp:BoundField DataField="HostName" HeaderText="Host Name" />
                <asp:BoundField DataField="TimeLogin" HeaderText="Thời gian đăng nhập" />
            </Columns>
        </asp:GridView>
    
    </div>
  
    </div>
    </form>
     
    </div>
  </div>
</div>
</body>
</html>