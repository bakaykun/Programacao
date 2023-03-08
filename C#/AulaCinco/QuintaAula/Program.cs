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

           double areaA = a.AreaTriangulo(a.A, a.B, a.C);
           double areaB = b.AreaTriangulo(b.A, b.B, b.C);

           WriteLine($" a área de X é: {areaA}");
           WriteLine($" a área de Y é: {areaB}");
            if (areaA > areaB)
                WriteLine($"A área {areaA} é maior");
            else 
                WriteLine($"A área {areaB} é maior");


        }
    }
}
