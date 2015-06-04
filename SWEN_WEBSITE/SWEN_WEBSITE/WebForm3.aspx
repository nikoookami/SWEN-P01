<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="SWEN_WEBSITE.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>HOTEL</title>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
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
                <a href="#" id="loginButton"><img src="images/login.png"><span>Login</span></a>
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
        <div class="container_wrap">
            <div class="content_middle">
                <h2>Room Availability</h2>
                <div id="demo">
                
                    </div>
                <br>
                <button class="btn btn-primary" onclick="myFunction()">Refresh</button>
                <button class="btn btn-primary" onclick="window.location.href = 'WebForm4.aspx'">Book Your Room Now</button>
            </div>
        </div>
       
</body>

</html>
<script>
    function myFunction() {
        var v = Math.floor((Math.random() * 40) + 60);
        var x = Math.floor((Math.random() * 30) + 50);
        var y = Math.floor((Math.random() * 20) + 70);
        var z = Math.floor((Math.random() * 10) + 90);
        document.getElementById("demo").innerHTML = "Single Room: " + v+"%" + "<br>Junior Suite: " + x+"%" + "<br>Excutive Suite: " + y+"%" + "<br>Grand Suite: "+z+"%";
    }
</script>