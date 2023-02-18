using static System.Console;

namespace QuintaAula
{
    class Program 
    {
        static void Main(string[] args)
        {
           Triangulo a, b;
           a = new Triangulo();
           b = new Triangulo();

           a.A = double.Parse(ReadLine());
           a.B = double.Parse(ReadLine());
           a.C = double.Parse(ReadLine());

           
           b.A = double.Parse(ReadLine());
           b.B = double.Parse(ReadLine());
           b.C = double.Parse(ReadLine());

           WriteLine($" a área de X é: {a.areaTriangulo(a.A, a.B, a.C)}");
           WriteLine($" a área de Y é: {b.areaTriangulo(b.A, b.B, b.C)}");



        }
    }
}
