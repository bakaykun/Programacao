namespace ExDez.Entities{
    abstract class TaxaImposto{
        public string Nome { get; set; }
        public double GanhosAnuais { get; set; }

        public TaxaImposto(string nome, double ganhosAnuais){
            Nome = nome;
            GanhosAnuais = ganhosAnuais;
        }

        public abstract double PagarTaxa();

        public override string ToString()
        {
            return Nome + ": " + PagarTaxa();
        }

    }
}