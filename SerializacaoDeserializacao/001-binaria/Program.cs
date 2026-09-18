using System.Runtime.Serialization.Formatters.Binary;

Console.WriteLine("## Serialização Binária ##");

Aluno aluno = new(1, "João", "teste@teste.com", 20);

var caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\txt\";

using var stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
#pragma warning disable SYSLIB0011
var formatter = new BinaryFormatter();
formatter.Serialize(stream, aluno);

stream.Seek(0, SeekOrigin.Begin);
var alunoDesserializado = (Aluno)formatter.Deserialize(stream);
Console.WriteLine(alunoDesserializado.Nome);

stream.Close();

Console.ReadKey();

[Serializable]
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } 
    public string Email { get; set; }

    [NonSerialized]
    public int Idade;

    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

}
