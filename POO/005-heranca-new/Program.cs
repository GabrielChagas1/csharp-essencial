Console.WriteLine("## Herança New ##");

Aluno aluno = new()
{
    Nome = "Maria",
    Idade = 20,
    Curso = "Engenharia de Software",
    Nota = 85
};
aluno.Apresentar();
Console.ReadKey();

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
    // Usando a palavra-chave 'new' para ocultar o método Apresentar da classe base
    public new void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, curso {Curso} e minha nota é {Nota}.");
    }
}
