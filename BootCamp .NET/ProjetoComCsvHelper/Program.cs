using System.Globalization;
using ProjetoComCsvHelper.Model;
using ProjetoComCsvHelper.Mapping;
using CsvHelper.Configuration;
using CsvHelper;

EscreverCsv();
//LerUsandoOMappingEtirandoLogicaDaClasse();
//LerCsvSemCabecalho();
//LerHeaderDeCsvDiferenteDaClasse();
//LerCsvComOutroDelimitador();
//UsandoCsvComClasse();

static void EscreverCsv(){
    //criando diretorio
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");
    var di = new DirectoryInfo(path);
    //vendo se existe
    if (!di.Exists)
        di.Create();

    //mandando um arquivo para a pasta
    path = Path.Combine(path, "usuario.csv");

    var pessoas = new List<Pessoa>(){
        new Pessoa(){
            Nome = "KElvin",
            Telefone = 989850,
        }
    };

    using var sr = new StreamWriter(path);
    using var csvWriter = new CsvWriter(sr, CultureInfo.InvariantCulture);
    csvWriter.WriteRecords(pessoas);
}

static void LerUsandoOMappingEtirandoLogicaDaClasse(){
   var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "remedio.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException($"o arquivo [- {path} ] não existe");   

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture){
        Delimiter = ","
    };

    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<RemedioMap>();

    var registros = csvReader.GetRecords<Remedio>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Nº DCB: {registro.NumDcb}");
        Console.WriteLine($"Denominação Comum Brasileira: {registro.NomeComum}");
        Console.WriteLine($"Nº CAS: {registro.NumCas}");
        //Console.WriteLine($"Valor Unitário: {registro.ValorUnitario}");
        //Console.WriteLine($"Valor Total: {registro.ValorTotal}");
        Console.WriteLine("-----------------------");

    }          
}

static void LerCsvSemCabecalho(){
   var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "notas.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException($"o arquivo [- {path} ] não existe");   

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture){
        Delimiter = ","
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Notas>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Disciplina: {registro.Disciplina}");
        Console.WriteLine($"Nota: {registro.Nota}");
        Console.WriteLine($"Qtd. Faltas: {registro.Faltas}");
        //Console.WriteLine($"Valor Unitário: {registro.ValorUnitario}");
        //Console.WriteLine($"Valor Total: {registro.ValorTotal}");
        Console.WriteLine("-----------------------");

    }      
}

static void LerHeaderDeCsvDiferenteDaClasse(){
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "pc do douglas.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException($"o arquivo [- {path} ] não existe");   

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Orcamento>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Produto: {registro.Nome}");
        Console.WriteLine($"Valor: {registro.Valor}");
        Console.WriteLine($"Data: {registro.DataOrcamento}");
        //Console.WriteLine($"Valor Unitário: {registro.ValorUnitario}");
        //Console.WriteLine($"Valor Total: {registro.ValorTotal}");
        Console.WriteLine("-----------------------");

    }  

    
}

static void LerCsvComOutroDelimitador(){
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "entrada",
        "pc do douglas.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists) 
        throw new FileNotFoundException($"o arquivo [- {path} ] não existe");   

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture){
        Delimiter = ","
    };
    
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Orcamento>();

    foreach (var registro in registros){
        
        Console.WriteLine($"Produto: {registro.Nome}");
        Console.WriteLine($"Valor: {registro.Valor}");
        Console.WriteLine($"Data: {registro.DataOrcamento}");
        //Console.WriteLine($"Valor Unitário: {registro.ValorUnitario}");
        //Console.WriteLine($"Valor Total: {registro.ValorTotal}");
        Console.WriteLine("-----------------------");

    }  


}

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

