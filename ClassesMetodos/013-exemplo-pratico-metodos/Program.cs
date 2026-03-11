Console.WriteLine("## Métodos ##");

Cadastro cadastro = new();
Cliente cliente = cadastro.Regitrar();
cadastro.Exibir(cliente);

Cliente cliente1 = new("João", 25, 3000);
cadastro.Registrar(cliente1);
cadastro.Exibir("Dados atualizados do cliente:", cliente1);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    {}
}

public class Cadastro
{
    public Cliente Regitrar()
    {
        Cliente cliente = new("Maria", 30, 5000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda += 1000;
        return cliente;
    }

    public void Exibir(Cliente cliente)
    {
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Idade: {cliente.Idade}");
        Console.WriteLine($"Renda: {cliente.Renda.ToString("c")}");
    }

    public void Exibir(string texto, Cliente cliente)
    {
        Console.WriteLine(texto);
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Idade: {cliente.Idade}");
        Console.WriteLine($"Renda: {cliente.Renda.ToString("c")}");
    }
}

