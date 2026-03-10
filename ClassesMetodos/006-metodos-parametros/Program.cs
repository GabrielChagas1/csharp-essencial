Console.WriteLine("## Métodos ##");

Aluno aluno1 = new Aluno
{
    Nome = "Gabriel",
    Idade = 25,
    Sexo = "Masculino",
    Aprovado = "S"
};

Curso curso = new();
curso.Resultado(aluno1);


Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.Nome}, sexo {aluno.Sexo} com idade {aluno.Idade} anos");
        if(aluno.Aprovado == "S")
        {
            Console.WriteLine("foi aprovado!");
        }
        else
        {
            Console.WriteLine("foi reprovado!");
        }
    }
}