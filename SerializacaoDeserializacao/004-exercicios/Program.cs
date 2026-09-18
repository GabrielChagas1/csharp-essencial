using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("## Exercícios ##");

List<Aluno> alunos = Aluno.GetAlunos();
var xmlSerializer = new XmlSerializer(typeof(List<Aluno>));

var caminhoArquivoJSON = @"C:\Users\GabrielChagas\Desktop\poesia\txt\alunoSerializado.json";
var caminhoArquivoXML = @"C:\Users\GabrielChagas\Desktop\poesia\txt\alunoSerializado.xml";


using (FileStream streamWriteJson = new(caminhoArquivoJSON, FileMode.Create, FileAccess.Write))
{
    JsonSerializer.Serialize(streamWriteJson, alunos);
}

using (FileStream streamWriteXML = new(caminhoArquivoXML, FileMode.Create, FileAccess.Write))
{
    xmlSerializer.Serialize(streamWriteXML, alunos);
}


Console.WriteLine("Objeto serializado para JSON e XML com sucesso");

using FileStream streamReadJSON = new(caminhoArquivoJSON, FileMode.Open, FileAccess.Read);
{
    List<Aluno> alunosDesserializadosJSON = JsonSerializer.Deserialize<List<Aluno>>(streamReadJSON);
    Console.WriteLine("\nAlunos JSON desserializados:");
    foreach (var aluno in alunosDesserializadosJSON)
    {
        Console.WriteLine($"Id: {aluno.Id}, Nome: {aluno.Nome}, Email: {aluno.Email}, Idade: {aluno.Idade}");
    }
}

using FileStream streamReadXML = new(caminhoArquivoXML, FileMode.Open, FileAccess.Read);
{
    List<Aluno> alunosDesserializadosXML = (List<Aluno>)xmlSerializer.Deserialize(streamReadXML);
    Console.WriteLine("\nAlunos XML desserializados:");
    foreach (var aluno in alunosDesserializadosXML)
    {
        Console.WriteLine($"Id: {aluno.Id}, Nome: {aluno.Nome}, Email: {aluno.Email}, Idade: {aluno.Idade}");
    }
}

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

    public static List<Aluno> GetAlunos()
    {
        return
        [
            new(1, "João", "testes@gmail.com", 20),
            new(2, "Maria", "testeMaria@gmail.com", 22),
            new(3, "Pedro", "pedro@gmail.com", 19),
        ];
    }
}