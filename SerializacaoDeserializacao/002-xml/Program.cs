using System.Xml.Serialization;

Console.WriteLine("## Serialização XML ##");

Aluno aluno = new(1, "João", "teste@teste.com", 20);

var caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\txt\aluno.xml";

XmlSerializer serializer = new(typeof(Aluno));

using (StreamWriter writer = new(caminhoArquivo)) { 

    serializer.Serialize(writer, aluno);
}


Console.WriteLine("Objeto serializado para XML com sucesso");

Console.WriteLine("\n## Desserialização XML ##");

using (StreamReader reader = new(caminhoArquivo)) {
    Aluno alunoDesserializado = (Aluno)serializer.Deserialize(reader);

    Console.WriteLine($"Aluno XML desserializado - " +
        $"Id: {alunoDesserializado.Id}, " +
        $"Nome: {alunoDesserializado.Nome}, " +
        $"Email: {alunoDesserializado.Email}, " +
        $"Idade: {alunoDesserializado.Idade}");
}




Console.ReadKey();

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