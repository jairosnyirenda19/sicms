<?php

/**
 * 
 */
class User
{
	private $_db,
			$_data,
			$_sessionName,
			$_cookieName,
			$_isLoggedIn;		

	function __construct($user = null)
	{
		$this->_db = DB::getInstance();
		$this->_sessionName = Config::get('session/session_name');
		$this->_cookieName = Config::get('remember/cookie_name');
		if(!$user){
			if(Session::exists($this->_sessionName)){
				$user = Session::get($this->_sessionName);
				if($this->find($user)){
					$this->_isLoggedIn = true;					
				}else{
				}
			}
		}else{
			$this->find('customer_account', $user);
		}
	}

	public function isLoggedIn()
	{
		return $this->_isLoggedIn;
	}


	public function Register($table, $fields = array())
	{
		if(!$this->_db->insert($table, $fields)){
			throw new Exception("Error Processing Request", 1);			
		}
	}



	public function logout($accountsession = null, $user_id = null){

		$this->_db->delete($accountsession, array('user_id', '=' , $user_id)); 
		Session::delete($this->_sessionName);
		Cookie::delete($this->_cookieName);
	}

	public function getUsername()
	{
				
	}

	public function find($account = null, $user = null){
		if($user){
			$fields = (is_numeric($user)) ? 'user_id' : 'username' ;
			$data = $this->_db->get($account, array($fields,'=', $user));
			if($data->count()){
				$this->_data = $data->first();
				return true;
			}
		}
		return false;
	}
	
	public function GetUserLoggedIn($hash)
	{
		$x = $this->_db->get('customer_sessions', array('hash' , '=', $hash));
		if($x->count() > 0)
		{
			return true;
		}
		return false;
	}

	public function login($AccountType = array(), $username = null, $password = null, $remember = false)
	{	
		if (count($AccountType) == 0) {
				$AccountType = array('customer_account','customer_sessions');
			}
				
		if(!$username && !$password &&  $this->exists())
			{
				Session::put($this->_sessionName, $this->data()->user_id);
			}else{
				$user = $this->find($AccountType[0], $username);
				if($user){
					if($this->data()->password === Hash::make($password, $this->data()->salt)){
						Session::put($this->_sessionName, $this->data()->user_id);
						if ($remember) {
							$hash = Hash::unique();
							$hashCheck = $this->_db->get($AccountType[1], array('user_id' , '=', $this->data()->user_id));

							if(!$hashCheck->count()){
								$this->_db->insert($AccountType[1],array(
									'user_id' => $this->data()->user_id,
									'hash' => $hash
								));
							}else{
								$hash = $hashCheck->first()->hash;
							}

							Cookie::put($this->_cookieName, $hash, Config::get('remember/cookie_expiry'));
						}
						return true;
					}
				}
			}
		return false;
	}

	public function exists(){
		return (!empty($this->_data)) ? true : false;
	}

	public function data(){
		return $this->_data;
	}
}