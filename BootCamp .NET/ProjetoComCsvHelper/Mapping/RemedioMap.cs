using System.Globalization;
using CsvHelper.Configuration;
using ProjetoComCsvHelper.Model;

namespace ProjetoComCsvHelper.Mapping{
    public class RemedioMap : ClassMap<Remedio>{
        public RemedioMap(){
            Map(x => x.NumDcb).Name("DCB");
            Map(x => x.NomeComum).Name("DENOMINAÇÃO COMUM BRASILEIRA");
            Map(x => x.NumCas).Name("CAS");
        }
    }
}