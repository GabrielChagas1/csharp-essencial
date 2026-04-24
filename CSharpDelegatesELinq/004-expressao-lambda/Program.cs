Console.WriteLine("Expressoões Lambdas");

List<string> nomes = new List<string> { "Maria", "Miriam", "Paulo", "Carlos" };

string? resultado = nomes.Find(nome => nome.Equals("Paulo"));

Console.WriteLine(resultado);

Console.ReadKey();

