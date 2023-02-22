using static System.Console;

namespace ExTres
{
    class Program 
    {
        static void Main()
        {
            int y = 1;
            Write("How many roons will be rent? ");    
            int qtd = int.Parse(ReadLine());
            Tenant[] guest = new Tenant[10];

            for (int i = 0; i <= qtd; i++)
            {  
                Write("\n");
                WriteLine($"Rent number: #{y}");
                Write("Name: ");
                string name = ReadLine();
                Write("E-mail: ");
                string email = ReadLine();
                Write("Room: ");
                int room = int.Parse(ReadLine());
                guest[room] = new Tenant{Name=name, Email=email};
                y++;
                
            }
            Write("\n");    
            for (int i = 0; i < 10; i++)
            {
                if(guest[i] != null) {
                    Write(i + ": "+ guest[i] + "\n");
                }
            }

        }
    }
}
