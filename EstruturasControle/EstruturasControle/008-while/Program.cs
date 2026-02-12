Console.WriteLine("## Estrutura de repetição while ##\n");

//while (true)
//{
//    Console.Write("Digite um número (ou -1 para sair): ");
//    var numero = Convert.ToInt32(Console.ReadLine());
//    if (numero == -1)
//    {
//        break;
//    }
//    if(numero % 2 == 0)
//    {
//        Console.WriteLine("Número par");
//    }
//    else
//    {
//        Console.WriteLine("Número ímpar");
//    }
//}

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}


Console.ReadKey();
