Console.WriteLine("## LINQ ##");

var nomes = new[] { "João", "Maria", "José", "Ana", "Pedro", "Ana" };

var contagem = nomes.CountBy(x => x);

Console.WriteLine("Contagem de nomes:");
foreach (var kvp in contagem)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var resultado = numeros.AggregateBy(
    x => x % 2 == 0 ? "Par" : "Ímpar",
    0,
    (contagem, _) => contagem + 1
);

Console.WriteLine("\n");

foreach (var item in resultado)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

Console.WriteLine("\n");

(string nome, string departamento, int diasFerias)[] funcionarios =
[
    ("João", "TI", 10),
    ("Maria", "RH", 15),
    ("José", "Financeiro", 20),
    ("Ana", "TI", 5),
    ("Pedro", "RH", 12),
    ("Ana", "Financeiro", 8)
];

var resultadoFuncionarios = funcionarios.AggregateBy(
    x => x.departamento,
    0,
    (acc, x) => acc + x.diasFerias
);

foreach (var item in resultadoFuncionarios)
{
    Console.WriteLine($"{item.Key}: {item.Value} dias de férias");
}

var alunos = new[]
{
    "Jose Sanches",
    "Janice Pereira",
    "Carlos Nogueira",
    "João Silveira"
};

foreach(var(index, aluno) in alunos.Index())
{
    Console.WriteLine($"Aluno {index}: {aluno}");
}


Console.ReadKey();