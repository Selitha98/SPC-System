<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminMain.aspx.cs" Inherits="SPC.adminMain" %>

<!DOCTYPE html>

<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Administrator</title>
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
    <div class="admin-fullPage">
        <header class="admin-bg">

            <div class="admin-links">
                <img class="admin-logo" src="./img/logo.png" alt="logoadmin">
            
                <nav class="nav-admin">
                    <ul class="admin-Navbar">
                        <li><a href="#">Home</a></li>
                        <li><a href="#create-staff">Warehouse Staff</a></li>
                        <li><a href="#create-pharmacies">Pharmacies</a></li>
                        <li><a href="#create-stock">Stock Details</a></li>
                         
                        <li><asp:Button ID="btnlogout" runat="server" Text="Log out" OnClick="btnlogout_Click" /></li>

                    </ul>
                
                </nav>
            </div>
            <h1 class="admin-head">Welcome to The Administrator Page</h1>
        </header>
        <div class="admin-second-section" id="create-staff">
            <div class="second-content-admin">
                <div class="head-text">
                    <h1 id="second-section-title">Warehouse Staffs Management</h1>
                </div>
                <div id="input-field-admin">
                    <input type="text" name="" class="inputstaff" id="straffuserName" placeholder="User Name" runat="server" >
                    <input type="text" name="" class="inputstaff" id="straffuserID" placeholder="ID Number" runat="server" >
                    <input type="number" name="" class="inputstaff" id="straffuserPhone" placeholder="Phone" runat="server" >
                    <input type="email" name="" class="inputstaff" id="straffuserEmail" placeholder="Email" runat="server" >
                    <input type="text" name="" class="inputstaff" id="straffuserPassword" placeholder="Password" runat="server" >
                </div>  
                <br><br>
                <div id="btn-staff">
                    <asp:Button ID="Addstaff" class="btnstaff" runat="server" Text="Add" OnClick="Addstaff_Click" />
                    <asp:Button ID="Editstaff" class="btnstaff" runat="server" Text="Edit" OnClick="Editstaff_Click"  />
                    <asp:Button ID="Deletestaff" class="btnstaff" runat="server" Text="Delete" OnClick="Deletestaff_Click"/>
                    
                </div> <br/><br />
                <div id="GDVstaff">

                    <asp:GridView ID="staffGDV" runat="server" Height="92px" Width="683px" CssClass="stafftbl stafftbl-con tblstf" AutoGenerateSelectButton="True" OnSelectedIndexChanged="staffGDV_SelectedIndexChanged">
                    </asp:GridView>

                </div>
            </div>
        </div>
        <div class="admin-third-section" id="create-pharmacies">
            <div class="third-content-admin">
                <div class="head-text">
                    <h1 id="third-section-title">Pharmacies Management</h1>
                </div>
                <div id="input-field-pharmacies">
                    <input type="text" name="" class="inputpharmacies" id="pharmacyName" placeholder="Pharmacy Name" runat="server" >
                    <input type="text" name="" class="inputpharmacies" id="pharmacyCity" placeholder="City" runat="server">
                    <input type="number" name="" class="inputpharmacies" id="pharmacyPhone" placeholder="Phone" runat="server">
                    <input type="email" name="" class="inputpharmacies" id="pharmacyEmail" placeholder="Email" runat="server">
                    <input type="text" name="" class="inputpharmacies" id="pharmacyPassword" placeholder="Password" runat="server">
                </div>  
                <br><br>
                <div id="btn-pharmacies">

                    <asp:Button ID="Addpharma" class="btnpharmacies"  runat="server" Text="Add" OnClick="Addpharma_Click" />
                    <asp:Button ID="Editpharma" class="btnpharmacies"  runat="server" Text="Edit" OnClick="Editpharma_Click"  />
                    <asp:Button ID="Deletepharma" class="btnpharmacies"  runat="server" Text="Delete" OnClick="Deletepharma_Click" />
                    
                   <!-- <button class="btnpharmacies">Add</button>
                    <button class="btnpharmacies">Edit</button>
                    <button class="btnpharmacies">Delete</button>-->
                </div> <br/><br />
                <div id="GDVpharmacy">

                    <asp:GridView ID="pharmacyGDV" runat="server" Height="92px" Width="683px" CssClass="stafftbl stafftbl-con tblstf" AutoGenerateSelectButton="True" OnSelectedIndexChanged="pharmacyGDV_SelectedIndexChanged">
                    </asp:GridView>

                </div>
            </div>
        </div>
        <div class="fourth-second-section" id="create-stock">
            <div class="fourth-content-admin">
                <div class="head-text">
                    <h1 id="fourth-section-title">Stock Details</h1>
                </div>
                <div id="input-field-stock">
                    <input type="text" name="" class="inputstock" id="medicineName" placeholder="Medicine Name" runat="server">
                    <input type="text" name="" class="inputstock" id="medicineCategory" placeholder="Category" runat="server">
                    <input type="number" name="" class="inputstock" id="quantity" placeholder="Quanitity" runat="server">
                    <input type="number" name="" class="inputstock" id="wholesaleprice" placeholder="Whole Sale Price (Rs)" runat="server">
                    <input type="number" name="" class="inputstock" id="retailprice" placeholder="Retail Price (Rs)" runat="server">
                    <input type="text" name="" class="inputstock" id="manufacturer" placeholder="Manufacture Company" runat="server">
                    
                </div>  
                <br><br>
                <div id="btn-stock">

                   
                    <asp:Button ID="Addmed" class="btnstock"   runat="server" Text="Add" OnClick="Addmed_Click"  />
                    <asp:Button ID="Editmed" class="btnstock"   runat="server" Text="Edit" OnClick="Editmed_Click"   />
                    <asp:Button ID="Deletemed" class="btnstock"  runat="server" Text="Delete" OnClick="Deletemed_Click"  />

                 
                </div> <br><br>

                <div id="GDVmedicine">

                    <asp:GridView ID="medicineGDV" runat="server" Height="92px" Width="683px" CssClass="stafftbl stafftbl-con tblstf" AutoGenerateSelectButton="True" OnSelectedIndexChanged="medicineGDV_SelectedIndexChanged">
                    </asp:GridView>

                </div>
            </div>
        </div>
        <footer class="admin-footer">
            <ul>
                <li><a href="#">Home</a></li>
                <li><a href="#create-staff">Warehouse Staff</a></li>
                <li><a href="#create-pharmacies">Pharmacies</a></li>
                <li><a href="#create-stock">Stock Details</a></li>
            </ul>
            <p class="footer-title">&copy; State Pharmaceuticals Corporation of Sri Lanka Since 2008</p>
        </footer>
    </div>
    
    </form>
    
</body>
</html>
