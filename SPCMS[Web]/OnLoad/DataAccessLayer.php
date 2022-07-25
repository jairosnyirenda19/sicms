<?php 

/**
 * 
 */
class DataAccessLayer
{
	private $server;
	private $user;
	private $password;
	private $database;
	private $conn;
	private $port; 
	private $debug;

	public function getConnection()
    {
        return $this->conn;
    }

	function __construct()
	{		
		//session_start();
		$this->server = 'localhost';
		$this->user = 'root';
		$this->password = '';
		$this->database = 'sicms';
		$this->conn = false;
		$this->port = '3306';
		$this->debug = true;
		$this->connect();
	}

	function __destruct()
	{
		$this->disconnect();
	}

	function connect()
	{
		if(!$this->conn)
		{
			$this->conn = mysqli_connect($this->server, $this->user, $this->password);
			$select =  mysqli_select_db($this->conn,$this->database);
			if ($select) {
				$_SESSION['checkIfExist'] = true;
			}else
			{
				$_SESSION['checkIfExist'] = false;			
			}

			mysqli_set_charset($this->conn,'utf8');

			if (!$this->conn) {
				$this->status_fatal = true;
				echo "Connection to database has failed";
				die();
			} 
			else {
				$this->status_fatal = false;
			}			
		}
		return $this->conn;
	}

	function disconnect()
	{
		if($this->conn)
		{
			mysqli_close($this->conn);
		}		
	}
}
?>