Console.WriteLine("## Construtores ##");

Aluno aluno = new Aluno("Gabriel", 26, "masculino", "S");


Console.ReadKey();


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}