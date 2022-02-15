<!DOCTYPE html>
<html>
<?php 
    if( session_status() !== PHP_SESSION_ACTIVE){
        session_start();    
    }
    if (isset($_SESSION['usuarioLogado'])==false) {
        header('Location: login.php');
    }
?>
    
<?php include_once ("header.php") ?>    
    <body>
        <?php include_once ("menu.php") ?>

        <hr><h3>Usuario - Listar</h3></hr>             
        <form action="?controller=UsuarioController&method=search" method="post">
            <table>
                <tr><td>
                    <label for="nome">Nome</label>
                    <input type="text" name="nome">
                </td>
                <td>
                    <input type="submit" value="Pesquisar">
                </td></tr>
            </table>
            <br />

            <table class="lista">
                <tr>
                    <td>Id</td>
                    <td>Nome</td>
                    <td></td>
                    <td></td>
                </tr>

                <?php

                if( session_status() !== PHP_SESSION_ACTIVE){
                    session_start();    
                }
                $usuarios = $_SESSION['usuarios'];
                if ($usuarios){
                    foreach ($usuarios as $usuario){
                    ?>
                    <tr>
                        <td> <?php echo $usuario->nome; ?> </td>
                        <td>
                            <a href="?controller=UsuarioController&method=view&id=<?php echo $usuario->id; ?>">
                                <img src="images/icons8-editar-26.png" alt="Editar" />
                            </a>
                        </td>
                        <td>
                            <a href="?controller=UsuarioController&method=delete&id=<?php echo $usuario->id; ?>">
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
