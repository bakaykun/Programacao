using CsvHelper.Configuration.Attributes;

namespace ProjetoComCsvHelper.Model{
    public class Notas{
        [Index(0)]
        public string Disciplina { get; set; }
        [Index(1)]
        public int Nota {get; set;}

        [Index(2)]
        public int Faltas {get; set;}
    }
}