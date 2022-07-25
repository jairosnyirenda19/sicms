<?php 

	require ('OnLoad/DataAccessLayer.php');
	require_once 'core/init.php';
	session_start();
	$objDataAccessLayer = new DataAccessLayer();
	$objDataAccessLayer -> connect();
	$login = false;
	$user = null;

	if ($_SESSION['checkIfExist'] == true) 
	{
		if(Cookie::exists(Config::get('remember/cookie_name')) && !Session::exists(Config::get('session/session_name'))){
			$hash = Cookie::get(Config::get('remember/cookie_name'));
			$hashCheck = DB::getInstance()->get('customer_sessions', array('hash','=', $hash));
			if ($hashCheck->count() > 0) {
				$user = new User($hashCheck->first()->user_id);			
				$login = $user->exists();
				Session::put("user", $hashCheck->first()->user_id);	


			}
		}
		else if(Cookie::exists(Config::get('remember/cookie_name')) && Session::exists(Config::get('session/session_name')))
		{
			$hash = Cookie::get(Config::get('remember/cookie_name'));
			$hashCheck = DB::getInstance()->get('customer_sessions', array('hash','=', $hash));
			if ($hashCheck->count() > 0) {
				$user = new User($hashCheck->first()->user_id);			
				$login = $user->exists();						
			}
		}

		if ($login) {
			Redirect::to('account/account.php');
		} else {
			Redirect::to('BARS.html');
		}
		
	}else
	{
		Redirect::to('OnLoad/Unavilable.php');
		session_destroy();
	}
?>