namespace Delegates.models
{
    public class Calculadora
    {
        //para declarar um evento, tem que declarar o delegate
        public delegate void DelegateCualculadora();

        public static event DelegateCualculadora EventoCalculadora;

        public static void Somar(int x, int y){
            if( EventoCalculadora != null){
                System.Console.WriteLine($"Adição: {x +y}");
                EventoCalculadora();
            } else {
                System.Console.WriteLine("Nenhum inscrito !");
            }

        }
        public static void Subtrair(int x, int y){
            System.Console.WriteLine($"Subtração: {x - y}");
        }

    }
}