<?php	
	require_once '../model/Usuario.php';
	require_once '../dao/UsuarioDao.php';

	class UsuarioController{
		protected $table="usuario";

		public function delete(){
			try{
				$id = $_GET['id'];
				$usuarioDao = new UsuarioDao();
				$usuarioDao->delete($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function efetuarLogin(){
			try{
				$nome = $_POST['nome'];
				$senha = md5($_POST['senha']);

				$usuarioDao = new UsuarioDao();
				$usuarioLogado = $usuarioDao->efetuarLogin($nome, $senha);

		        if (session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }

				if (empty($usuarioLogado)){
					$_SESSION['mensagem'] = "Usuario ou senha inválidos";
				} else {
					$_SESSION['usuarioLogado'] = $usuarioLogado;
				}
				header('Location: index.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
        }

		public function find(){
			try{
				$id = $_POST['id'];
				$usuarioDao = new UsuarioDao();
				$usuarioDao->find($id);
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function findAll(){
			try{
				$usuarioDao = new UsuarioDao();
				$usuarios = $usuarioDao->findAll();

		        if( session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }

		        $_SESSION['usuarios'] = $usuarios;
				header('Location: listarUsuario.php');
			} catch(PDOException $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function insert(){
			try{
				$usuario = new Usuario();
				$usuario->setNome($_POST['nome']);
				$senha = md5($_POST['senha']);
				$usuario->setSenha($senha);
				$usuario->setTipo($_POST['tipo']);

				$usuarioDao = new UsuarioDao();
				$usuarioDao->insert($usuario);
				$_SESSION['mensagem'] = "Usuario cadastrado com sucesso.";
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function new(){
			try{
				if ($_SESSION['usuario']){
					unset($_SESSION['usuario']);
				}
				header('Location: cadastrarUsuario.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function newExterno(){
			try{
				if ($_SESSION['usuario']){
					unset($_SESSION['usuario']);
				}
				header('Location: cadastrarUsuarioExterno.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

        public function sair(){
			try{
		        if( session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }
				unset($_SESSION['usuarioLogado']);
				unset($_SESSION['valorTotal']);
				unset($_SESSION['carrinho']);
				session_destroy();
				header('Location: index.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
        }

        public function search(){
            $nome = $_POST['nome'];
        	$usuarioDao = new UsuarioDao();
			$usuarios = $usuarioDao->search($nome);

			try{
		        if( session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }

				$_SESSION['usuarios'] = $usuarios;
				header('Location: listarUsuario.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
        }

		public function update(){
			try{
				$usuario = new Usuario();
				$usuario->setNome($_POST['nome']);
				$usuario->setId($_POST['id']);

				$usuarioDao = new UsuarioDao();
				$usuarioDao->update($usuario);
				$_SESSION['mensagem'] = "Usuario alterado com sucesso.";
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}

		public function view(){
			try{
				$id = $_GET['id'];
				$usuarioDao = new UsuarioDao();
				$usuario = $usuarioDao->find($id);

		        if(session_status() !== PHP_SESSION_ACTIVE){
		            session_start();    
		        }	

		        $_SESSION['usuario'] = $usuario;
				header('Location: cadastrarUsuario.php');
			} catch(Exception $e) {
				echo "Ocorreu o seguinte erro: ".$e->getMessage();
			}
		}
	}
?>