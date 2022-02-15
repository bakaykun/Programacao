<?php

class ConnectionFactory{
	private $db_host;
	private $db_name;
	private $db_user;
	private $db_pass;
	private static $instance;

	public function __construct(){
		$this->db_host = 'localhost';
		$this->db_name = 'final';
		$this->db_user = 'root';
		$this->db_pass = '';		
	}

	public function getInstance(){
		if (!isset(self::$instance)){
			try{
				self::$instance = new PDO('mysql:host='.$this->db_host.';dbname='.$this->db_name,
										$this->db_user, $this->db_pass);
				self::$instance->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
				self::$instance->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_OBJ);

			} catch(PDOException $e) {
				echo $e->getMessage();
			}
		}
		return self::$instance;
	}
}

?>