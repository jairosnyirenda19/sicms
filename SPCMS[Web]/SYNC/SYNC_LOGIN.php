<?php
require_once '../core/initInternal.php';

if(isset($_POST['Username']) && isset($_POST['Password'])){
	$user = new User();
	$AccountType = array('user_account','user_sessions');
	$uname = $_POST['Username'];
	$psswd = $_POST['Password'];
	$remember = ($_POST['Remember'] == "Remember") ? true: false;
	$login = $user->login($AccountType, $uname, $psswd, $remember);
	$Log = ($login) ? 1 : 0;
	echo $Log;
}
