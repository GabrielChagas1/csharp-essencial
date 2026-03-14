Console.WriteLine("## Construtor estáticos ##");

Pessoa p1 = new("João", 25);
Console.WriteLine($"Pessoa: {p1.Nome}, Idade: {p1.Idade}, Idade Mínima: {Pessoa.IdadeMinima}");

Console.ReadKey();
