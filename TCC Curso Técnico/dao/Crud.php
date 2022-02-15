<?php

require_once 'ConnectionFactory.php';

abstract class Crud extends ConnectionFactory{
	protected $table;

	abstract public function insert($classe);
	abstract public function update($id);

	public function find($id){
		$sql = "SELECT * FROM $this->table WHERE id = :id";
		$stmt = $this->getInstance()->prepare($sql);
		$stmt->bindParam(':id', $id, PDO::PARAM_INT);
		$stmt->execute();
		return $stmt->fetch();
	}

	public function findAll(){		
		$sql = "SELECT * FROM $this->table";
		$stmt = $this->getInstance()->prepare($sql);
		$stmt->execute();
		return $stmt->fetchAll();
	}

	public function search($nome){		
		$sql = "SELECT * FROM $this->table WHERE nome LIKE :nome";
		$stmt = $this->getInstance()->prepare($sql);
		$nome = "%".$nome."%";
		echo($nome);
		$stmt->bindParam(':nome', $nome, PDO::PARAM_STR, 50);
		$stmt->execute();
		return $stmt->fetchAll();
	}


	public function delete($id){
		$sql = "DELETE FROM $this->table WHERE id = :id";
		$stmt = $this->getInstance()->prepare($sql);
		$stmt->bindParam(':id', $id, PDO::PARAM_INT);
		$stmt->execute();
	}
}

?>