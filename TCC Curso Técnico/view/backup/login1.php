<!DOCTYPE html>
<html>
    <?php include_once ("header.php") ?>    
    <body>
        <div class="section"> 
            <div class="container">
                <div class="row">
                    <div class="form-group">
                        <hr><h3>Acessar o sistema</h3></hr>
                        <form action="?controller=UsuarioController&method=efetuarLogin" method="post">            
                            <div class="form-group">
                                <div class="col-md-6 offset-md-3">
                                    <label for="nome">Nome: </label>
                                    <input type="text" name="nome" class="form-control col-xs-3">
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6 offset-md-3">
                                    <label for="senha">Senha: </label>
                                    <input type="password" name="senha" class="form-control col-xs-3">  
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
                            <div class="form-group">
                                <input class="btn btn-danger" type="submit" value="Acessar">
                                <a href="?controller=UsuarioController&method=newExterno" class="btn btn-info">Novo usuario</a>   
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>
