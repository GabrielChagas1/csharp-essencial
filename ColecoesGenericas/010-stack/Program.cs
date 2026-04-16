Console.WriteLine("## Stack ##");

Stack<int> stack = new([1, 2, 3]);
stack.Push(4);
ExibirColecao(stack);

Console.WriteLine($"\nA pilha original contém {stack.Count} itens");


Console.WriteLine($"\nItem obtido da pilha (Peek): {stack.Peek()}");
Console.WriteLine($"\nItem removido da pilha (Pop): {stack.Pop()}");

if(stack.Contains(4)) Console.WriteLine("\nItem 20 está na pilha");

Console.WriteLine("\nCopia a pilha usando o ToArray");
var copia = new Stack<int>(stack.ToArray());
ExibirColecao(copia);

Console.WriteLine("\nRemovendo todos os itens da pilha\n");
stack.Clear();
Console.WriteLine($"{stack.Count} itens na pilha");

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
        Console.WriteLine(item);
}