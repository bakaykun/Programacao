<!DOCTYPE html>
<html>
<?php include ("header.php") ?>    
    <body>
        <?php include ("menu.php") ?>

        <hr><h3>Cadastro de produto</h3></hr>

        <?php
        if (session_status() !== PHP_SESSION_ACTIVE){
            session_start();    
        }
        
        if (isset($_SESSION['produto'])){
            $produto = $_SESSION['produto'];    
        }
        
        ?>        
        <form action="?controller=ProdutoController&<?php 
            echo isset($produto->id)?"method=update&id={$produto->id}":"method=insert"; ?>" method="post" enctype="multipart/form-data">           
            <table class="lista">
                <tr><td>
                    <label for="imagem">Imagem</label>
                </td><td>
                    <input type="file" name="imagem"/>
                </td></tr>
                <tr><td>
                    <label for="descricao">Descrição</label>
                </td><td>
                    <input type="hidden" name="id" value="<?php echo isset($produto->id) ? $produto->id : null; ?>">
                    <input type="text" name="descricao" value="<?php echo isset($produto->descricao) ? $produto->descricao : null; ?>">
                </td></tr>
                <tr><td>
                    <label for="valor">Valor</label>
                </td><td>
                    <input type="number" name="valor" value="<?php echo isset($produto->valor) ? $produto->valor : null; ?>">
                    <br>
                </td></tr>
            </table>
            <br>
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
