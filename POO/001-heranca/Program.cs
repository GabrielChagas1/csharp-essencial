Console.WriteLine("## Herança ##");

Funcionario funcionario = new()
{
    Nome = "João",
    Idade = 30,
    Empresa = "Tech Company",
    Salario = 5000m
};

Console.WriteLine("Funcionario");
funcionario.Apresentar();
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);

Aluno aluno = new()
{
    Nome = "Maria",
    Idade = 20,
    Curso = "Engenharia de Software",
    Nota = 85
};

Console.WriteLine("\nAluno");
aluno.Apresentar();
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);


Console.ReadKey();

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}
