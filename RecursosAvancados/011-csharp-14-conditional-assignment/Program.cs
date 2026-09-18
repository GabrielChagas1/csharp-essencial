using _011_csharp_14_conditional_assignment;

Console.WriteLine("## Conditional Assignment ##");

string telefone = "11 99999-9999";

//pedido null
Pedido? pedido = null;

pedido?.Cliente?.Telefone = telefone;
Console.WriteLine("Código executado sem exceção");


//pedido não null, mas cliente null
Pedido pedido2 = new()
{
    Cliente = null
};
pedido2?.Cliente?.Telefone = telefone;
Console.WriteLine("Cliente ainda é null.");

//pedido e cliente não null
Pedido pedido3 = new()
{
    Cliente = new Cliente()
};

pedido3?.Cliente?.Telefone = telefone;
Console.WriteLine(pedido3!.Cliente.Telefone);

Console.ReadKey();