<?php	
	require_once '../model/Venda.php';
	require_once '../dao/VendaDao.php';

	class ItemVendaController{
		protected $table="venda";

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
				$venda->setDescricao($_POST['descricao']);
				$venda->setValor($_POST['valor']);

				$vendaDao = new VendaDao();
				$vendaDao->insert($venda);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function new(){
			try{
				if ($_SESSION['venda']){
					unset($_SESSION['venda']);
				}
				header('Location: cadastrarVenda.php');
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