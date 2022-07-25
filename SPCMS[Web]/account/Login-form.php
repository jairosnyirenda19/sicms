<?php 
	include '../core/initInternal.php';

	Session::delete('user');

	if(Input::exists())
	{
		if(Token::check(Input::get('token')))
		{
			try {
				$user = new User();
				$AccountType = array('customer_account','customer_sessions');
				$remember = (Input::get('remember') === 'on') ? true : false ;
				$login = $user->login($AccountType, Input::get('username'), Input::get('password'), $remember);
				if ($login) {
					Session::put("Username",Input::get('username'));
					Redirect::to('account.php');
				}else{
					echo '<script></script>';
				}
			} catch (Exception $e) {
				
			}
		}		
	}  

?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
		
	<link rel="stylesheet" type="text/css" href="../css/style.css">
	<link rel="stylesheet" type="text/css" href="../css/account.css">	
	<link rel="stylesheet" type="text/css" href="../css/customizables.css">
	<link rel="stylesheet" type="text/css" href="../css/fonts/font-awesome/css/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="../css/animation/animate.css">	
	<link rel="stylesheet" type="text/css" href="../css/bootstrap/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="../css/bootstrap/bootstrap-theme.min.css">
	<link rel="stylesheet" type="text/css" href="../css/animation/animate.css">
	<title>Seed Production | Login</title>
</head>
<body>

	<header>
		<nav>
			<ul class="logo">
				<a href="../BARS.html"><img src="../images/logo_2.jpg" alt="logo"> BARS</a>
			</ul>

			<div class="separator"></div>

			<ul class="main-menu">
				<li><a href="../BARS.html">HOME</a></li>
				<li><a href="Login-form.php">LOGIN</a></li>
				<li><a href="Registration-form.php">REGISTRATION</a></li>
				<li><a href="#">ABOUT US</a></li>
				<li><a href="#">CONTACT US</a></li>
			</ul>
			<span class="menu-icon"><i class="fa fa-bars"></i></span>
		</nav>	
	</header>

	<div class="container" style="margin-top: 100px;">
		<div align="center" class="" style="margin:0 0 20px;">
			<img style="width: 100px; height: 100px;" src="../images/image002.jpg">
		</div>

		<div style="margin: 0 0 25px; padding: 10px; background-color: rgb(238, 238, 238);">
			<span>You do not have an Account ? Simply <a href="Registration-form.php">register</a> and get started... <a href="Registration-form.php">Click Here</a> to register</span>
		</div>		
		<div class="login" style="padding: 40px; background-color: rgb(238, 238, 238);">
			<form action="" name="login-form" onsubmit="return validateForm()" method="POST">
				<h3>Login</h3>
				<section>
	               <label for="username">Username *</label>
	               <span id="usernameFailed" class="required-text"></span>
	               <input id="username" name="username" type="text" class="required form-control">

                   <label for="password">Password *</label>
                   <span id="passwordFailed" class="required-text"></span>
                   <input id="password" name="password" type="password" class="required form-control">
                   <input type="hidden" name="token" id="token" value="<?php echo Token::generate();?>">

					<div class="form-group">
						<div class="checkbox">
							<label>
								<input type="checkbox" name="remember" id="remember"> Remember me
							</label>
						</div>
					</div>

                    <div class="nav-btns">
                        <button type="submit">Sign In</button>
					</div> 
                </section>
			</form>
		</div>
	</div>

	<script type="text/javascript">
		var username = document.getElementById("username");
		var password = document.getElementById("password");
		var requiredText = document.getElementsByClassName("required-text");
		function validateForm() {
    		var x = document.forms["login-form"]["username"].value;
    		var y = document.forms["login-form"]["password"].value;
    		if (x == "" && y == "") {
    			username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
    			password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
			 	for (var i = 0; i < 2; i++) {
			 		requiredText[i].innerHTML = "This field is required."; 		
			 	}    			
        		return false;
        	}else if(x == "")
        	{
        		username.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
       	 		requiredText[0].innerHTML = "This field is required."; 		
        		return false;
        	}else if(y == "")
        	{
        		password.setAttribute("style", "background-color: #FBC1C3; outline-color: red;");
        	 	requiredText[1].innerHTML = "This field is required.";		
        		return false;
        	}
}
	</script>

	<button id="topBtn"><i class="fa fa-chevron-up"></i></button>

	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<script type="text/javascript" src="js/jquery.isotope.min.js"></script>  
	<script type="text/javascript" src="js/wow.min.js"></script>
	<script type="text/javascript" src="js/features.js"></script>
</body>
</html>