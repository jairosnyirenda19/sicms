<?php
session_start();
$GLOBALS['config'] = array(
	'mysql' => array(
		'host' => '127.0.0.1',
		'username' => 'root',
		'password' => '',
		'db' => 'sicms'
	),

	'remember'=> array(
		'cookie_name' => 'hash',
		'cookie_expiry' => 604800
	),

	'session'=> array(
		'session_name' => 'user',
		'token_name' => 'token'
	),

	'dir'=> array(
		'img_dir' => '../files/images/')
);

spl_autoload_register(function($class)
{
	require_once '../classes/' . $class . '.php';
});

require_once '../functions/Sanitize.php';