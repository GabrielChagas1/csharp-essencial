Console.WriteLine("## Exercicio ##");

List<Aluno> alunos = [
    new() { Nome = "Maria", Nota = 8.75 },
    new() { Nome = "Manoel", Nota = 6.95 },
    new() { Nome = "Amanda", Nota = 7.25 },
    new() { Nome = "Carlos", Nota = 6.55 },
    new() { Nome = "Jaime", Nota = 8.50 },
    new() { Nome = "Debora", Nota = 5.95 },
    new() { Nome = "Alicia", Nota = 9.25 },
    new() { Nome = "Sandra", Nota = 5.55 },
    new() { Nome = "Marta", Nota = 7.85 },
    new () { Nome = "Sueli", Nota = 9.15 }
];


ExibirAlunos(alunos, false);

alunos.AddRange(
[
    new() { Nome = "Bia", Nota = 7.75 },
    new() { Nome = "Mario", Nota = 8.95 },
]);


ExibirAlunos(alunos, false);

//remover aluno Amanda
Aluno? aluno = alunos.FirstOrDefault(x => x.Nome == "Amanda");
if(aluno != null) alunos.Remove(aluno);

int index = alunos.FindIndex(x => x.Nome == "Amanda");
alunos.RemoveAt(index);

//ordernar lista por nome
ExibirAlunos(alunos.OrderBy(x => x.Nome).ToList(), true);

// alunos com nota maior que 8
ExibirAlunos(alunos.FindAll(x => x.Nota >= 8), true);


Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos, bool exibirApenasALunos)
{

    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome} - Nota: {aluno.Nota}");
    }
    if(!exibirApenasALunos)
    {
        Console.WriteLine($"Média: {Math.Round(alunos.Average(x => x.Nota), 2)}");
        Console.WriteLine($"Quantidade de Alunos: {alunos.Count}");
    }
    Console.WriteLine();
}

public class Aluno
{
    public string Nome { get; set; } = "";
    public double Nota { get; set; }
}
