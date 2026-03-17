Console.WriteLine("Tipos Anonimos");

var pessoa = new { Nome = "João", Idade = 30 };
Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
Console.WriteLine(pessoa.GetType());

Console.ReadKey();
