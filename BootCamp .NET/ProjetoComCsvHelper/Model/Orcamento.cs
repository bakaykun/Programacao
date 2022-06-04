using CsvHelper.Configuration.Attributes;

namespace ProjetoComCsvHelper.Model{
    
    public class Orcamento{
        [Name("PRODUTO")]
        public string Nome { get; set; }
        [Name("VALOR")]
        [CultureInfo("pt-BR")]
        public int Valor {get; set;}
        [Name("data")]
        [Format("dd/MM/yyyy")]
        public DateOnly DataOrcamento { get; set; }
    }
}