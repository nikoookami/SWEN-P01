<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="SWEN_WEBSITE.WebForm4" %>

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
<<<<<<< HEAD
                <a href="#" id="loginButton"><img src="images/login.png"><span>Login</span></a>
=======
                <a href="#" id="loginButton"><img src="images/login.png"><span>LogOut</span></a>
>>>>>>> origin/ChunFoong
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
<<<<<<< HEAD
=======
                             <input type="submit" id="Register" value="Register?">
>>>>>>> origin/ChunFoong
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
                    <h1>Fill Up Your Details To Book Your Room</h1>
                    <form runat="server" >
                        <asp:TextBox ID="TextBox" runat="server" Width="500px" TabIndex="1" placeholder="Full Name"></asp:TextBox>
                        <br>
                          <asp:TextBox ID="TextBox1" runat="server" Width="500px" TabIndex="1" placeholder="Phone Number"></asp:TextBox>
                        <br>
                          <asp:TextBox ID="TextBox2" runat="server" Width="500px" TabIndex="1" placeholder="Email"></asp:TextBox>
                        <br>
                          <asp:TextBox ID="TextBox3" runat="server" Width="500px" TabIndex="1" placeholder="Address"></asp:TextBox>
                        <br>
                          <asp:TextBox ID="TextBox4" runat="server" Width="500px" TabIndex="1" placeholder="Postal"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox5" runat="server" Width="500px" TabIndex="1" placeholder="Country"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox6" runat="server" Width="500px" TabIndex="1" placeholder="No. Of Adults"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox7" runat="server" Width="500px" TabIndex="1" placeholder="No. Of Children"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox8" runat="server" Width="500px" TabIndex="1" placeholder="Check-In Date e.g ddMMyyyy"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox9" runat="server" Width="500px" TabIndex="1" placeholder="Check-Out Date e.g ddMMyyyy"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox10" runat="server" Width="500px" TabIndex="1" placeholder="No Of Room"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox11" runat="server" Width="500px" TabIndex="1" placeholder="Room Type"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox12" runat="server" Width="500px" TabIndex="1" placeholder="Payment Type"></asp:TextBox>
                        <br>  
                        <asp:TextBox ID="TextBox13" runat="server" Width="500px" TabIndex="1" placeholder="Remarks"></asp:TextBox>
                        
                          <br> 
                            
                            <asp:Button class="btn btn-primary" id="b1" Text="Submit" runat="server" OnClick="b1_Click" />
                      
            </form>
                   
                </div>
            </div>
    </div>
    <footer>
        <p >Copy Right 2015</p>
       
    </footer>
</body>
</html>
