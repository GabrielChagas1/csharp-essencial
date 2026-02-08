Console.WriteLine("## Estruturas IF ELSE IF ##");

Console.Write("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("ALUNO REPROVADO");
}else if(nota >= 5 && nota < 6)
{
    Console.WriteLine("ALUNO DE RECUPERAÇÃO");
}
else if(nota >= 6  && nota <=9)
{
    Console.WriteLine("ALUNO APROVADO");
}
else
{
       Console.WriteLine("ALUNO APROVADO COM DISTINÇÃO");
}

Console.ReadKey();
