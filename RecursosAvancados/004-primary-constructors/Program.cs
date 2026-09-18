using System.Security.Cryptography.X509Certificates;

Console.WriteLine("## Primary Constructors ##");




Console.ReadKey();

//public class ClientePrimary(string nome, string email)
//{
//    public string Nome { get; } = nome;
//    public string Email { get; } = email;
//}


//public class  Cliente
//{
//    public string Nome { get; set; }
//    public string Email { get; set; }

//    public Cliente(string nome, string email)
//    {
//        Nome = nome;
//        Email = email;
//
//    

public class PedidoPrimary(Guid clientId, List<string> itens, DateTime data)
{
    public Guid ClientId { get; } = clientId != Guid.Empty ? clientId : throw new ArgumentException("ClientId não pode ser vazio.");
    public List<string> Itens { get; } = itens ?? throw new ArgumentException("Itens não pode ser nulo.");
    public DateTime Data { get; } = data != default ? data : throw new ArgumentException("Data não pode ser a data padrão.");
}


public class Pedido
{
    public Guid ClientId { get; }
    public List<string> Itens { get; }
    public DateTime Data { get; }

    public Pedido(Guid clientId, List<string> itens, DateTime data)
    {
        if(clientId == Guid.Empty)
        {
            throw new ArgumentException("ClientId não pode ser vazio.");
        }

        if(itens == null || itens.Count == 0)
        {
            throw new ArgumentException("Itens não pode ser nulo ou vazio.");
        }

        if(data == default)
        {
            throw new ArgumentException("Data não pode ser a data padrão.");
        }

        ClientId = id;
        Itens = itens;
        Data = data;
    }
}