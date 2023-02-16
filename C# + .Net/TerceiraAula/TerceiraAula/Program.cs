using System.Globalization;
using static System.Console;

string produto1 = "Computador";
string produto2 = "Mesa de Escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco01 = 2100.00;
double preco2 = 650.50;
double medida = 53.234567;

WriteLine("Produtos");
WriteLine($"{produto1}, cujo o valor é R${preco01:F2}");
WriteLine($"{produto02}, cujo o preço é R$ {preco02:F2}");

WriteLine($"Registro: /n {idade} anos de idade, código é {codigo} e gênero {genero}");

