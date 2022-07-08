using ExemploEncapsulamento.models;

Retangulo r1 = new Retangulo();

r1.definirMedidas(30.1, 2.8);

var mostrar = r1.obterArea();

if (mostrar != 0){
    Console.WriteLine(mostrar);
}