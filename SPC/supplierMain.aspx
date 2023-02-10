<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="supplierMain.aspx.cs" Inherits="SPC.supplierMain" %>

<!DOCTYPE html>
<html lang="en" runat="server">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Supplier</title>
</head>
<body>
    <div class="supplier-fullPage">
        <header class="supplier-bg">

            <div class="supplier-links">
                <img class="supplier-logo" src="./img/logo.png" alt="logoadmin">
            
                <nav class="nav-supplier" id="tophead">
                    <ul class="supplier-Navbar">
                        <li><a href="#">Home</a></li>
                        <li><a href="#addd">View Advertisement</a></li>
                        <li><a href="#former">Tender Request</a></li>
                        <li><button type="button" id="btnlogout">Log out</button></li>
                    </ul>
                
                </nav>
            </div>
            <h1 class="supplier-head">Welcome to The Supplier Page</h1>
        </header>
        <div class="advertisement">
            <div class="advertisement-bg" id="addd"> 
                <div class="advertisement-details">
                    <h3>Item Code No : 130335J99</h3><br>
                    <h2>Clobetasol, Gentamicin + Miconazole</h2>
                    <h5>Cream in 15g tube</h5><br><br>
                    <h4>Quantity : 15,000 Tubes</h4>
                    <h4>Tender No : RES/14/02/D/2022</h4>
                    <h4>Closing Date : 14.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 060618G99</h3><br>
                    <h2>Amikacin Injection BP 500mg in 2ml</h2>
                    <h5>In 2ml Glass Vial</h5><br><br>
                    <h4>Quantity : 10,000 Vials</h4>
                    <h4>Tender No : RES/09/02/A/2022</h4>
                    <h4>Closing Date : 09.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>

                <div class="advertisement-details">
                    <h3>Item Code No : 170203C99</h3><br>
                    <h2>Betahistine Dihydrochloride Tablets BP 16mg</h2>
                    <h5>In 10 x 10 Tablets (Blister)</h5><br><br>
                    <h4>Quantity : 30,000 Packs</h4>
                    <h4>Tender No : RES/09/02/B/2022</h4>
                    <h4>Closing Date : 09.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                                            </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 060609F99</h3><br>
                    <h2>Meropenem Injection 1g vial</h2>
                    <h5>In 2ml Glass Vial</h5><br><br>
                    <h4>Quantity : 5,000 Vials</h4>
                    <h4>Tender No : RES/11/02/A/2022</h4>
                    <h4>Closing Date : 11.02.2022.</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 250101C28</h3><br>
                    <h2>Etofylline & Theophylline Extended Release Tablets 150mg</h2>
                    <h5>In 300 Tablets</h5><br><br>
                    <h4>Quantity : 108,000 Packs</h4>
                    <h4>Tender No : RES/11/02/B/2022</h4>
                    <h4>Closing Date : 11.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 170203C11</h3><br>
                    <h2>Prochlorperazine Maleate Tablets USP</h2>
                    <h5>5mg in 1000 Tablets</h5><br><br>
                    <h4>Quantity : 10,000 Packs</h4>
                    <h4>Tender No : RES/14/02/A/2022</h4>
                    <h4>Closing Date : 14.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 170102C16</h3><br>
                    <h2>Pantoprazole Tablets 20mg</h2>
                    <h5>In 10 x 10 Tablets</h5><br><br>
                    <h4>Quantity : 120,000 Packs</h4>
                    <h4>Tender No : RES/14/02/B/2022</h4>
                    <h4>Closing Date : 14.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>
                <div class="advertisement-details">
                    <h3>Item Code No : 050103C08</h3><br>
                    <h2>Clonazepam Tablets USP 2mg</h2>
                    <h5>In 100 Tablets (Blister)</h5><br><br>
                    <h4>Quantity : 9,000 Packs</h4>
                    <h4>Tender No : RES/14/02/C/2022</h4>
                    <h4>Closing Date : 14.02.2022</h4>

                    <p class="adver-prgph">
                        These tenders are administered by the provisions of the “Public Contract Act No. 3 of 1987” and therefore, in the event bidder is to retain an Agent, Sub-Agent, Representative, Nominee for and on behalf of renderer shall register himself and such Public Contract in accordance with the section 10 of the Public Contract Act and produce such valid certificate of registration in the course of any transaction relating to the tender or Act any stage in the duration of the tender.
                        Tenders will be closed at the office of the State Pharmaceuticals Corporation at 1.15 p.m. on the dates
                        indicated against each tender and will be opened immediately thereafter. Tenderers or their authorized
                        Representatives will be permitted to be present at the time of opening of Tender.
                    </p>
                    <a id="req-link" href="#former">Request Tender</a><br><br>
                </div><br><br>

            </div>>
        </div>



        <section id="contact-section">
            <div class="container-form">
                <h2>Request Your Tender</h2>
                <p class="prgpgh-contact">We Will Response As Soon As Possible</p>

                <div class="contact-form">
                    <!-- first grid -->
                    <div>
                        <p class="form-info">Address : 16th Floor, Kirula Road, Narahenpita,Colombo 05<p><br>
                        <p class="form-info">Phone : 00 94 11 2 471463<p><br>
                        <p class="form-info">Email : dgmmarketing@spc.lk<p><br>   
                    </div>

                    <!-- Second Grid -->

                    <div>
                        <form id="former" runat="server">


                            <asp:TextBox ID="txt_itm" class="contct-form" placeholder="Item Code Number" runat="server" Required="required"></asp:TextBox>                         
                            <asp:TextBox ID="txt_tender" class="contct-form" placeholder="Tender Number" runat="server" Required="required"></asp:TextBox>                           
                            <asp:TextBox ID="txt_email" class="contct-form" placeholder="Your Email" runat="server" Required="required"></asp:TextBox>
                            <asp:TextBox ID="txt_phone" class="contct-form" placeholder="Phone" runat="server" Required="required"></asp:TextBox>
                            <asp:TextBox ID="txt_com" class="contct-form" placeholder="Company Name" runat="server" Required="required"></asp:TextBox>
                            <asp:TextBox ID="txt_msg" class="contct-form" placeholder="Message" runat="server" Required="required" TextMode="MultiLine" Rows="10" Columns="30"></asp:TextBox>

                            
                            <asp:Button ID="Req" class="request" runat="server" Text="Request" OnClick="Req_Click" /><br><br>
                            
                        </form>
                    </div>
                </div>

            </div>
        </section>



        <footer class="supplier-footer">
            <ul>
                <li><a href="#tophead">Home</a></li>
                <li><a href="#addd">View Advertisement</a></li>
                <li><a href="#former">Tender Request</a></li>
            </ul>
            <p class="footer-title">&copy; State Pharmaceuticals Corporation of Sri Lanka Since 2008</p>
        </footer>
    </div>
    
</body>
</html>
