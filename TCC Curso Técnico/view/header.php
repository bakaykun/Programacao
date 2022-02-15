<?php
	require_once "../controller/Controller.php";
?>
<head>
	<title>..::LiveStore ONline - Páinel Adminstrativo::..</title>
	<link type="text/css" rel="stylesheet" href="../css/bootstrap.min.css"/>
	<link rel="icon" href="images/favicon.png" sizes="40x40" type="image/png">
	<!-- Google font -->
	<link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700" rel="stylesheet">

	<!-- Bootstrap -->
	<link type="text/css" rel="stylesheet" href="../css/bootstrap.min.css"/>

	<!-- Slick -->
	<link type="text/css" rel="stylesheet" href="../css/slick.css"/>
	<link type="text/css" rel="stylesheet" href="../css/slick-theme.css"/>

	<!-- nouislider -->
	<link type="text/css" rel="stylesheet" href="../css/nouislider.min.css"/>

	<!-- Font Awesome Icon -->
	<link rel="stylesheet" href="../css/font-awesome.min.css">

	<!-- Custom stlylesheet -->
	<link type="text/css" rel="stylesheet" href="../css/style.css"/>

	<!--Bulma-->
	<link rel="stylesheet" href="../css/bulma.min.css" />

	<!--Concerto-->
	<link rel="stylesheet" type="text/css" href="css/centralizando.css">
<head>

<?php
	if (session_status() !== PHP_SESSION_ACTIVE){
	session_start();           
	}?>

<header>
<!-- TOP HEADER -->
	<div id="top-header">
		<div class="container">
			<ul class="header-links pull-right">
				<li><a href="menuAdm.php"><i class="fa fa-user-o"></i> 
					<?php
						if(isset($_SESSION['usuarioLogado'])){
							$usuarioLogado = $_SESSION['usuarioLogado'];
							echo ('Olá, '.$usuarioLogado->nome);
						}
					?>
				</a></li>

				<li><a href="?controller=UsuarioController&method=sair"><i class="fa fa-user-o"></i> 
					Sair
				</a></li>
			</ul>
		</div>
	</div>
	<!-- /TOP HEADER -->

	<!-- MAIN HEADER -->
	<div id="header">
	<!-- container -->
		<div class="container">
		<!-- row -->
			<div class="row">
				<!-- LOGO -->
				<div class="col-md-3">
					<div class="header-logo">
						<a href="#" class="logo">
							<img src="images/logo.png" alt="">
						</a>
					</div>
				</div>
				<!-- /LOGO -->

				<!-- SEARCH BAR -->
				<div class="col-md-6">
					<div class="header-search">
						<form>
							<select class="input-select">
								<option value="0">Categorias</option>
								<option value="1">Categoria 01</option>
								<option value="1">Categorias02</option>
							</select>
							<input class="input" placeholder="Search here">
							<button class="search-btn">Procurar</button>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
</header>