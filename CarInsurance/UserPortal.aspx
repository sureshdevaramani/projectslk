<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPortal.aspx.cs" Inherits="UserPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    
<meta charset="utf-8" />
<title></title>
    <style>
        .suresh
        {
            float:right;
        }
    </style>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
</head>

<body style="height: 60px;background-image:url(car-Back.png);width:80%;background-repeat:no-repeat;background-size:cover">
     <nav class="navbar navbar-expand-lg navbar-dark bg-primary navbar-nav fixed-top" runat="server">
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <li class="nav-item active">
                    <a class="nav-link float-right" href="#"><span class="badge badge-secondary ">Welcome&nbsp;&nbsp</span>
                     <span class="badge badge-secondary "> <asp:Label ID="Label1" runat="server" Text=""></asp:Label></span></a>
                            <br />
                </li>
                   <li class="nav-item active">
                    <a class="nav-link" href="LoginPage.aspx"></a>
                      
                </li>
               

            </ul>

        </div>
    </nav>
    <form id="form1" runat="server">
        <div>
            <div class="row">
            <%--<div  style="margin-top:90px;width:1000px">
               <asp:image src="car1.png"  alt="responsive image" class="img-fluid suresh"  id="image2" runat="server" />
            </div>--%>
        <div class="container-fluid">
            

      <div class="card  "  runat="server" style="margin-top:90px;margin-left:10px;margin-right:1000px;background-color:#0094ff; border-color:#0094ff;float:left">
                <div class="card-body col-md-2 ">
                    <h3 class="card-title"><span class="badge badge-secondary">Buy Policy</span></h3>
                     <h4><span class="badge badge-secondary ">Select Policy Type</span></h4>
                    
 <h5><a class="nav-link" href="AccidentalCover.aspx"><span class="badge badge-secondary ">Accidental Cover Policy</span></a>
        </h5><h5>             
 <a class="nav-link" href="ThirdPartyCover.aspx"><span class="badge badge-secondary ">Third Party Policy</span></a> 
 </div>

          <div class="col-md-4">
 <h3 class="card-title"> <a class="nav-link" href="UserPolicyDetails.aspx"><span class="badge badge-secondary ">Your Policy Details</span></a></h3>
</div>          
          
          
              <div class="col-md-4"> <h3 class="card-title"> <a class="nav-link" href="Renewal.aspx"><span class="badge badge-secondary ">Renew Your policy</span></a></h3>
            </div>
                  <br />
             <div class="col-md-4"> <h3 class="card-title"> <a class="nav-link" href="Claim.aspx"><span class="badge badge-secondary ">Claim Your policy</span></a></h3>
            </div>
                  <br />
           <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Log Out" OnClick="Button1_Click" />
                     
      </div>
           </div>
    <br />            
        



            
    </div>
    </form>
    

</body>
</html>
