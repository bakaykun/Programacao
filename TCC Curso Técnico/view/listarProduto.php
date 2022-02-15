<!DOCTYPE html>
<html>
<?php include_once ("header.php") ?>    
    <body>
        <?php include_once ("menu.php") ?>

        <hr><h3>Produto - Listar</h3></hr>             
        <form action="?controller=ProdutoController&method=search" method="post">
            <table>
                <tr><td>
                    <label for="descricao">Nome</label>
                    <input type="text" name="descricao">
                </td>
                <td>
                    <input type="submit" value="Pesquisar">
                </td></tr>
            </table>
            <br />

            <table class="lista">
                <tr>
                    <td>Id</td>
                    <td>Descrição</td>
                    <td>Valor</td>
                    <td></td>
                    <td></td>
                </tr>

                <?php

                if( session_status() !== PHP_SESSION_ACTIVE){
                    session_start();    
                }
                $produtos = $_SESSION['produtos'];
                if ($produtos){
                    foreach ($produtos as $produto){
                    ?>
                    <tr>
                        <td> <?php echo $produto->id; ?> </td>
                        <td> <?php echo $produto->descricao; ?> </td>
                        <td> <?php echo $produto->valor; ?> </td>
                        <td>
                            <a href="?controller=ProdutoController&method=view&id=<?php echo $produto->id; ?>">
                                <img src="images/icons8-editar-26.png" alt="Editar" />
                            </a>
                        </td>
                        <td>
                            <a href="?controller=ProdutoController&method=delete&id=<?php echo $produto->id; ?>">
                                <img src="images/icons8-excluir-26.png" alt="Deletar" />
                            </a>
                        </td>
                    </tr>
                    <?php } ?>
                <?php } ?>
            </table>                
        </form>
        <?php 
            include_once("footer.php");
        ?>
    </body>
</html>
