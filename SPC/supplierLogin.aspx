<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="supplierLogin.aspx.cs" Inherits="SPC.WebForm1" %>

<!DOCTYPE html>

<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Supplier Login</title>
</head>
<body>
    <div class="full-page">
        <div class="nav-bar">
            <div class="logo">
                <img  src="./img/logo.png" alt="spclogo">
            </div>
            <nav>
                <ul id="nav-menu">
                    <li><a href="./Login.aspx">Administrator </a></li>
                    <li><a href="./staffLogin.aspx">Staffs </a></li>
                    <li><a href="./pharmacyLogin.aspx">Pharmacies </a></li>
                </ul>
            </nav>

        </div>

        <div class="form-box">
            <div class="button-box">
                <div id="btn"></div>
                <button type="button" class="toggle-btn" onclick="login()">Log In</button>
                <button type="button" class="toggle-btn" onclick="regiter()">Register</button>
            </div>
            <form class="input-group" id="login" runat="server" >
                <asp:TextBox ID="supuseremail" class="input-field" placeholder="Email" runat="server"  Required="required"></asp:TextBox>
                <asp:TextBox ID="supuserpass" class="input-field" placeholder="Password" runat="server"  Required="required"></asp:TextBox>
                <br /><br />

                <asp:Button ID="loginbtn" class="submit-btn" Text="Login" OnClick="loginbtn_Click"  />
               
            </form> 

            <form class="input-group" id="register" runat="server" >


               <input type="text" class="input-field" placeholder="User Name" id="supname" required runat="server" >
                <input type="email" class="input-field" placeholder="Email" id="supemail" required runat="server" >
                <input type="number" class="input-field" placeholder="Phone" required id="supphone" runat="server">
                <input type="text" class="input-field" placeholder="Company Name" required id="supcompany" runat="server" >
                <input type="password" class="input-field" placeholder="Password" required id="suppass"  runat="server">
                
                
                <asp:Button ID="rgstrbtn" runat="server"  class="submit-btn" Text="Register" OnClick="rgstrbtn_Click"/>
                
              
            </form>
        </div>
    </div>


    <script>

        var x =document.getElementById("login");
        var y =document.getElementById("register");
        var z =document.getElementById("btn");

        function regiter(){
            x.style.left = "-400px";
            y.style.left = "50px";
            z.style.left = "110px";
        }

        function login(){
            x.style.left = "50px";
            y.style.left = "450px";
            z.style.left = "0px";
        }


    </script>
    
</body>
</html>
    
</body>
</html>
