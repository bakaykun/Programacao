<?php	
	require_once '../model/Produto.php';
	require_once '../dao/ProdutoDao.php';

	class ProdutoController{
		protected $table="produto";

		public function delete(){
			try{
				$id = $_GET['id'];
				$produtoDao = new ProdutoDao();
				$produtoDao->delete($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function find(){
			try{
				$id = $_GET['id'];
				$produtoDao = new ProdutoDao();
				return $produtoDao->find($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function findAll(){
			try{
				$produtoDao = new ProdutoDao();
				$produtos = $produtoDao->findAll();

		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }

		        $_SESSION['produtos'] = $produtos;
				header('Location: listarProduto.php');
			} catch(PDOException $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function findAllExterno(){
			try{
				$produtoDao = new ProdutoDao();
				$produtos = $produtoDao->findAll();

		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
		        $_SESSION['produtos'] = $produtos;
				header('Location: listarProdutoExterno.php');
			} catch(PDOException $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function insert(){
			try{
				$imagem_origem = $_FILES['imagem']['name'];
				$raiz = getcwd();
				$imagem_destino = $raiz.'\images\\'.$imagem_origem; 
				$produto = new Produto();
				$produto->setDescricao($_POST['descricao']);
				$produto->setValor($_POST['valor']);
				$produto->setImagem('images/'.$imagem_origem);

				if (copy($_FILES['imagem']['tmp_name'], $imagem_destino))
				{
					$produtoDao = new ProdutoDao();
					$produtoDao->insert($produto);
				    if (session_status() !== PHP_SESSION_ACTIVE){
				        session_start();    
				    }
				    $_SESSION['mensagem'] = "Produto cadastrado com sucesso";
					//echo "Arquivo copiado com Sucesso.";
				} else {
					echo "Erro ao gravar imagem.";
				}
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function new(){
			try{
				if ($_SESSION['produto']){
					unset($_SESSION['produto']);
				}
				header('Location: cadastrarProduto.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

        public function search(){
            $descricao = $_POST['descricao'];
        	$produtoDao = new ProdutoDao();
			$produtos = $produtoDao->search($descricao);

			try{
		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
				$_SESSION['produtos'] = $produtos;
				header('Location: listarProduto.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
        }

		public function update(){
			try{
				$imagem_origem = $_FILES['imagem']['name'];
				$raiz = getcwd();
				$imagem_destino = $raiz.'\images\\'.$imagem_origem; 
				$produto = new Produto();
				$produto->setId($_POST['id']);
				$produto->setDescricao($_POST['descricao']);
				$produto->setValor($_POST['valor']);
				$produto->setImagem('images/'.$imagem_origem);

				if (copy($_FILES['imagem']['tmp_name'], $imagem_destino))
				{
					$produtoDao = new ProdutoDao();
					$produtoDao->update($produto);
				    if (session_status() !== PHP_SESSION_ACTIVE){
				        session_start();    
				    }
				    $_SESSION['mensagem'] = "Produto alterado com sucesso";
					//echo "Arquivo copiado com Sucesso.";
				} else {
					echo "Erro ao gravar imagem.";
				}
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function view(){
			try{
				$id = $_GET['id'];
				$produtoDao = new ProdutoDao();
				$produto = $produtoDao->find($id);
		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
		        $_SESSION['produto'] = $produto;
				header('Location: cadastrarProduto.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}
	}
?>