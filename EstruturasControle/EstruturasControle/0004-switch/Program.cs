Console.WriteLine("## Estruturas Switch ##");

//Console.WriteLine("Valor da compra R$ 600,00");
//Console.Write("Informe o no. de parcelas (1a 3)");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch(numeroParcelas)
//{
//    case 1:
//        Console.WriteLine("Valor da parcela R$ 600,00");
//        break;
//    case 2:
//        Console.WriteLine("Valor da parcela R$ 300,00");
//        break;
//    case 3:
//        Console.WriteLine("Valor da parcela R$ 200,00");
//        break;
//    default:
//        Console.WriteLine("Número de parcelas inválido!");
//        break;
//}

Console.Write("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("Número par");
        break;
    case 1:
        Console.WriteLine("Número ímpar");
        break;
    default:
        Console.WriteLine("Número inválido");
        break;
}

Console.ReadKey();