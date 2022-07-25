<?php  
	require_once '../core/initInternal.php';
	$user = null;

	if(Cookie::exists(Config::get('remember/cookie_name')) && !Session::exists(Config::get('session/session_name')))
	{
			$hash = Cookie::get(Config::get('remember/cookie_name'));
			$hashCheck = DB::getInstance()->get('customer_sessions', array('hash','=', $hash));
			if ($hashCheck->count() > 0) {
				$user = new User($hashCheck->first()->user_id);			
				$logout = $user->logout('customer_sessions', $hashCheck->first()->user_id);
			}
	}
	else if(Cookie::exists(Config::get('remember/cookie_name')) && Session::exists(Config::get('session/session_name')))
	{
			$hash = Cookie::get(Config::get('remember/cookie_name'));
			$hashCheck = DB::getInstance()->get('customer_sessions', array('hash','=', $hash));
			if ($hashCheck->count() > 0) 
			{
				$user = new User($hashCheck->first()->user_id);			
				$logout = $user->logout('customer_sessions', $hashCheck->first()->user_id);		
			}
	}
	Redirect::to('../index.php');


?>