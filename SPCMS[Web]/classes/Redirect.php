<?php

class Redirect{

	public static function to($location = null){
		if($location){
			if (is_numeric($location)) {
				switch ($location) {
					case 404:
						header('HTTP/1.0 404 Not Found');
						include 'includes/errors/404.php';
						exit();
						break;
					
					default:
						# code...
						break;
				}
			} else {
				# code...
			}
			
			header('Location: ' . $location);
			exit();
		}
	}

public static function to_time($time = null, $location = null){
		if($location){
			if (is_numeric($location)) {
				switch ($location) {
					case 404:
						header('HTTP/1.0 404 Not Found');
						include 'includes/errors/404.php';
						exit();
						break;
					
					default:
						# code...
						break;
				}
			} else {
				# code...
			}
			header('Refresh: '.$time.'; URL='.$location.'');	
			exit();
		}
	}	
}