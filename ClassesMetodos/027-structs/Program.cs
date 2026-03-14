Console.WriteLine("Structs");

//Cliente cliente = new()
//{
//    Nome = "Maria",
//    Idade = 30
//};

MinhaClasse c1 = new() { x = 10, y = 20 };
MinhaStruct s1 = new() { x = 10, y = 20 };

Console.ReadKey();


public class MinhaClasse 
{
    public int x;
    public int y;
}

struct MinhaStruct
{
    public int x;
    public int y;
}


struct Cliente
{
    public string? Nome;
    public int Idade { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}