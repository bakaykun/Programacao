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
<?php include ("header.php") ?>    
    <body>
        <?php include ("menu.php") ?>

        <hr><h3>Cadastro de usuario</h3></hr>

        <?php
        if (session_status() !== PHP_SESSION_ACTIVE){
            session_start();    
        }
        
        if (isset($_SESSION['usuario'])){
            $usuario = $_SESSION['usuario'];    
        }
        
        ?>        
        <form action="?controller=UsuarioController&<?php 
            echo isset($usuario->id)?"method=update&id={$usuario->id}":"method=insert"; ?>" method="post">            
            <table class="lista">
                <tr><td>
                    <label for="nome">Nome</label>
                </td><td>
                    <input type="hidden" name="id" value="<?php echo isset($usuario->id) ? $usuario->id : null; ?>">
                    <input type="text" name="nome" value="<?php echo isset($usuario->nome) ? $usuario->nome : null; ?>">
                </td></tr>
                <tr><td>
                    <label for="tipo">Tipo de usuário</label>
                </td><td>
                    <select name="tipo">
                        <option value="A">Administrador</option>
                        <option value="U" selected>Usuário</option>
                    </select>
                    <br>
                </td></tr>
                <tr><td>
                    <label for="senha">Senha</label>
                </td><td>
                    <input type="password" name="senha">
                    <br>
                </td></tr>
            </table>
            <br />
            <input type="submit" value="Cadastrar">
        </form>
        <br><br>
        <?php
        if (isset($_SESSION['mensagem'])){
            $mensagem = $_SESSION['mensagem'];
            unset($_SESSION['mensagem']);
            echo($mensagem);    
        }
        ?> 
        <?php 
           include_once("footer.php");
        ?>
    </body>
</html>
