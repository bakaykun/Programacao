<?php
	require_once 'ProdutoController.php';
	require_once 'UsuarioController.php';
	require_once 'VendaController.php';

	if ($_GET) {
		$controller=isset($_GET["controller"])? 
			((class_exists($_GET["controller"]))?new $_GET["controller"]:NULL):null;
			$method=isset($_GET["method"])?$_GET["method"]:null;
		
		if ($controller && $method){
			if (method_exists($controller, $method)){
				$parameters = $_GET;
				unset($parameters["controller"]);
				unset($parameters["method"]);
				call_user_func(array($controller, $method), $parameters);
			} else {
				echo "Método não encontrado";
			}
		} else {
			echo "Método + $method +  não encontrado";
		}
	}
?>
