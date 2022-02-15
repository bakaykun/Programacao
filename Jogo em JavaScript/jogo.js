var altura = 0
var largura = 0
var vida = 1
var tempo = 15

var tempoMosquito = 1500

//incio da logica de seleção do nível 
var nivel = window.location.search
nivel = nivel.replace("?", '')//tirando o ponto de interrogação e colocando o espaço


if(nivel === "normal"){
    tempoMosquito = 1500
    
} else if(nivel === "foda") {
   
    tempoMosquito = 1000

} else if( nivel === "complicado") {

    tempoMosquito = 750
}



function responsivo(){
    altura = window.innerHeight
    largura = window.innerWidth
}    

responsivo()




//criando e iserindo oc rconometro no html
var cronometro = setInterval( function(){
    tempo -=1

    if (tempo < 0 ){
        clearInterval(cronometro)
        clearInterval(criaMosca)
        window.location.href = "vitoria.html"
    } else {
        document.getElementById("cronometro").innerHTML = tempo 

    }
},1000)



//criando as posições randomicas
function posicaoMosquito() {


    ///remover o mosquito anterior caso exista
    if(document.getElementById("mosquito")){
        document.getElementById("mosquito").remove()

        if ( vida > 3 ) {

            window.location.href = "im_de_jogo.html"
        } else {
            console.log(document.getElementById("v" + vida).src = 'imagens/coracao_vazio.png')
            vida++
        }

    }

    var posicaox = Math.floor(Math.random() * largura) - 100
    var posicaoy = Math.floor(Math.random() * altura) - 100

    posicaox = posicaox < 0 ? 0 : posicaox
    posicaoy = posicaoy < 0 ? 0 : posicaoy

    //criar o elemento html
    var mosquito = document.createElement("img")
    mosquito.src = "imagens/mosca.png"
    mosquito.className = tamanhoAleatorio() + " " + aleatorioLado()
    mosquito.style.left = posicaox + "px"
    mosquito.style.top = posicaoy + "px"
    mosquito.style.left = posicaox + "px"
    mosquito.style.position = 'absolute'
    mosquito.id = "mosquito"
    mosquito.onclick = function () {
        this.remove()
    }


    document.body.appendChild(mosquito)
    
    aleatorioLado()
}

//criando os tamanos aleatórios do elelmentos

function tamanhoAleatorio() {
    var classe = Math.floor(Math.random() * 3)
    console.log (classe)

    switch (classe) {
        case 0:
            return "mosquito1"

        case 1:
            return "mosquito2"

        case 2:
            return "mosquito3"

    }

}

//criando oslados do elemento
function aleatorioLado(){
    var classe = Math.floor(Math.random() * 2)
    console.log (classe)

    switch (classe) {
        case 0:
            return "ladoA"

        case 1:
            return "ladoB"

    }
}

//