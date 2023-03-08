using System;
using static System.Console;
using ExContratoTrabalho.Entities.Enums;
using ExContratoTrabalho.Entities;
using System.Globalization;

namespace ExContratoTrabalho 
{
    class Program
    {
        static void Main()
        {
            Write("Enter department's name: ");
            string dptName = ReadLine();
            WriteLine("Enter worker data:");
            Write("Name: ");
            string name = ReadLine();
            Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level =Enum.Parse<WorkerLevel>(ReadLine());
            Write("Base Salary: ");
            double baseSalary = double.Parse(ReadLine()); 
            
            Departament departament = new Departament(dptName);
            Worker wkOne = new Worker(name, level, baseSalary, departament);

            Write("How many contracts to this worker?: ");
            int numContracts = int.Parse(ReadLine());

            for(int i = 1; i < numContracts; i++){
                WriteLine($"Enter #{i} contract data: ");
                Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(ReadLine());
                double valuePerHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                int hour = int.Parse(ReadLine());
                HourContract contracts = new HourContract(date, valuePerHour, hour); 
                wkOne.addContract(contracts);
            }

            WriteLine(" ");

            Write("Enter month and year to calculate income (MM/YYYY): ");
            string monAndYear = ReadLine();
            int month = int.Parse(monAndYear.Substring(0,2));
            int year = int.Parse(monAndYear.Substring(3));

            WriteLine($"Name{wkOne.Name}\nDepartament{departament.Name}\nIncome for {monAndYear} : {wkOne.Income(month, year).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
