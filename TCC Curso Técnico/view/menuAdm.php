<?php 
	include_once("header.php");
?>
<nav id="navigation ">
	<!-- container -->
	<div class="container espaco-margin-bootom">
		<!-- responsive-nav -->
		<div id="responsive-nav">
			<!-- NAV -->
			<ul class="main-nav nav navbar-nav concerto concerto">
				<li><a href="?controller=ProdutoController&method=new">Cadastrar Produto</a></li>
				<li><a href="?controller=ProdutoController&method=findAll">Listar Produto</a></li>
				<li><a href="?controller=UsuarioController&method=new">Cadastrar Usuario</a></li>
				<li><a href="?controller=UsuarioController&method=findAll">Listar Usuario</a></li>
			</ul>
			<!-- /NAV -->
		</div>
		<!-- /responsive-nav -->
	</div>
<!-- /container -->
</nav>
<?php 
	include_once("footer.php");
?>