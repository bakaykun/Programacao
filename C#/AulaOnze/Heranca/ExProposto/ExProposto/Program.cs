using static System.Console;
using static System.Globalization.CultureInfo;
using ExProposto.Entities;
using System.Collections.Generic;
namespace ExProposto 
{
    class Program 
    {
        static void Main()
        {
            List<Employee> listEmployee = new List<Employee>();

            Write("Coloque o número de trabalhadores: ");
            int n = int.Parse(ReadLine());

            for (int i = 1; i <= n; i++)
            {
                WriteLine("Trabalhador #" + i);
                Write("É tercerizado? (s/n) ");
                char op = char.Parse(ReadLine());
                Write("Nome: ");
                string name = ReadLine();
                Write("Horas trabalhadas: ");
                int hours = int.Parse(ReadLine());
                Write("Valor por hora: ");
                double valuePerHour = double.Parse(ReadLine(), InvariantCulture);

                if (op == 's')
                {
                    Write("Despesa Adicional: ");
                    double additionalCharge = double.Parse(ReadLine(), InvariantCulture);
                    listEmployee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } 
                else 
                {
                    listEmployee.Add(new Employee(name, hours, valuePerHour));
                }

                WriteLine("  - - - -  ");

            }

            WriteLine(" ");

            WriteLine("Pagamentos: ");
            foreach(Employee emp in listEmployee){
                WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", InvariantCulture)}");
            }
        }
    }
}