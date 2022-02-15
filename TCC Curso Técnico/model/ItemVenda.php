<?php
class ItemVenda{
	private $id;
	private $venda;
	private $quantidade;
	private $produto;
	private $valorUnitario;

	public function __construct(){
		$produto = new Produto();
	}

	public function getId() {
		return $this->id;
	}
	 
	public function setId($id) {
	    $this->id = $id;
	}

	public function getQuantidade() {
	    return $this->quantidade;
	}
	 
	public function setQuantidade($quantidade) {
	    $this->quantidade = $quantidade;
	}

	public function getProduto() {
	    return $this->produto;
	}
	 
	public function setProduto($produto) {
	    $this->produto = $produto;
	}

	public function getValorUnitario() {
	    return $this->valorUnitario;
	}
	 
	public function setValorUnitario($valorUnitario) {
	    $this->valorUnitario = $valorUnitario;
	}

	public function getVenda() {
		return $this->venda;
	}
	 
	public function setVenda($venda) {
	    $this->venda = $venda;
	}
}
?>