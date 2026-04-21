Console.WriteLine("## QUEUE ##");

Queue<string> queue = new(["C#", "Phyton", "Java", "SQL", "ASP.NET"]);

Console.WriteLine($"\nA fila original contém {queue.Count} itens");
ExibirColecao(queue);

Console.WriteLine($"\nItem obtido da fila (Peek): {queue.Peek()}");


Console.WriteLine("Adicionando item na fila");
queue.Enqueue(".NET MAUI");
ExibirColecao(queue);

Console.WriteLine($"\nItem removido da fila (Pop): {queue.Dequeue()}");
ExibirColecao(queue);

if (!queue.Contains("C#")) Console.WriteLine("\nC# não está na fila");

Console.ReadKey();
static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
        Console.WriteLine(item);
}

class Pedido(int numero, double valor)
{
    public int Numero { get; set; } = numero;
    public double Valor { get; set; } = valor;
}
