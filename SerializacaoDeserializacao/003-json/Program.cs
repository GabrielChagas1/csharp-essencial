using System.Reflection.PortableExecutable;
using System.Text.Json;

Console.WriteLine("## Serialização JSON ##");

Aluno aluno = new(1, "João", "teste@teste.com", 20);

var caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\txt\alunoSerializado.json";

using (StreamWriter writer = new(caminhoArquivo))
{
    string jsonString = JsonSerializer.Serialize(aluno);
    writer.Write(jsonString);
}

Console.WriteLine("Objeto serializado para JSON com sucesso");

Console.WriteLine("\n## Desserialização JSON ##");

string jsonContent = File.ReadAllText(caminhoArquivo);

Aluno alunoDesserializado = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno JSON desserializado - " +
    $"Id: {alunoDesserializado.Id}, " +
    $"Nome: {alunoDesserializado.Nome}, " +
    $"Email: {alunoDesserializado.Email}, " +
    $"Idade: {alunoDesserializado.Idade}");

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Idade { get; set; }

    public Aluno() { }

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}
