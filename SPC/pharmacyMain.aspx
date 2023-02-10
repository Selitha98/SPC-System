<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pharmacyMain.aspx.cs" Inherits="SPC.WebForm2" %>

<!DOCTYPE html>
<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Pharmacies</title>

    <style type="text/css">
        #GDstaff {
            height: 66px;
        }

        .stafftbl-con tr th{
            border:none;
            background-color:white;
            color:black;
        }

        .stafftbl-con, .stafftbl-con tr td{
            border:0px solid black;
        }

        tr:nth-child(even){
            background:#f8f7ff;
            border-top:1px solid black;
            border-bottom:1px solid black:
        }

        tr:nth-child(odd){
            background:#fff;
            border-top:1px solid black;
            border-bottom:1px solid black:
        }


    </style>
</head>
<body>
    <div class="admin-fullPage" id="main">
        <header class="admin-bg">

            <div class="admin-links">
                <img class="admin-logo" src="./img/logo.png" alt="logoadmin">
            
                <nav class="nav-admin">
                    <ul class="admin-Navbar">
                        <li><a href="#">Home</a></li>
                        <li><a href="#place">Place Order</a></li>
                        <li><button type="button" id="btnlogout">Log out</button></li>
                    </ul>
                
                </nav>
            </div>
            <h1 class="admin-head">Welcome to The Pharmacies Page</h1>
        </header>
        
        <div class="fourth-second-section" id="create-stock">
            <div class="fourth-content-admin">
                <div class="head-text">
                    <h1 id="fourth-section-title">Place an Order</h1>
                </div>
                <form runat="server">
                <div id="input-field-stock">
                    
                    <input type="text" name="" class="inputstock" id="medicineName" placeholder="Medicine Name" runat="server">
                    <input type="text" name="" class="inputstock" id="medicineCategory" placeholder="Category" runat="server">                  
                    
                    <asp:TextBox ID="quantity" class="inputstock" runat="server" placeholder="Quanitity" ></asp:TextBox>
                    <asp:TextBox ID="wholesaleprice" class="inputstock" runat="server" placeholder="Whole Price (Rs)" ></asp:TextBox>


                    <asp:TextBox ID="totalprice" class="inputstock" runat="server" placeholder="Total Price (Rs)" ></asp:TextBox>
                    
                    
                    
                </div>  
                <br><br>
                
       
             <br />

                
                    <div id="GDVmedicine">
                        
                        
                        <asp:GridView ID="medicineGDV" Height="92px" Width="683px" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="medicineGDV_SelectedIndexChanged"></asp:GridView>
   
                       <br /><br />
                           
                    </div>

                    <div id="btn-stock">
                        
                    <asp:Button ID="Cal" class="btnstock"   runat="server" Text="Calculate" OnClick="Cal_Click" />
                    <asp:Button ID="Place" class="btnstock"   runat="server" Text="Place an Order" OnClick="Place_Click" />
                    
                    <!--<button class="btnstock">Edit</button>
                    <button class="btnstock">Delete</button>-->
                    </div> 
                    </form>
        </div>
        <footer class="admin-footer">
            <ul>
                <li><a href="#main">Home</a></li>
                <li><a href="#place">Place Order</a></li>
            </ul>
            <p class="footer-title">&copy; State Pharmaceuticals Corporation of Sri Lanka Since 2008</p>
        </footer>
    </div>
    
</body>
</html>