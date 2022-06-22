namespace Delegates.models
{
    public class Calculadora
    {
        public static void Somar(int x, int y){
            System.Console.WriteLine($"Adição: {x +y}");

        }

        public static void Subtrair(int x, int y){
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}