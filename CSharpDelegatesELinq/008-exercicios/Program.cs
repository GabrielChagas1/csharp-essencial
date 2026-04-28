Console.WriteLine("##Exercícios Delegate ##");

List<Aluno> nomes = [
    new Aluno("Maria", 22),
    new Aluno("Miriam", 25),
    new Aluno("Paulo", 20),
    new Aluno("Carlos", 30)
];

Action<Aluno> imprimir = x => Console.WriteLine($"Nome: {x.Nome}, Idade: {x.Idade}");

nomes.ForEach(imprimir);

Predicate<Aluno> verificaIdade = x => x.Idade >= 18;

List<Aluno> alunosMaioresDeIdade = nomes.FindAll(verificaIdade);
alunosMaioresDeIdade.ForEach(imprimir);

Func<List<Aluno>, Aluno?> recuperarPessoaMaisVelha = p => p.OrderByDescending(x => x.Idade).FirstOrDefault();
var pessoaMaisVelha = recuperarPessoaMaisVelha(nomes);
//var teste = nomes.OrderByDescending(x => x.Idade).FirstOrDefault();
//Aluno? teste = nomes.MaxBy(x => x.Idade);

if (pessoaMaisVelha != null)
{
    Console.WriteLine($"A pessoa mais velha é {pessoaMaisVelha?.Nome} - {pessoaMaisVelha?.Idade}");
}

Console.ReadKey();

class Aluno(string nome, int idade)
{
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
}
