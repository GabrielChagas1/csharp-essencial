Console.WriteLine("## Exercícios structs ##");

Cliente cliente = new ();

cliente.Exibir("Gabriel", "teste@teste.com", 26);
cliente.Exibir("Maysa", "teste@gmail.com");

Console.ReadKey();

public struct Cliente
{
    public string? Nome;
    public string? Email;

    private int idade;
    public int Idade { 
        get { return idade; }
        set { 
                if( value < 18 )
                    idade = 18;
                else
                    idade = value;
        } 
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void Exibir(string nome, string email, int? idade = 18)
    {
        Console.WriteLine($"Cliente: {nome}, Idade: {idade}, Email: {email}");
    }
}