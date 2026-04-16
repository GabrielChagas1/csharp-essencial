Console.WriteLine("Set");

HashSet<int> numeros = [1, 2, 3, 4, 5];

HashSet<string> frutas = ["uva", "banana", "pera"];

HashSet<int> pares = [];

for (int i = 0; i < 6; i++) pares.Add(i * 2);

List<int> list = [1, 2, 3, 4, 5, 6, 7];
HashSet<int> conjunto = new(list);

Console.ReadKey();