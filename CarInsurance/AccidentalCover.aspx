<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccidentalCover.aspx.cs" Inherits="AccidentalCover" %>

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
<body>
     <nav class="navbar navbar-expand-lg navbar-dark bg-primary navbar-nav fixed-top">
        <h2> <span class="badge badge-secondary">Car Insurance</span></h2>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item ">
                    <a class="nav-link" href="HomePage.html"><span class="badge badge-secondary">Home</span></a>
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
        
    
    <div class="col-md-8 card" style="margin-top:100px;margin-left:20px;margin-bottom:10px;border-color:#0094ff;">

    
         <h4><span class="badge badge-secondary ">Premium Calculator  For Accidental Cover Policy</span></h4>
         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        
        <br />

 
       

        <asp:Label ID="PoclicyName" runat="server" Text=""></asp:Label>
 Car:
        <div class="form-group">
   
    <select runat="server" class="form-control" id="CarName">
      <option value="250000" >Car 1</option>
      <option value="350000">Car 2</option>
     <option  value="450000">Car 3</option>
    </select>
  </div>



         
   
        
        <br />
        Car'S Age:
       
        
        <div class="form-group">
   
    <select runat="server" class="form-control" id="CarAge">
      <option value="6">1 to 6 months</option>
      <option value="1 ">6 months to 1 year</option>
     <option  value="2">1 year to 2 years</option>
        <option value="3">2 years to 3 years</option>
        <option value="4">3 years to 4 years</option>
    </select>
  </div>
       
       <br />
        Insured Amount:
       <asp:TextBox ID="TextBox2" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
     
        
        <br />
           Premium For :
      
          <div class="form-group">
   
    <select runat="server" class="form-control" id="PremiumAge">
      <option value="1">1 Year </option>
      <option value="2">2 Years </option>
     <option  value="3">3 Years</option>
        <option value="4">4 years </option>
        <option value="5">5 years</option>
    </select>
  </div>
        <br />
        Premium Amount:
        <asp:TextBox ID="TextBox3" runat="server" class="form-control" OnTextChanged="TextBox3_TextChanged" ReadOnly="True"></asp:TextBox>
        <br />
       
        Wtih OD Discount:
            <asp:TextBox ID="TextBox4" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
        <br />
       
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Show Premium" />
        <br />
       
        <br />
       
      <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="Buy This Policy" />
      <br /> <br />
 <asp:Button ID="Button3" class="btn btn-primary" runat="server" OnClick="Button3_Click" Text="Back" />
       <br />
        </div>

        
    </form>
   
    
   
   

</body>
</html>