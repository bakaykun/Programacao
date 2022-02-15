<!DOCTYPE html>
<html>
    <?php include_once ("header.php") ?>    
    <body>
        <div class="container centralizando bg-dark">
            <form action="?controller=UsuarioController&method=efetuarLogin" method="post">    
                <div class="col-md-11 offset-md-3 ">
                    <hr><h3>LOGIN</hr>
                    <div class="form-group">
                        <div class="col-md-12">
                            <label for="nome" class="espaco-lb espaco-lb-name">Nome</label>
                            <input type="text" name="nome" class="form-control col-xs-2">
                        </div>
                    </div>

                    <div class="form-group ">
                        <div class="col-md-12 espaco">
                            <label for="senha" class="espaco-lb espaco-lb-name">Senha</label>
                            <input type="password" name="senha" class="form-control col-xs-2">
                        </div>
                    </div>
                    
         
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
                    <div class="form-group " id="espaco-dvi-btn-log">
                        <div class="col-md-7 offset-md-3">    
                            <a href="?controller=UsuarioController&method=newExterno" class="btn btn-info">Novo usuario</a>
                        </div>
                        <input type="submit" value="Acessar" class="btn btn-danger">
                    </div>
                </div>
            </form>
        </div>
    </body>
    <?php include_once("footer.php");?>
</html>
