using static System.Console;
using DesafioData.models;

WriteLine("Digite uma data usando o [/] para separar");
string dataRecebida = ReadLine();

Data data1 = new Data(dataRecebida);

data1.ApresentarData();
WriteLine("\n");

data1.SepararData(dataRecebida);