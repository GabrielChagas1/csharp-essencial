Console.WriteLine("SortedDictionary");

SortedDictionary<int, string> brics = new()
{
    { 30, "Brasil" },
    { 20, "China" },
    { 10, "URSS" },
    { 40, "India" }
};

Console.WriteLine($"\nIncluindo o elemento");
if (brics.ContainsKey(70))
{
    Console.WriteLine("Chave já existe");
}
else
{
    brics.Add(70, "África do Sul");
}

Console.WriteLine($"\nNúmero de pares de chaves elementos no dicionário: {brics.Count}");

Console.WriteLine($"\nAcessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");
brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine($"\nRemovendo chave 20: brics.Remove(20) -> China");
brics.Remove(20);

Console.WriteLine($"\nVerificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave: 30? => {brics.ContainsKey(30)}");

Console.WriteLine($"\nVerificando se um valor existe com ContainsValue");
Console.WriteLine($"Existe o valor: URSS ? => {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe o valor: Chile ? => {brics.ContainsValue("Chile")}");

if(brics.TryGetValue(30, out string? valor))
    Console.WriteLine($"Valor da chave 30: {valor}");
else
    Console.WriteLine($"A chave não existe");

Console.WriteLine($"\nPercorrendo um SortedDictionary com foreach");
foreach(var pais in brics)
{
    Console.WriteLine($"Chave/valor = {pais.Key} {pais.Value}");
}

Console.ReadKey();