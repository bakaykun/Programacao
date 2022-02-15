<?php
	require_once '../model/produto.php';
	require_once 'ConnectionFactory.php';

	class VendaDao extends ConnectionFactory{
		protected $table = "venda";

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

		public function findMaxId(){
			//$sql = "SELECT MAX(id) as max_id FROM $this->table";
			//$stmt = $this->getInstance()->prepare($sql);
			//$stmt->execute();
			//$maxId = $stmt->fetch();
			//return $maxId['max_id'];
			return $this->getInstance()->lastInsertId();
		}

		public function insert($venda){
			$data_venda = $venda->getDataVenda();
			$valor_total = $venda->getValorTotal();
			$id_cliente = $venda->getCliente()->id;

	        $sql = "insert into $this->table (data_venda, valor_total, id_cliente)
	        	values (:data_venda, :valor_total, :id_cliente)";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':data_venda', $data_venda);
			$stmt->bindParam(':valor_total', $valor_total);
			$stmt->bindParam(':id_cliente', $id_cliente);
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

		public function update($usuario){
			$descricao = $produto->getDescricao();
			$valor = $produto->getValor();

	        $sql = "update $this->table set descricao = :descricao, valor = :valor where id = :id";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':descricao', $descricao);
			$stmt->bindParam(':valor', $valor);
			$stmt->execute();
		}
	}
?>