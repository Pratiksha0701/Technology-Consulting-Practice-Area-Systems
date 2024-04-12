<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebProject.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">

</head>
<body>

   <div class="container">

 <form runat="server" >
      <div class="form-group col-md-9">
         <h2>Registration and Login System</h2>
     </div>
  <div class="form-group col-md-6">
      <h3>Login User</h3>
  </div>
    <div class="form-group col-md-6">
 
      
        <asp:TextBox ID="txtlogin" runat="server" class="form-control"  placeholder="First name" required></asp:TextBox>
    </div>
    <div class="form-group col-md-6">
     
        <asp:TextBox ID="txtpass" runat="server"  class="form-control"  placeholder="Last name" required></asp:TextBox>
    </div>

     &nbsp;&nbsp;&nbsp;
     <div>
     &nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-primary " OnClick="Button1_Click" />
     </div>
    
     <asp:LinkButton ID="LinkButton1" runat="server">Forgote Password?</asp:LinkButton>
     <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/RegistrationPage.aspx">Need an Account? SignUp!</asp:LinkButton>

     </form>
 
    </div>

</body>
</html>
