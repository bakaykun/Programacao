<?php 
	include_once("header.php");
?>
<style>
	.concerto a {
	color: inherit;
}
</style>
<nav id="navigation">
	<!-- container -->
	<div class="container">
		<!-- responsive-nav -->
		<div id="responsive-nav">
			<!-- NAV -->
			<ul class="main-nav nav navbar-nav concerto concerto">
				<li><a href="?controller=ProdutoController&method=findAllExterno">Listar Produto</a></li>
				<li><a href="?controller=VendaController&method=findCarrinhoCompra">Carrinho de Compras</a></li>
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