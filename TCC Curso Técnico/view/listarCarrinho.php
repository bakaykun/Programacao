<!DOCTYPE html>
<html>
<?php include_once ("header.php") ?>    
    <body>
        <?php include_once ("menuUsuario.php") ?>

        <hr><h3>Carrinho de Compras - Listar</h3></hr>             
        <form action="?controller=VendaController&method=insert" method="post">
            <br />

            <table class="lista">
                <tr>
                    <td>Produto</td>
                    <td>Descrição</td>
                    <td>Quantidade</td>
                    <td>Valor Unitário</td>
                    <td></td>
                </tr>

                <?php

                if (session_status() !== PHP_SESSION_ACTIVE){
                    session_start();    
                }
                if (isset($_SESSION['carrinho'])){
                    $carrinho = $_SESSION['carrinho'];
                    if ($carrinho){
                        foreach ($carrinho as $item){                        
                        ?>
                        <tr>
                            <td> <img src=<?php echo $item->getProduto()->imagem; ?>> </td>
                            <td> <?php echo $item->getProduto()->descricao; ?> </td>
                            <td> <?php echo $item->getQuantidade(); ?></td>
                            <td> <?php echo $item->getValorUnitario(); ?> </td>
                            <td>
                                <a href="?controller=VendaController&method=deleteCarrinhoCompra&id=<?php echo $item->getProduto()->id; ?>">
                                    <img src="images/icons8-excluir-26.png" alt="Deletar" />
                                </a>
                            </td>
                        </tr>
                        <?php } ?>
                    <?php } ?>
                    <tr>
                        <td colspan="5" align="right">
                            <b> Valor Total </b>: <?php echo isset($_SESSION['valorTotal']) ? $_SESSION['valorTotal'] : null; ?>
                        </td>
                    </tr>
                <?php } ?>
            </table>
            <br><br>
            <input type="submit" value="Finalizar Compra">
        </form>
        <?php 
            include_once("footer.php");
        ?>
    </body>
</html>
