using GetSet.model;

internal class Program
{
    private static void Main(string[] args)
    {
        Data data = new Data();

        Console.WriteLine("Ditete um dia");
        data.Dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ditete um mes");
        data.Mes = int.Parse(Console.ReadLine());
        Console.WriteLine("Ditete um ano");
        data.Ano = int.Parse(Console.ReadLine());

        data.MostrarData();
    }
}