<!DOCTYPE html>
<html>
    <?php include_once ("header.php") ?>    
    <body>
        <hr><h3>Acessar o sistema</h3></hr>
        <form action="?controller=UsuarioController&method=efetuarLogin" method="post">            
            <table class="lista">
                <tr><td>
                    <label for="nome">Nome</label>
                </td><td>
                    <input type="text" name="nome">
                </td></tr>
                <tr><td>
                    <label for="senha">Senha</label>
                </td><td>
                    <input type="password" name="senha">
                    <br>
                </td></tr>
            </table>
            <br>
 
            <?php
                if (isset($_SESSION['mensagem'])){
                    $mensagem = $_SESSION['mensagem'];
                    echo($mensagem);    
                    unset($_SESSION['mensagem']);
            ?>
                <br><br>
            <?php
                }            
            ?>

            <input type="submit" value="Acessar">
        </form>
        <br>
        <a href="?controller=UsuarioController&method=newExterno">Novo usuario</a>
    </body>
</html>
