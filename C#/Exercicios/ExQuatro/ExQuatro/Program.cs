using System.Collections.Generic;
using static System.Console;

namespace ExQuatro {

    class Program {

        static void Main(){

            List<Employee> empoloyes = new List<Employee>();

            Write("How many employees be registred? ");
            int numEmp = int.Parse(ReadLine());

            for (int i = 1; i <= numEmp; i++) {

                Write("Name: ");
                string name = ReadLine();
                Write("Id: ");
                int id = int.Parse(ReadLine());
                Write("Salary: ");
                double salary = double.Parse(ReadLine());
                empoloyes.Add(new Employee(name, salary, id));

                Write("\n");

            }

            WriteLine("The employee id the will have slary incrase: ");
            int idFi = int.Parse(ReadLine());

            Employee emp = empoloyes.Find(x => x.Id == idFi);
            if (emp != null) {

                Write("Enter the porcentage");
                double porcentage = double.Parse(ReadLine());
                emp.incraseSalary(porcentage);

            } else {
                WriteLine("This id does not Exist !");
            }

            WriteLine("Update List employees: ");
            foreach(Employee cad in  empoloyes){
                WriteLine (cad + "\n");
            }


        }
    }
}
