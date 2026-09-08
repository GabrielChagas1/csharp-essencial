Console.WriteLine("## LINQ ##");

List<Aluno> nomes = [
    new Aluno("Maria", 22),
    new Aluno("Miriam", 25),
    new Aluno("Paulo", 20),
    new Aluno("Carlos", 30)
];

//sintaxe de consulta
var resultado = from aluno in nomes
                where aluno.Nome.Contains('m')
                select aluno;

ExibirResultado(resultado);

//sintaxe de método
var resultado2 = nomes.Where(aluno => aluno.Nome.Contains('a'));

ExibirResultado(resultado2);

Console.ReadKey();

static void ExibirResultado(IEnumerable<Aluno> resultado)
{
    foreach (var aluno in resultado)
    {
        Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}");
    }
}

class Aluno(string nome, int idade)
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
}
