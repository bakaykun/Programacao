<?php
	require_once '../controller/ItemVendaController.php';
	require_once '../controller/ProdutoController.php';	
	require_once '../model/Venda.php';
	require_once '../model/ItemVenda.php';
	require_once '../dao/VendaDao.php';
	require_once '../dao/ItemVendaDao.php';

	class VendaController{
		protected $table="venda";

		public function addCarrinhoCompra(){
			$id = $_GET['id'];

	        if (session_status() !== PHP_SESSION_ACTIVE){
	            session_start();    
	        }
			if(!isset($_SESSION['carrinho'])){ 
				$_SESSION['carrinho'] = array(); 
			}
            if(!isset($_SESSION['carrinho'][$id])){ 
                $produtoController = new ProdutoController();
				$produto = $produtoController->find();

				echo($produto->descricao);

				$itemVenda = new ItemVenda();
				$itemVenda->setProduto($produto);
				$itemVenda->setQuantidade(1);
				$itemVenda->setValorUnitario($produto->valor);

				$_SESSION['carrinho'][$id] = $itemVenda;
				$_SESSION['valorTotal'] =  $_SESSION['valorTotal'] + $produto->valor*1;
            } else { 
                $_SESSION['carrinho'][$id]->setQuantidade($_SESSION['carrinho'][$id]->getQuantidade()+1);
                $_SESSION['valorTotal'] = $_SESSION['valorTotal'] + $_SESSION['carrinho'][$id]->getValorUnitario()*1;
            }
			header('Location: listarCarrinho.php');
		}

		public function deleteCarrinhoCompra(){
			$id = $_GET['id'];
	        if (session_status() !== PHP_SESSION_ACTIVE){
	            session_start();    
	        }
			if (isset($_SESSION['carrinho'][$id])) {
				$_SESSION['valorTotal'] = $_SESSION['valorTotal'] - 
				$_SESSION['carrinho'][$id]->getQuantidade() * $_SESSION['carrinho'][$id]->getValorUnitario()
				;
				unset($_SESSION['carrinho'][$id]);
			}
		}

		public function findCarrinhoCompra(){
	        if (session_status() !== PHP_SESSION_ACTIVE){
	            session_start();    
	        }
			header('Location: listarCarrinho.php');
		}

		public function delete(){
			try{
				$id = $_GET['id'];
				$vendaDao = new VendaDao();
				$vendaDao->delete($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function find(){
			try{
				$id = $_POST['id'];
				$vendaDao = new VendaDao();
				$vendaDao->find($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function findAll(){
			try{
				$vendaDao = new VendaDao();
				$vendas = $VendaDao->findAll();
		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
		        $_SESSION['vendas'] = $vendas;
				header('Location: listarVenda.php');
			} catch(PDOException $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function insert(){
			try{
				$venda = new Venda();
				if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
				$venda->setCliente($_SESSION['usuarioLogado']);
				$venda->setDataVenda(date('Y/m/d h:i:s'));
				$venda->setValorTotal($_SESSION['valorTotal']);

				$vendaDao = new VendaDao();
				$vendaDao->insert($venda);
				$id = $vendaDao->findMaxId();
				$venda->setId($id);

				$carrinho = $_SESSION['carrinho'];
				if ($carrinho){
					foreach ($carrinho as $item){
						$item->setVenda($venda);
						$itemVendaDao = new ItemVendaDao();
						$itemVendaDao->insert($item);                		
                    }
                }
                unset($_SESSION['valorTotal']);
				unset($_SESSION['carrinho']);
                $_SESSION['mensagem'] = "Venda cadastrada com sucesso";
                header('Location: listarProdutoExterno.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function new(){
			try{
				if (session_status() !== PHP_SESSION_ACTIVE){
	            session_start();
	            }   
				unset($_SESSION['carrinho']);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

        public function search(){
            $descricao = $_POST['descricao'];
        	$vendaDao = new VendaDao();
			$vendas = $vendaDao->search($descricao);

			try{
		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
				$_SESSION['vendas'] = $vendas;
				header('Location: listarVenda.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
        }

		public function update(){
			try{
				$venda = new Venda();
				$venda->setDescricao($_POST['descricao']);
				$venda->setValor($_POST['valor']);

				$vendaDao = new VendaDao();
				$vendaDao->update($venda);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function view(){
			try{
				$id = $_GET['id'];
				$vendaDao = new VendaDao();
				$venda = $vendaDao->find($id);
		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
		        $_SESSION['venda'] = $venda;
				header('Location: cadastrarVenda.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}
	}
?>