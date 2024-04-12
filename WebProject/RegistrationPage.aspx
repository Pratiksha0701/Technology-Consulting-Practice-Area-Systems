<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="WebProject.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">

</head>
<body>
   <div class="container">
 <form runat="server">
          <div class="form-group col-md-9">
         <h2>Registration and Login System</h2>
     </div>
     <div class="form-group col-md-6">
         <h2>Create Account</h2>
     </div>
  <div class="form-row">
    <div class="form-group col-md-6">
 
      
        <asp:TextBox ID="txtfname" runat="server" class="form-control"  placeholder="First name" required ></asp:TextBox>
    </div>
    <div class="form-group col-md-6">
     
        <asp:TextBox ID="txtlname" runat="server"  class="form-control"  placeholder="Last name" required></asp:TextBox>
    </div>
  </div>
  <div class="form-group">
    
      <asp:TextBox ID="txtemail" runat="server" class="form-control"  placeholder="Email Address" pattern="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" required></asp:TextBox>
  </div>
      <div class="form-group">
    
      <asp:TextBox ID="txtcontact" runat="server" class="form-control"  placeholder="Contact Number" required></asp:TextBox>
  </div>
       <div class="form-row">
    <div class="form-group col-md-6">
 
      
        <asp:TextBox ID="txtpassword" runat="server" class="form-control"  placeholder="Password" required></asp:TextBox>
    </div>
    <div class="form-group col-md-6">
     
        <asp:TextBox ID="txtcpassword" runat="server"  class="form-control"  placeholder="Confirm Password" required></asp:TextBox>
        <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>
    </div>
  </div>
     <div>
         <asp:Button ID="Button1" runat="server" Text="Create Account"  class="btn btn-primary btn-lg btn-block" OnClick="Button1_Click" />
         
     </div><br />
     <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/LoginPage.aspx">Have an Account? Go BAck to Login Page</asp:LinkButton>
     </form>
 
    </div>

</body>
</html>
