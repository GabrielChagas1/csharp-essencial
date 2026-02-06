Console.WriteLine("## Estruturas Switch ##");

//Console.Write("Digite o mês: ");
//string mes = Console.ReadLine();

//switch (mes)
//{
//    case "janeiro":
//    case "março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;
//    case "abril":
//    case "junho":
//    case "setembro":
//    case "novembro":
//        Console.WriteLine("Este mês tem 30 dias");
//        break;
//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;

//}


int cargo = 0, funcao = 0;
Console.Write("Você é Gerente(1) ou Programador(2): ");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.Write("Você é Júnior(1), Pleno(2) ou Sênior(3): ");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Bem-Vindo Gerente.");
        break;
    case 2:
        Console.WriteLine("Bem-Vindo Programador.");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Nível Júnior.");
                break;
            case 2:
                Console.WriteLine("Nível Pleno.");
                break;
            case 3:
                Console.WriteLine("Nível Sênior.");
                break;
            default:
                Console.WriteLine("Nível inválido.");
                break;
        }
    break;
    default:
        Console.WriteLine("Cargo inválido.");
        break;
}

Console.ReadKey();