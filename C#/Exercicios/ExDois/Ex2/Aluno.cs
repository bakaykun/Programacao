namespace Ex2
{
    public class Aluno
    {
        public string Nome;
        public double[] Notas = {0,0,0}; 

        public double Nota()
        {
            return Notas[0]+Notas[1]+Notas[2];
        }

        public override string ToString()
        {
            return $"Nota Final {Nota().ToString("F2")}";
        }
    }
}