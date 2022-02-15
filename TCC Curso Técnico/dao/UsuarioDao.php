<?php
	require_once '../model/usuario.php';
	require_once 'ConnectionFactory.php';

	class UsuarioDao extends ConnectionFactory{
		protected $table = "usuario";

		public function delete($id){
			$sql = "DELETE FROM $this->table WHERE id = :id";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':id', $id, PDO::PARAM_INT);
			$stmt->execute();
		}

		public function efetuarLogin($nome, $senha){		
			$sql = "SELECT * FROM $this->table WHERE nome = :nome AND senha = :senha";
			$stmt = $this->getInstance()->prepare($sql);

			$stmt->bindParam(':nome', $nome, PDO::PARAM_STR, 50);
			$stmt->bindParam(':senha', $senha, PDO::PARAM_STR, 32);
			$stmt->execute();
			return $stmt->fetch();
		}

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

		public function insert($usuario){
			$nome = $usuario->getNome();
			$senha = $usuario->getSenha();
			$tipo = $usuario->getTipo();

	        $sql = "insert into $this->table (nome, senha, tipo) values (:nome, :senha, :tipo)";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':nome', $nome);
			$stmt->bindParam(':senha', $senha);
			$stmt->bindParam(':tipo', $tipo);
			$stmt->execute();
		}

		public function search($nome){		
			$sql = "SELECT * FROM $this->table WHERE nome LIKE :nome";
			$stmt = $this->getInstance()->prepare($sql);
			$nome = "%".$nome."%";

			$stmt->bindParam(':nome', $nome, PDO::PARAM_STR, 50);
			$stmt->execute();
			return $stmt->fetchAll();
		}

		public function update($usuario){
			$nome = $usuario->getNome();
			$id= $usuario->getId();

	        $sql = "update $this->table set nome = :nome where id = :id";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':nome', $nome);
			$stmt->bindParam(':id', $id);
			$stmt->execute();
		}
	}
?>