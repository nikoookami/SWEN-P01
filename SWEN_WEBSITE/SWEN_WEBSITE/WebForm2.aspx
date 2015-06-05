<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SWEN_WEBSITE.WebForm2" %>

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
        <div class="container_wrap">
            <div class="content_middle">
                <!-- Responsive calendar - START -->
                <h2 class="alert-success">Select Your Prefered Date Based On the Available Date below</h2>
                <div class="responsive-calendar">
                    <div class="controls">
                        <a class="pull-left" data-go="prev"><div class="btn btn-primary">Prev</div></a>
                        <h4><span data-head-year></span> <span data-head-month></span></h4>
                        <a class="pull-right" data-go="next" ><div class="btn btn-primary">Next</div></a>
                    </div><hr />
                    
                    <div class="days" data-group="days">

                    </div>
                </div>
                <!-- Responsive calendar - END -->
            </div>
            <script src="../js/jquery.js"></script>
            <script src="../js/bootstrap.min.js"></script>
            <script src="../js/responsive-calendar.js"></script>
            <script type="text/javascript">
                $(document).ready(function () {
                    $(".responsive-calendar").responsiveCalendar({
                        time: '2015-06',
                        events: {
                            "2015-06-09": { "url": "WebForm3.aspx" },
                            "2015-06-10": { "url": "WebForm3.aspx" },
                            "2015-06-11": { "url": "WebForm3.aspx" },
                            "2015-06-12": { "url": "WebForm3.aspx" },
                            "2015-06-13": { "url": "WebForm3.aspx" },
                            "2015-06-14": { "url": "WebForm3.aspx" },
                            "2015-06-15": { "url": "WebForm3.aspx" },
                            "2015-06-16": { "url": "WebForm3.aspx" },
                            "2015-06-17": { "url": "WebForm3.aspx" },
                            "2015-06-18": { "url": "WebForm3.aspx" },
                            "2015-06-19": { "url": "WebForm3.aspx" },
                            "2015-06-20": { "url": "WebForm3.aspx" },
                            "2015-06-21": { "url": "WebForm3.aspx" },
                            "2015-06-22": { "url": "WebForm3.aspx" },
                            "2015-06-23": { "url": "WebForm3.aspx" },
                            "2015-06-24": { "url": "WebForm3.aspx" },
                            "2015-06-25": { "url": "WebForm3.aspx" },
                            "2015-06-26": { "url": "WebForm3.aspx" },
                            "2015-06-27": { "url": "WebForm3.aspx" },
                            "2015-06-28": { "url": "WebForm3.aspx" },
                            "2015-06-29": { "url": "WebForm3.aspx" },
                            "2015-06-30": { "url": "WebForm3.aspx" },
                            "2015-06-31": { "url": "WebForm3.aspx" }
                        }
                    });
                });



            </script>

        </div>
    </div>
    <footer>
        <p>Copy Right 2015</p>

    </footer>
</body>

</html>
    
<meta charset="utf-8">

<meta name="distributor" content="Global" />
<meta itemprop="contentRating" content="General" />
<meta name="robots" content="All" />
<meta name="revisit-after" content="7 days" />
<meta name="description" content="The source of truly unique and awesome jquery plugins." />
<meta name="keywords" content="slider, carousel, responsive, swipe, one to one movement, touch devices, jquery, plugin, bootstrap compatible, html5, css3" />
<meta name="author" content="w3widgets.com">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href='http://fonts.googleapis.com/css?family=Economica' rel='stylesheet' type='text/css'>
<link href="css/animate.css" rel="stylesheet" />
<!-- Respomsive slider -->


<link href="../css/responsive-calendar.css" rel="stylesheet">


