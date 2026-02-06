Console.WriteLine("## Estruturas IF ELSE ##");

//Console.Write("Digite a nota do aluno: ");
//double nota = Convert.ToDouble(Console.ReadLine());

//if(nota >= 5.0)
//{
//    Console.WriteLine("Aluno aprovado!");
//}
//else
//{
//    Console.WriteLine("Aluno reprovado!");
//}

Console.Write("Digite o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.Write("X é maior que Y");
}
else
{
    if (x < y)
    {
                Console.WriteLine("Y é maior que X");
    }
    else
    {
        Console.WriteLine("X é igual a Y");
    }
}

