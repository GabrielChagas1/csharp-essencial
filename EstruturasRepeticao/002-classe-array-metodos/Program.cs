Console.WriteLine("## Array Métodos ##");

string[] nomes = ["João", "Maria", "Pedro", "Gabriel"];

Console.WriteLine("Exibindo o array original");
ExibeArray(nomes);

Console.WriteLine("\nInvertendo a ordem do o array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\nOrdenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\nLocalizando item no array ...");
Console.Write("Informe o nome a ser localizado: ");
string nomeLocalizado = Console.ReadLine() ?? string.Empty;
var indice = Array.BinarySearch(nomes, nomeLocalizado);
if (indice >= 0)
{
    Console.WriteLine($"O nome {nomeLocalizado} foi localizado no índice {indice}");
}
else
{
    Console.WriteLine($"O nome {nomeLocalizado} não foi localizado no array");
}

Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}