using static System.Console;

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
        static void Main(string[] args)
        {

            

        }
    }
}