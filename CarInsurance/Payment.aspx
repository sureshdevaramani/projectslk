<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-black.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
       
    <title></title>
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
<div class="col-md-8 card" style="margin-top:100px;margin-left:20px;margin-bottom:10px;border-color:#0094ff;">
    <h2><div class="card-title"><span class="badge badge-secondary ">Policy Payment</span></div>
</h2><br />
          Enter Account Number:
        <asp:TextBox ID="TextBox1" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
       
       
<br />
        IFSC Code:
        <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
        <br />
      
        Enter Account Holder'S Name:
        <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
        <br />
    
        Enter Bank Name:
        <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
        <br />
       



        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Pay" OnClick="Button1_Click" />

            <br />      
         <br />     
            </div>
    	</div>
    </form>
</body>
</html>

