public class Pessoa
{
    public string? Nome;
    public int Idade;
    public static int IdadeMinima;
    static Pessoa()
    {
        IdadeMinima = 18;
        Console.WriteLine("Construtor estático chamado.");
    }
    public Pessoa()
    {
        Console.WriteLine("Construtor de instância padrão chamado.");
    }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Console.WriteLine("Construtor de instância chamado.");
    }
}