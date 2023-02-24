namespace ExQuatro
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }

        public Employee (string name, double alary, int id){
            Name = name;
            Salary = alary;
            Id = id;
        }

        public void incraseSalary(double porcentage){
            Salary += Salary * porcentage / 100;
        }

        public override string ToString() {
            return System.Console.WriteLine (Name +
                " : " + Id + " : " + Salary.ToString("f2")
            );
        }


    }
}