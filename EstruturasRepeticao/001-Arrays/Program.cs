Console.WriteLine("Arrays");

//declaração
int[] numeros;

//aloquei em memoria
numeros = [1, 2, 3, 4, 5];

string[] nomes = ["João", "Maria", "Pedro"];

//Console.WriteLine(numeros[0]);
//Console.WriteLine(nomes[2]);


for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}

Console.WriteLine("\n");


for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
}

Console.WriteLine("\n");

foreach(int numero in numeros)
{
    Console.WriteLine($"Número: {numero}");
}

foreach(string nome in nomes)
{
    Console.WriteLine($"Nome: {nome}");
}

Array.Fill(numeros, 0);


Console.ReadKey();