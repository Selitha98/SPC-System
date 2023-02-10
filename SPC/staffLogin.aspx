<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staffLogin.aspx.cs" Inherits="SPC.staffLogin" %>

<!DOCTYPE html>

<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Staff Login</title>
</head>
<body>
    <div class="full-page">
        <div class="nav-bar">
            <div class="logo">
                <img  src="./img/logo.png" alt="spclogo">
            </div>
            <nav>
                <ul id="nav-menu">
                    <li><a href="./supplierLogin.aspx">Suppliers </a></li>
                    <li><a href="./Login.aspx">Administrator </a></li>
                    <li><a href="./pharmacyLogin.aspx">Pharmacies </a></li>
                </ul>
            </nav>

        </div>

        <div class="form-box">

            <div class="login-head">
                <h3 class="login-head-admin">Login</h3>
            </div>
            
            <form class="input-group" id="login" runat="server" >

                <asp:TextBox ID="staffuseremail" class="input-field" placeholder="Email" runat="server" Required="required"></asp:TextBox>
                <asp:TextBox ID="staffuserpass" class="input-field" placeholder="Password" runat="server" Required="required"></asp:TextBox>
                <br /><br />
                <asp:Button ID="loginbtn" class="submit-btn" runat="server" Text="Login" OnClick="loginbtn_Click" />
            
            </form>

        </div>
    </div>
    
</body>
</html>