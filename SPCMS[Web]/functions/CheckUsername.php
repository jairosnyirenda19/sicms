<?php
require_once '../core/initInternal.php';

$usernameStatus = '';
if ($_POST["username"] != null || $_POST["username"] != "") {
	$output = DB::getInstance()->get('customer_account' , array('username','=', $_POST["username"]));
	$usernameStatus = '';
	if($output)
	{
		foreach ($output->results() as $output) {
			$usernameStatus = 'Username already taken. Please choose another one';
		}
	}
}
echo $usernameStatus;
