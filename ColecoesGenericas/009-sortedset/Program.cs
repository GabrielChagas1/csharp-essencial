Console.WriteLine("## Order Set ##");

SortedSet<int> numeros = [1, 5, 3, 4, 2];
ExibirColecao(numeros);

SortedSet<string> frutas = ["uva", "banana", "pera", "kiwi"];
ExibirColecao(frutas);

SortedSet<int> pares = new();
for (int i = 6; i > 0; i--)
{
    pares.Add(i * 2);
}
ExibirColecao(pares);

Console.WriteLine();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
        Console.WriteLine(item);
}