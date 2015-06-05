<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="SWEN_WEBSITE.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
    <title>HOTEL</title>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <!-- Custom Theme files -->
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <!-- Custom Theme files -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!--webfont-->
    <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <script type="text/javascript" src="js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="js/login.js"></script>
    <script src="js/jquery.easydropdown.js"></script>
    <!--Animation-->
    <script src="js/wow.min.js"></script>
    <link href="css/animate.css" rel='stylesheet' type='text/css' />
    <script>
        new WOW().init();
    </script>

    <div class="header">
        <div class="col-sm-8 header-left">
            <div class="logo">
                <a>WELCOME OUR HOTEL</a>
            </div>
            <div class="menu">
                <a class="toggleMenu" href="#"><img src="images/nav.png" alt="" /></a>
                <ul class="nav" id="nav">
                    <li class="active"><a href="#">About</a></li>
                    <li><a href="#">ROOM TYPE</a></li>
                    <li><a href="#">Register</a></li>


                    <div class="clearfix"></div>
                </ul>
                <script type="text/javascript" src="js/responsive-nav.js"></script>
            </div>
            <!-- start search-->
            <div class="search-box">
                <div id="sb-search" class="sb-search">
                    <form>
                        <input class="sb-search-input" placeholder="Enter your search term..." type="search" name="search" id="search">
                        <input class="sb-search-submit" type="submit" value="">
                        <span class="sb-icon-search"> </span>
                    </form>
                </div>
            </div>
            <!----search-scripts---->
            <script src="js/classie.js"></script>
            <script src="js/uisearch.js"></script>
            <script>
                new UISearch(document.getElementById('sb-search'));
            </script>
            <!----//search-scripts---->
            <div class="clearfix"></div>
        </div>
        <div class="col-sm-4 header_right">
            <div id="loginContainer">
                <a href="#" id="loginButton"><img src="images/login.png"><span>LogOut</span></a>
                <div id="loginBox">
                    <form id="loginForm">
                        <fieldset id="body">
                            <fieldset>
                                <label for="email">Email Address</label>
                                <input type="text" name="email" id="email">
                            </fieldset>
                            <fieldset>
                                <label for="password">Password</label>
                                <input type="password" name="password" id="password">
                            </fieldset>
                            <input type="submit" id="login" value="Sign in">
                             <input type="submit" id="Register" value="Register?">
                            <label for="checkbox"><input type="checkbox" id="checkbox"> <i>Remember me</i></label>
                        </fieldset>
                        <span><a href="#">Forgot your password?</a></span>
                    </form>
                </div>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>

</head>
    <body>
    
        <div class="banner">
            <div class="container">
                <div class="container_wrap">
                    <h1>Displaying your details</h1>
                    <div class="living_middle">
                    <form runat="server" >
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="guestid" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone"  />
                                <asp:BoundField DataField="country" HeaderText="country" SortExpression="country" />
                                <asp:BoundField DataField="postalcode" HeaderText="postalcode" SortExpression="postalcode" />
                                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                <asp:BoundField DataField="paymenttype" HeaderText="paymenttype" SortExpression="paymenttype" />
                                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                <asp:BoundField DataField="guestid" HeaderText="guestid" ReadOnly="True" SortExpression="guestid" />
                            </Columns>
                        </asp:GridView>  
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DelonixRegiaConnectionString %>" SelectCommand="SELECT [phone], [country], [postalcode], [address], [email], [paymenttype], [name], [guestid] FROM [Guest]"></asp:SqlDataSource>
                   </form>
                        </div>
                </div>
            </div>
    </div>
    <footer>
        <p >Copy Right 2015</p>
       
    </footer>
</body>
</html>
