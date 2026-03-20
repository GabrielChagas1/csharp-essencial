Console.WriteLine("## Random ##");

Random random = new();

//Console.WriteLine(random.Next());
//Console.WriteLine(random.Next(20));
//Console.WriteLine(random.Next(10, 20));
//Console.WriteLine(random.NextDouble());

int[] numerosSorteados = new int[6];

for (int i = 0; i < numerosSorteados.Length; i++)
{
    int numero;
    do
    {
        numero = random.Next(1, 61);
    } while (numerosSorteados.Contains(numero));
    numerosSorteados[i] = numero;
}

Array.Sort(numerosSorteados);
Console.WriteLine("Números Sorteados");
Console.WriteLine(string.Join(" ", numerosSorteados));


Console.ReadKey();