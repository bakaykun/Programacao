namespace ExDez.Entities{
    class PeFisica : TaxaImposto{
        public double GastosSaude { get; set; }

        public PeFisica (string nome, double ganhosAnuais, double gastosSaude)
            : base(nome,ganhosAnuais)
        {
            GastosSaude = gastosSaude;
        }

        public override double PagarTaxa()
        {
            if(GastosSaude > 0)
            {
                if(GanhosAnuais > 20000.00)
                {
                    return (GanhosAnuais * 0.25) - (GastosSaude * 0.5);
                } else 
                {
                    return (GanhosAnuais * 0.15) - (GastosSaude * 0.5);
                }
            } else {
                if(GanhosAnuais > 20000.00)
                {
                    return (GanhosAnuais * 0.25);
                } else 
                {
                    return (GanhosAnuais * 0.15);
                }               
            }
        }
    }


}