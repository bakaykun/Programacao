<?php
class Produto{
	private $id;
	private $descricao;
	private $valor;
	private $imagem;

	public function getId() {
		return $this->id;
	}
	 
	public function setId($id) {
	    $this->id = $id;
	}

	public function getDescricao() {
	    return $this->descricao;
	}
	 
	public function setDescricao($descricao) {
	    $this->descricao = $descricao;
	}

	public function getValor() {
	    return $this->valor;
	}
	 
	public function setValor($valor) {
	    $this->valor = $valor;
	}

	public function getImagem() {
	    return $this->imagem;
	}
	 
	public function setImagem($imagem) {
	    $this->imagem = $imagem;
	}
}
?>