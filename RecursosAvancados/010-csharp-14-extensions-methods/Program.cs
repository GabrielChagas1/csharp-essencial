using _010_csharp_14_extensions_methods;

Console.WriteLine("## Extensions members ##");

var p = new Pessoa("João", 25);

Console.WriteLine(p.Describe());
Console.WriteLine(p.IsAdult());

var padrao = Pessoa.Default;
Console.WriteLine($"Pessoa padrão: {padrao.Describe()}");

Console.ReadKey();