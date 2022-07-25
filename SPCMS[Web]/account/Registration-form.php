<?php 
require_once '../core/initInternal.php';

	if(isset($_POST['submit'])){
		if(Token::check(Input::get('token')))
		{
			$user = new User();
			$salt = Hash::salt();
			try {

				$user->Register('customer', array(
					'Firstname' => Input::get('firstname'), 
					'Lastname' => Input::get('lastname'), 
					'Contact' => Input::get('contact'), 
					'Email' => Input::get('email'), 
					'Address' => Input::get('address'), 				
					'Joined' => date('Y-m-d H:i:s')
				));

				$user->Register('customer_account', array(
					'username' => Input::get('username'),
					'customer_id' =>  DB::getInstance()->lastid(),
					'password' => Hash::make(Input::get('password'), $salt), 
					'salt' => $salt
				));

				Session::put("Action", true);
				Session::put("Message", "You have Registered successfully. Get Stared right away :)");
				Redirect::to('Loading-page.php');
			}catch (Exception $e) 
			{
				Session::put("Action", false);
				Session::put("Message", "Registration failed. Please try again later :(");
				Redirect::to('Loading-page.php');
			}
		}
		else{
				Session::put("Action", false);
				Session::put("Message", "Registration failed. Please try again later :(");
				Redirect::to('Loading-page.php');
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
	<title>Seed Production | Registration</title>
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
		<div class="container" style="margin-top: 100px; margin-bottom: 50px;">	
			<div align="center" class="" style="margin:0 0 20px;">
				<img style="width: 100px; height: 100px;" src="../images/image002.jpg">
			</div>
			<div style="margin: 0 0 25px; padding: 10px; background-color: rgb(238, 238, 238);">
				<span>Already have an Account ? Simply <a href="Login-form.php">login</a> and get started... <a href="Login-form.php">Click Here</a> to login</span>
			</div>			
			<div class="form-wizard-register">
				<form method="POST" action="">
					<div class="position-wizard">
						<div class="tab">
							<h4>1. Account</h4>
						</div>
						<div class="tab">
							<h4>2. Profile</h4>
						</div>
						<div class="tab">
							<h4>3. Finish</h4>
						</div>
					</div>
						<div class="slide">
							<h3>Account</h3>
                            <section>
                                <label for="username">Username *</label>
                                <span id="usernameFailed" class="required-text"></span>
                                <input id="username" name="username" type="text" class="required form-control">

                                <label for="password">Password *</label>
                                <span id="passwordFailed" class="required-text"></span>
                                <input id="password" name="password" type="text" class="required form-control">

                                <label for="confirm">Confirm Password *</label>
                                <span id="" class="required-text"></span>
                                <input id="confirm" name="confirm" type="text" class="required form-control">

                                <p>(*) Mandatory</p>
                            </section>
                            <div class="nav-btns">
                            	<div class="arrows-nav" onclick="AccountValidate(+1)">Next</div>
							</div>
						</div>

						<div class="slide">
                            <h3>Profile</h3>
                            <section>
                       	        <label for="name">First name *</label>
                       	        <span class="required-text"></span>
                       	        <input id="name" name="firstname" type="text" class="required form-control">

                                <label for="surname">Last name *</label>
                                <span class="required-text"></span>   
                       	        <input id="surname" name="lastname" type="text" class="required form-control">

                       	        <label for="contact">Contact * (099)-999-9999</label>
                                <span class="required-text"></span>   	        
                   	            <input id="contact" name="contact" type="text" class="form-control">

                       	        <label for="email">Email</label>
                       	       	<span class="required-text"></span>  
                   	            <input id="email" name="email" type="text" class="email form-control">

                           	    <label for="address">Address</label>
                          	    <input id="address" name="address" type="text" class="form-control">
                                <p>(*) Mandatory</p>
                            </section>
                            <div class="nav-btns">
                            	<div class="arrows-nav" onclick="ProfileValidate(+1)">Next</div>
								<div class="arrows-nav" onclick="plusIndex(-1)">Previous</div>
							</div>                            
						</div>

						<div class="slide">
							<h3>Finish</h3>
                            <section>
                                <input id="acceptTerms" name="acceptTerms" type="checkbox" class="required">
                                <label for="acceptTerms">I agree with the Terms and Conditions.</label>
                            </section>
                            <input type="hidden" name="token" id="token" value="<?php echo Token::generate();?>">
                            <div class="nav-btns">
                            	<button type="submit" name="submit">Sign Up</button>
								<div class="arrows-nav" onclick="plusIndex(-1)">Previous</div>
							</div>                            
						</div>						
					</form>
				</div>	
				
			</div>


	<button id="topBtn"><i class="fa fa-chevron-up"></i></button>

	<script type="text/javascript" src="../js/jquery.js"></script>
	<script type="text/javascript" src="../js/bootstrap.js"></script>
	<script type="text/javascript" src="../js/jquery.isotope.min.js"></script>  
	<script type="text/javascript" src="../js/wow.min.js"></script>
	<script type="text/javascript" src="../js/features.js"></script>
	<script type="text/javascript" src="../js/form-validation.js"></script>
	<script type="text/javascript" src="../js/JQueryAJAX.js"></script>

	<script type="text/javascript">

				
	</script>
</body>
</html>