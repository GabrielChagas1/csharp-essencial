Console.WriteLine("## Exercicios Array Multidimensionais ##");

string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
	for (int j = 0; j < alunos.GetLength(1); j++)
	{
		Console.Write($"Digite o nome do aluno na linha {i} e coluna {j}: ");
		alunos[i, j] = Console.ReadLine() ?? "";
    }
    Console.WriteLine();
}

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"{alunos[i, j]} ");
    }
    Console.WriteLine();
}

