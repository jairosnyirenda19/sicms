<?php

/**

 */

class Hash
{
	public static function make($string, $salt = '')
	{
		return hash('sha256', $string . $salt);
	}

	public static function salt()
	{
		$salt = mktime(rand(1,24),rand(1,60),rand(1,60),rand(1,28),rand(1,12),rand(1970, 2019));
		$encry_saltone  = md5($salt);
		$encry_salttwo = crypt($encry_saltone, "&l@ry");
		$encry_saltthree = sha1($encry_salttwo);
	
	 	return $encry_saltthree;		
	}

	public static function unique()
	{
		return self::make(uniqid());
	}
}