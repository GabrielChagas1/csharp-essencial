Console.WriteLine("## Estrutura de repetição for ##\n");

Console.Write("Informe o número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.ReadKey();