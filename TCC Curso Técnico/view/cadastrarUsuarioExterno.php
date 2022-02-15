<!DOCTYPE html>
<html>
    <?php include_once ("header.php") ?>    
    <body>
        <?php
        if (session_status() !== PHP_SESSION_ACTIVE){
            session_start();    
        }
        
        if (isset($_SESSION['usuario'])){
            $usuario = $_SESSION['usuario'];    
        }
        
        ?>        

        <div class="container centralizando bg-dark">
            <form action="?controller=UsuarioController&method=insert" method="post">    
                <div class="col-md-11 offset-md-3 ">
                    <hr><h3>Cadastro de usuario</hr>
                    <div class="form-group">
                        <div class="col-md-12">
                            <label for="nome" class="espaco-lb espaco-lb-name">Nome</label>
                            <input type="hidden" name="id">
                            <input type="hidden" name="tipo" value="U">
                            <input type="text" name="nome" class="form-control col-xs-2">
                        </div> 
                    </div>

                    <div class="form-group ">
                        <div class="col-md-12 espaco">
                            <label for="senha" class="espaco-lb espaco-lb-name">Senha</label>
                            <input type="password" name="senha" class="form-control col-xs-2">
                        </div>
                    </div>
         
                    <div class="form-group " id="espaco-dvi-btn-log">
                        <div class="col-md-7 offset-md-3">    
                            <a href="index.php" class="btn btn-info">Login</a>
                        </div>
                        <input type="submit" value="Cadastrar" class="btn btn-danger">
                    </div>
                </div>
            </form>

            
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
        </div>
    </body>
    <?php include_once("footer.php");?>
</html>