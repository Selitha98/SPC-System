<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staffMain.aspx.cs" Inherits="SPC.staffMain" %>

<!DOCTYPE html >
<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Staff</title>

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
    <form id="form1" runat="server">
    <div class="admin-fullPage" id="main">
        <header class="admin-bg">

            <div class="admin-links">
                <img class="admin-logo" src="./img/logo.png" alt="logoadmin">
            
                <nav class="nav-admin">
                    <ul class="admin-Navbar">
                        <li><a href="#">Home</a></li>
                        <li><a href="#create-stock">Stock</a></li>
                        <li><button type="button" id="btnlogout">Log out</button></li>
                    </ul>
                
                </nav>
            </div>
            <h1 class="admin-head">Welcome to The Warehouse Staff Page</h1>
        </header>
        
        <div class="fourth-second-section" id="create-stock">
            <div class="fourth-content-admin">
                <div class="head-text">
                    <h1 id="fourth-section-title">Stock Details</h1>
                </div>
                <div id="input-field-stock">
                    <input type="text" name="" class="inputstock" id="medicineName" placeholder="Medicine Name" runat="server">
                    <input type="text" name="" class="inputstock" id="medicineCategory" placeholder="Category" runat="server">
                    <input type="number" name="" class="inputstock" id="quantity" placeholder="Quanitity" runat="server">
                    <input type="number" name="" class="inputstock" id="wholesaleprice" placeholder="Whole Sale Price (Rs)" runat="server" >
                    <input type="number" name="" class="inputstock" id="retailprice" placeholder="Retail Price (Rs)" runat="server">
                    <input type="text" name="" class="inputstock" id="manufacturer" placeholder="Manufacture Company" runat="server">
                    
                </div>  
                <br><br>
                
                <div id="btn-stock">
                    <asp:Button ID="Addmed" class="btnstock"   runat="server" Text="Add" OnClick="Addmed_Click"/>
                    <asp:Button ID="Editmed" class="btnstock"   runat="server" Text="Edit" OnClick="Editmed_Click"/>
                    <asp:Button ID="Deletemed" class="btnstock"   runat="server" Text="Delete" OnClick="Deletemed_Click"/>
                    <!--<button class="btnstock">Edit</button>
                    <button class="btnstock">Delete</button>-->
                </div> 
             <br />

                    <div id="GDVmedicine">

                    <asp:GridView ID="medicineGDV" runat="server" Height="92px" Width="683px" CssClass="stafftbl stafftbl-con tblstf" AutoGenerateSelectButton="True" >
                    </asp:GridView>

                    </div>
                </div>
        </div>
        <footer class="admin-footer">
            <ul>
                <li><a href="#main">Home</a></li>
                <li><a href="#create-stock">Stock Details</a></li>
            </ul>
            <p class="footer-title">&copy; State Pharmaceuticals Corporation of Sri Lanka Since 2008</p>
        </footer>
    </div>
    
    </form>
    
</body>
</html>
