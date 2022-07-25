<?php
require_once '../core/initInternal.php';
	$server = Config::get('mysql/host');
	$user = Config::get('mysql/username');
	$pass = Config::get('mysql/password');
	$database = Config::get('mysql/db');

	$conn = new mysqli($server, $user, $pass);
	$select = mysqli_select_db($conn, $database);
	if ($conn->connect_error) 
	{
		die("Connection failed: " . $conn->connect_error);
	}

	if(isset($_POST['dir'])){
		$dir = explode('.', $_POST['dir']);
		$id = $dir[0];
		$id_col = $dir[1];
		$tbl = $dir[2];
		$col = $dir[3];

		$stmt = $conn->prepare("SELECT $col FROM $tbl WHERE $id_col = ?");
		$stmt->bind_param("i", $id);

		$image = '';
		$stmt->execute();

		$stmt->bind_result($imgdir);
		$stmt->fetch();
		echo '../'.$imgdir;
	}
