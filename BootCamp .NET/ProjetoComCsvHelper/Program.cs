using System.Globalization;
using ProjetoComCsvHelper.Model;
using CsvHelper.Configuration;
using CsvHelper;

UsandoCsvComClasse();


static void UsandoCsvComClasse(){
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "Lista Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException($"o arquivo [- {path} ] não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Produto>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Produto: {registro.Nome}");
        Console.WriteLine($"Link: {registro.Link}");
        Console.WriteLine($"Quantidade: {registro.Quantidade}");
        Console.WriteLine($"Valor Unitário: {registro.ValorUnitario}");
        Console.WriteLine($"Valor Total: {registro.ValorTotal}");
        Console.WriteLine("-----------------------");

    }    
}

static void UsandoCsvComDynamic(){
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "life.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException("o arquivo não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Plano: {registro.Plans}");
        Console.WriteLine($"Data: {registro.Date}");
        Console.WriteLine(" ");

    }
}

