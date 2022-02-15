<!DOCTYPE html>
<html>
	<?php 
		if( session_status() !== PHP_SESSION_ACTIVE){
			session_start();    
		}
		if (isset($_SESSION['usuarioLogado']) == false) {
			header('Location: login.php');
		} else {
			if ($_SESSION['usuarioLogado']->tipo == "A") {
				header('Location: indexAdm.php');
			} else {
				header('Location: indexUsuario.php');
			}
		}
	?>
    <body>
    </body>
</html>
