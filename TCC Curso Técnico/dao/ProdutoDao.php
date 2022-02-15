<?php
	require_once '../model/produto.php';
	require_once 'ConnectionFactory.php';

	class ProdutoDao extends ConnectionFactory{
		protected $table = "produto";

		public function delete($id){
			$sql = "DELETE FROM $this->table WHERE id = :id";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':id', $id, PDO::PARAM_INT);
			$stmt->execute();
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

		public function insert($produto){
			$descricao = $produto->getDescricao();
			$valor = $produto->getValor();
			$imagem = $produto->getImagem();

	        $sql = "insert into $this->table (descricao, valor, imagem)
	        	values (:descricao, :valor, :imagem)";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':descricao', $descricao);
			$stmt->bindParam(':valor', $valor);
			$stmt->bindParam(':imagem', $imagem);
			$stmt->execute();
		}

		public function search($descricao){		
			$sql = "SELECT * FROM $this->table WHERE descricao LIKE :descricao";
			$stmt = $this->getInstance()->prepare($sql);
			$descricao = "%".$descricao."%";

			$stmt->bindParam(':descricao', $descricao, PDO::PARAM_STR, 50);
			$stmt->execute();
			return $stmt->fetchAll();
		}

		public function update($produto){
			$id = $produto->getId();
			$descricao = $produto->getDescricao();
			$valor = $produto->getValor();
			$imagem = $produto->getImagem();

	        $sql = "update $this->table set descricao = :descricao, valor = :valor, imagem = :imagem where id = :id";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':descricao', $descricao);
			$stmt->bindParam(':valor', $valor);
			$stmt->bindParam(':imagem', $imagem);
			$stmt->bindParam(':id', $id);
			$stmt->execute();
		}
	}
?>