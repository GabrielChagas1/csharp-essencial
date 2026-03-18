Console.WriteLine("## Array Multidimensionais ###");

int[,] a = new int[2, 3]
{
    {1, 2, 3},
    {4, 5, 6}
};

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}

foreach (int valor in a)
{
    Console.Write($"{valor} ");
}

Console.ReadKey();