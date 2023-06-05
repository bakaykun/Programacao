namespace ExDez.Entities{
    class PeJuridica : TaxaImposto{
        public int NumeroFuncionarios { get; set; }

        public PeJuridica(string nome, double ganhosAnuais, int numeroFuncionarios)
            : base(nome,ganhosAnuais)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double PagarTaxa()
        {
            if(NumeroFuncionarios > 10)
            {
                return GanhosAnuais * 0.14;
            } else 
            {
                return GanhosAnuais * 0.16;
            }
        }
    }
}