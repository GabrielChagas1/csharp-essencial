Console.WriteLine("## Herança Construtores ##");

Aluno aluno = new();
Aluno aluno1 = new("Maria");

Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine($"Construtor da classe Pessoa com parâmetro: {nome}");
    }
}

class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine($"Construtor da classe Aluno com parâmetro: {nome}");
    }

}
