namespace Ex2
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = porcentagem / 100;
            SalarioBruto = SalarioBruto + (SalarioBruto *porcentagem);
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {SalarioLiquido()}";
        }
    }
}