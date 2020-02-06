<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPolicyDetails.aspx.cs" Inherits="UserDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta charset="utf-8" />
<title></title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
</head>
<body style="height: 60px">
     <nav class="navbar navbar-expand-lg navbar-dark bg-primary navbar-nav fixed-top">
        <h2> <span class="badge badge-secondary">Car Insurance</span></h2>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item ">
                    <a class="nav-link" href="HomePage1.html"><span class="badge badge-secondary">Home</span></a>
                </li>
                
                <li class="nav-item">
                    <a class="nav-link" href="AccidentalCover.html"><span class="badge badge-secondary">Accidental Cover</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="ThirdParty.html"><span class="badge badge-secondary">Third party Cover</span></a>

                </li>
           <li class="nav-item">
                    <a class="nav-link" href="Terms.html"><span class="badge badge-secondary">Terms and Condition</span></a>

                </li>
               
                <li class="nav-item active">
                    <a class="nav-link" href="Policy.aspx"><span class="badge badge-secondary ">Polices and Premiums</span></a>

                </li>
            </ul>

        </div>
    </nav>

    <form id="form1" runat="server">
 
         <div>
          <div class="col-2">
   
    </div>

         <br /><br />
          <div class="col-6" style="margin-top:30px;margin-bottom:20px;">
            <div class="card"  runat="server" style="margin-top:5px;margin-left:100px;border-color:#0094ff">
                <div class="card-body">
                    <h5 class="card-title"><span class="badge badge-secondary">User Details</span></h5>

                    <p class="card-text">
  <div >
       <asp:Label ID="Label1" runat="server" Text=""><br /></asp:Label>

      UserID
      <asp:TextBox ID="TextBox6" runat="server" type="name" class="form-control"  aria-describedby="UserNameHelp" ReadOnly="True" ></asp:TextBox>
     
      
      <br />
      <label for="exampleInputName">Name</label>
    
    <small id="NameHelp" class="form-text text-muted">
      
      <asp:TextBox ID="TextBox1" runat="server" type="name" class="form-control"  aria-describedby="NameHelp" ReadOnly="True"   ></asp:TextBox>
      
      <br />
  </small>
  </div>
  <div>
    <label for="exampleInputPassword1">Policy ID</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox2" runat="server" type="" class="form-control" placeholder="" TextMode="SingleLine" ReadOnly="True"></asp:TextBox>
  </div>
 <br />
          <div>
    <label for="exampleInputMobile">Policy Name</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox3" runat="server" type="" class="form-control" placeholder=""  TextMode="SingleLine" ReadOnly="True"></asp:TextBox>
            
  </div>
 <br />
           
 
          <div>
    <label for="exampleInputEmail">Policy Type</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox5" runat="server" type="" class="form-control" ReadOnly="True" ></asp:TextBox>
  </div>
 <br />
          <div>
    <label for="exampleInputEmail">Car Name</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox7" runat="server" type="" class="form-control" ReadOnly="True"   ></asp:TextBox>
  </div>
 <br />
                                <div>
    <label for="exampleInputEmail">Start Date </label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox8" runat="server" type="" class="form-control" ReadOnly="True"   ></asp:TextBox>
  </div>
 <br />
                                <div>
    <label for="exampleInputEmail">End Date </label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox9" runat="server" type="" class="form-control" ReadOnly="True"   ></asp:TextBox>
  </div>
 <br />
                                <div>
    <label for="exampleInputEmail">Policy Premium Amount</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox10" runat="server" type="" class="form-control" ReadOnly="True"   ></asp:TextBox>
  </div>
 <br />
                                     <div>
    <label for="exampleInputEmail">Policy Status</label>
   <!-- <input   id="exampleInputPassword1" ">-->
      <br />
      <asp:TextBox ID="TextBox4" runat="server" type="" class="form-control" ReadOnly="True"   ></asp:TextBox>
         <br />
  </div>
        <asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="Back" />                
 <%-- <asp:Button ID="Button1" type="submit"  runat="server" OnClick="Button1_Click" Text="Submit"  class="btn btn-primary" />--%>
       
         <br />
       
       
         <br />
       
         
         
</p></div></div></div>




   





    </div>
    </form>
</body>
</html>
