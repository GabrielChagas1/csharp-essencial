Console.WriteLine("## List and IEnumerable ##");

var numeros = new List<int> { 1, 2, 3, 4, 5 };

var maiores = numeros.Where(x => x > 3).ToList();

numeros.Add(10);

foreach (var n in maiores)
{
    Console.WriteLine(n);
}

Console.ReadKey();