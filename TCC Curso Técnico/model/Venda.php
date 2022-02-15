<?php
class Venda{
	private $id;
	private $cliente;
	private $dataVenda;
	private $valorTotal;

	public function getId() {
		return $this->id;
	}
	 
	public function setId($id) {
	    $this->id = $id;
	}

	public function getCliente() {
		return $this->cliente;
	}
	 
	public function setCliente($cliente) {
	    $this->cliente = $cliente;
	}

	public function getDataVenda() {
	    return $this->dataVenda;
	}
	 
	public function setDataVenda($dataVenda) {
	    $this->dataVenda = $dataVenda;
	}

	public function getValorTotal() {
	    return $this->valorTotal;
	}
	 
	public function setValorTotal($valorTotal) {
	    $this->valorTotal = $valorTotal;
	}
}
?>