using static System.Console;
using System.Globalization;

namespace Ex2 
{
    class Program 
    {

    
    public void Ex01()
    {
        Retangulo ret;
        ret = new Retangulo();
        WriteLine("Insire a Altura e Largura do Retângulo: ");
        ret.Largura = double.Parse(ReadLine());
        ret.Altura = double.Parse(ReadLine());
        
        WriteLine($"AREA {ret.Area()}");       
        WriteLine($"PERÍMETRO {ret.Perimetro()}");       
        WriteLine($"DIAGONAL {ret.Diagonal()}");   
    }    

    public void Ex02()
    {
        Funcionario pessoa;
        pessoa = new Funcionario();
        WriteLine("Insira o nome: ");
        pessoa.Nome = ReadLine();  
        WriteLine("Insira o Salário bruto");
        pessoa.SalarioBruto = double.Parse(ReadLine());
        WriteLine("Insira o imposto");
        pessoa.Imposto = double.Parse(ReadLine()); 
        WriteLine(pessoa.ToString());  
        Write("Dgite o Tanto que via aumentar o slaário: ");
        double aumento = double.Parse(ReadLine()); 
        pessoa.AumentarSalario(aumento);   
        WriteLine(pessoa.ToString());

    }    

    public void Ex03()
    {
        Aluno al = new Aluno();

        Write("Nome do Aluno: ");
        al.Nome = ReadLine();

        WriteLine("Digite as Tres Notas Do Alunos: ");
        for (int i = 0; i < 3; i++)
        {
            al.Notas[i] = double.Parse(ReadLine(), CultureInfo.InstalledUICulture);
        }

        WriteLine(al);

        if (al.Nota() < 60){
            Write($"Reprovado\n Faltam: {60-al.Nota().ToString("F2")} pontos para alcançar a média");
        } else {
            WriteLine(" Aprovado !");
        }          
    }
        static void Main(string[] args)
        {

            Write("Qual a cotação do dólar? ");
            double valorDolar = double.Parse(ReadLine(), CultureInfo.InstalledUICulture);

            Write("Quantos dólares tu vai comprar? ");
            double qtdDolar = double.Parse(ReadLine(), CultureInfo.InstalledUICulture);

            Write($"Valora  ser pago em dólar: {ConversorMoeda.Conversor(valorDolar,qtdDolar).ToString("F2")}");
            


        }
    }
}