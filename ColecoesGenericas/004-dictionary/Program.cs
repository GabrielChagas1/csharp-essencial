Console.WriteLine("Dictionary");

Dictionary<int, string> dic1 = new()
{
    {2, "value1" },
    {1, "valueTeste" },
};

dic1.Add(3, "value2");

//incluir elemento com chave(3) duplicada
try
{
    dic1.Add(3, "value3");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

//tentando incluir um elemento duplicado, vai me voltar false se já tiver o item
bool resultado = dic1.TryAdd(3, "value3");
Console.WriteLine(resultado);

if (!dic1.ContainsKey(7))
{
    dic1.Add(7, "value7");
}
Console.WriteLine(dic1[7]);

Console.WriteLine("\nUsando ContainsValue");
if(dic1.ContainsValue("value7")) Console.WriteLine("O valor existe no dicionário");

Console.WriteLine("\nAlterando o valor do elemento com chave 7");
Console.WriteLine($"Valor atua do item {dic1[7]}");
if (dic1.ContainsKey(7)) dic1[7] = "value77";
Console.WriteLine($"Valor alterado do item {dic1[7]}");

Console.WriteLine($"\nTentando obter elemento com chave(5) inexistente");
try
{
    Console.WriteLine(dic1[5]);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine($"\nUsando TryGetValue() para a chave 5");
if(dic1.TryGetValue(5, out string? valor))
{
    Console.WriteLine($"Valor para a chave 5 = {valor}");
}else
{
    Console.WriteLine("Chave não encontrada");
}

Console.WriteLine($"\nPercorrendo o dicionário e exibindo os itens (foreach)");
foreach (KeyValuePair<int, string> item in dic1)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine($"\nOrdernando os elementos do dicionário (SortedDictionary/LINQ)");
var dic2 = new SortedDictionary<int, string>(dic1);
foreach (KeyValuePair<int, string> item in dic2)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
Console.WriteLine();

var dic2Linq = dic1.OrderBy(x => x.Key).ToList();
foreach (KeyValuePair<int, string> item in dic2Linq)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine($"\n{dic1.Count}");
Console.WriteLine($"\n{dic1.Keys}");
Console.WriteLine($"\n{dic1.Values}");
Console.WriteLine($"\n{dic1.ContainsKey(1)}");

Console.ReadKey();