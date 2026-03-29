Console.WriteLine("Exercicio Dictionary");

Dictionary<int, Aluno> alunos = new()
{
    { 1, new Aluno("Maria", 7) },
    { 2, new Aluno("Eric", 8) },
    { 3, new Aluno("Ana", 9) },
    { 4 , new Aluno("Alex", 6) },
    { 5 , new Aluno("Dina", 7) }
};
ExibirAlunos(alunos);

do
{
    Console.Write("Informe o código do Aluno a localizar (99 sair): ");
    int codigo = Convert.ToInt32(Console.ReadLine());
    if (codigo == 99) break;
    
    bool resultado = alunos.ContainsKey(codigo);
    if(resultado)
    {
        Console.Write("Informe a nota (1 a 10): ");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não encontrado.");
    }

} while (true);
ExibirAlunos(alunos);

Console.Write("Informe o código do Aluno para remover (99 sair): ");
int cod = Convert.ToInt32(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
    Aluno value;
    alunos.Remove(cod, out value);
    Console.WriteLine($"Aluno {value?.Nome} removido com sucesso!");
}
else
{
    Console.WriteLine("\nCódigo não encontrado");
}
ExibirAlunos(alunos);

Console.WriteLine("Incluindo um novo aluno");
Console.Write("Informe o nome do aluno: ");
string novoNome = Console.ReadLine() ?? "";

Console.Write("Informe a nota do aluno: ");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o código do aluno: ");
int novoCodigo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
}else
{
    Console.WriteLine("Código já encontrado");
}
Console.WriteLine();
ExibirAlunos(alunos);
var alunosOrdernados = alunos.OrderBy(x => x.Value.Nome);
alunos = alunos.OrderBy(x => x.Value.Nome).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine();
ExibirAlunos(alunos);
Console.WriteLine();
foreach(var item in alunosOrdernados) Console.WriteLine($"{item.Key}° Aluno {item.Value.Nome} com a nota {item.Value.Nota}.");

alunos.Clear();
ExibirAlunos(alunos);
Console.WriteLine("Fim do exercício");

Console.ReadKey();

static void ExibirAlunos(Dictionary<int, Aluno> alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Key}° Aluno {aluno.Value.Nome} com a nota {aluno.Value.Nota}.");
    }
    Console.WriteLine();
}

public class Aluno(string nome, int nota)
{
    public string? Nome { get; set; } = nome;
    public int Nota { get; set; } = nota;
}