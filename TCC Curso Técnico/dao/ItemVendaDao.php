<?php
	require_once '../model/ItemVenda.php';
	require_once 'ConnectionFactory.php';

	class ItemVendaDao extends ConnectionFactory{
		protected $table = "itemvenda";

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

		public function insert($itemVenda){
			$quantidade = $itemVenda->getQuantidade();
			$id_produto = $itemVenda->getProduto()->id;
			$valor_unitario = $itemVenda->getValorUnitario();
			$id_venda = $itemVenda->getVenda()->getId();

				echo ('passei');

	        $sql = "insert into $this->table (quantidade, id_produto, valor_unitario, id_venda)
	        	values (:quantidade, :id_produto, :valor_unitario, :id_venda)";
			$stmt = $this->getInstance()->prepare($sql);
			$stmt->bindParam(':quantidade', $quantidade);
			$stmt->bindParam(':id_produto', $id_produto);
			$stmt->bindParam(':valor_unitario', $valor_unitario);
			$stmt->bindParam(':id_venda', $id_venda);

							echo ('passei de novo');
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