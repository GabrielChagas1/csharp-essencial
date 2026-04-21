Console.WriteLine("Queue");

Queue<Pedido> filaPedidos = new();

//adicionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.00));
filaPedidos.Enqueue(new Pedido(201, 25));
filaPedidos.Enqueue(new Pedido(301, 32.40));
filaPedidos.Enqueue(new Pedido(401, 50.90));

//exibir o numero de pedidos na fila
Console.WriteLine($"\nNúmero de pedidos na fila: {filaPedidos.Count}\n");

//processar os pedidos da fila
while(filaPedidos.Count > 0)
{
    //retirar o próximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, valor: {proximoPedido.Valor:C}");
}

filaPedidos.Enqueue(new Pedido(501, 10.00));
filaPedidos.Enqueue(new Pedido(601, 25));
filaPedidos.Enqueue(new Pedido(701, 32.40));
filaPedidos.Enqueue(new Pedido(801, 50.90));

int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(x => x.Numero == numeroPedido);

if(pedidoLocalizado != null) Console.WriteLine($"Pedido {numeroPedido} localizado na fila, valor: {pedidoLocalizado.Valor:C}");

Console.ReadKey();
class Pedido(int numero, double valor)
{
    public int Numero { get; set; } = numero;
    public double Valor { get; set; } = valor;
}

