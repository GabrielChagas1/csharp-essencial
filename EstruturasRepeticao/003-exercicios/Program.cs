Console.WriteLine("## Exercícios Array ##\n");

string[] nomes = new string[5];
double[] notas = new double[5];


for (int i = 0; i < nomes.Length; i++)
{
    int alunoNumero = i + 1;
    Console.Write($"Digite o nome do {alunoNumero}° aluno: ");
    nomes[i] = Console.ReadLine() ?? string.Empty;

    Console.Write($"Digite a nota do {alunoNumero}° aluno: ");
    string notaStr = Console.ReadLine() ?? "0";
    if(double.TryParse(notaStr, out double nota))
    {
        notas[i] = nota;
    }
    else
    {
        Console.WriteLine("Valor inválido para nota. A nota será definida como 0.");
        notas[i] = 0;
    }
    Console.WriteLine("");
    
}

Console.WriteLine("\n## Alunos e Notas ##");
foreach (var (nome, nota) in nomes.Zip(notas))
{
    Console.WriteLine($"Aluno: {nome} - Nota: {nota}");
}

Console.WriteLine($"Média da turma: {notas.Average()}");
Console.ReadKey();
