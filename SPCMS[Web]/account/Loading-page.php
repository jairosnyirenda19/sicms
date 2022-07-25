<link rel="stylesheet" type="text/css" href="css/bootstrap/bootstrap.min.css">
<?php 
	require_once '../core/initInternal.php';

	$state = Session::get("Action");
	$message = Session::get("Message");
	Session::delete("Action");
	Session::delete("Message");	
	if (!$state) 
	{
	  	echo '<div align="center" style="font-size: 18pt;" class="alert alert-danger">'.$message.'</div>';
		Redirect::to_time(3, 'Registration-form.php');		
	}
	else
	{
	  	echo '<div align="center" style="font-size: 18pt;" class="alert alert-success"> '.$message.'</div>';
	  	Redirect::to_time(3, 'Login-form.php');	
	}
?>


<!DOCTYPE html>
<html>
<head>
	<title>SCMS - Message</title>
</head>
<body>
<style type="text/css">
	.loadingpage-body
	{
		margin: 0;
		padding: 0;
		width: 100%;
		height: 100vh;
		position: relative;
	}
	.loading-container
	{
		width: 140px;
		top: 30%;
		left: 45%;		
		position: absolute;
	}
	.box
	{
		width: 40px;
		height: 40px;
		background-color: rgb(57, 55, 72); 
		display: inline-block;
		animation: pulse 0.6s ease-in infinite alternate;
	}

	.box2, .box3
	{
		animation-delay: 0.6s
	}

	@keyframes pulse
	{
		100%
		{
			opacity: 0;
		}
	}
</style>

<div class="loadingpage-body">
	<div class="container loading-container" align="center">
		<div class="box box1"></div>
		<div class="box box2"></div>
		<div class="box box3"></div>
		<div class="box box4"></div>				
	</div>
</div>
</body>
</html>