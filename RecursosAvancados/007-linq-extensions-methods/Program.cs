using _007_linq_extensions_methods;

Console.WriteLine("LINQ EXTENSIONS METHODS");

var pedidos = PedidoService.ObterPedidos();

var resultado = pedidos.
    ApenasAprovados().
    ApenasClientesEspeciais().
    ComValorMinimo(200).
    OrdenadosPorValorDescrescente();


Console.WriteLine("Relatório de faturamento");
Console.WriteLine("{0, -10} | {1, -10} | {2, -12} | {3, 10}", "Cliente", "Tipo", "Status", "Total");
foreach (var pedido in resultado)
{
    Console.WriteLine("{0, -10} | {1, -10} | {2, -12} | {3, 10}", pedido.Cliente, pedido.TipoCliente, pedido.Status, pedido.Total);
}

Console.ReadKey();