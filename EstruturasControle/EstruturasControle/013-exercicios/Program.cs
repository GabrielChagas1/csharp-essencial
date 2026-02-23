Console.WriteLine("## Exercicíos ##");

//1. Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior 
//int numeroMaior = 0;

//for (int i = 0; i < 3; i++)
//{
//    Console.Write("Digite um número: ");
//    int numero = int.Parse(Console.ReadLine());

//    if (numero > numeroMaior)
//    {
//        numeroMaior = numero;
//    }
//}
//Console.WriteLine($"O número {numeroMaior} é o maior");

//2.Escreva um programa para calcular a raiz da equação quadrática
//double delta, x1, x2;
//Console.Write("Informe a o valor de a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Informe a o valor de b: ");
//int b = int.Parse(Console.ReadLine());
//Console.Write("Informe a o valor de c: ");
//int c = int.Parse(Console.ReadLine());

//delta = Math.Pow(b, 2) - 4 * a * c;

//if(delta > 0)
//{
//    Console.WriteLine("As duas raizes são iguais");
//    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
//    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
//    Console.WriteLine($"Primeira Raiz x1 = {x1}");
//    Console.WriteLine($"Segunda Raiz x2 = {x2}");
//}
//else if(delta == 0)
//{
//    Console.WriteLine("As duas raizes são iguais");
//    x1 = -b / (2.0* a);
//    x2 = x1;
//    Console.WriteLine($"Primeira Raiz x1 = {x1}");
//    Console.WriteLine($"Segunda Raiz x2 = {x2}");
//}else
//{
//    Console.Write("As raízes são imaginárias;\n Sem solução para os números reais. \n\n");
//}

//3.

//int soma = 0;
//Console.WriteLine("Os 10 primeiros números naturais são: ");
//for (int i = 0; i <= 10; i++)
//{
//    Console.Write(i + " ");
//    soma = soma + i;
//}
//Console.WriteLine($"A soma dos números é: {soma}");

//int soma = 0, i = 0;
//Console.WriteLine("Os 10 primeiros números naturais são: ");
//while (i <= 10)
//{
//    Console.Write(i + " ");
//    soma = soma + i;
//    i++;
//}
//Console.WriteLine($"A soma dos números é: {soma}");

//int soma = 0, i = 1;
//Console.WriteLine("Os 10 primeiros números naturais são: ");
//do
//{
//    Console.Write(i + " ");
//    soma = soma + i;
//    i++;
//} while (i <= 10);
//Console.WriteLine($"A soma dos números é: {soma}");

//4.Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado   

//int i = 1, acao = 1;

//while (acao != 2)
//{
//    Console.Write($"Digite um número: ");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    while(i <= 10)
//    {
//        Console.WriteLine($"{numero} x {i} = {numero * i}");
//        i++;
//    }
//    Console.Write("Escolha a opção [1]Continuar [2]Sair: ");
//    acao = Convert.ToInt32(Console.ReadLine());
//    i = 1;
//}

//Console.ReadLine();

//int i = 1, acao = 1;
//do
//{
//    Console.Write($"Digite um número: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    do
//    {
//        Console.WriteLine($"{numero} x {i} = {numero * i}");
//        i++;
//    } while (i <= 10);
//    Console.Write("Escolha a opção [1]Continuar [2]Sair: ");
//    acao = Convert.ToInt32(Console.ReadLine());
//    i = 1;
//} while (acao != 2);

//Console.ReadLine();


//for (; ; )
//{
//    Console.Write($"Digite um número: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{numero} x {i} = {numero * i}");
//    }
//    Console.Write("Escolha a opção [1]Continuar [2]Sair: ");
//    int acao = Convert.ToInt32(Console.ReadLine());

//    if (acao == 2) break;
//}

//Console.WriteLine("Fim do processamento.");
//Console.ReadKey();

//5. Escreva um programa para solicitar ao usuário que escolha

//Console.WriteLine("Qual a instrução para sair de um loop ?");
//Console.WriteLine("a.quit\nb.continue\nc.break\nd.exit");

//bool condicao = true;
//while (condicao)
//{
//    Console.Write("Qual a opção correta? tecle x para sair");
//    string resposta = Console.ReadLine();
//    if (resposta == "c")
//    {
//        Console.WriteLine("Resposta Correta !");
//        condicao = false;
//    }
//    else if (resposta == "x")
//    {
//        Console.WriteLine("Programa encerrado..");
//        condicao = false;
//    }
//    else
//    {
//        Console.WriteLine("Resposta Incorreta !!!");
//    }
//}

//6.Crie um programa para exbir no console os números pares de 10 a 20

//for (int i = 10; i < 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//    }

//    if(i == 16)
//    {
//        continue;
//    }

//    Console.WriteLine($"i = {i}");
//}

//for (int i = 10; i < 20; i += 2)
//{
//    if (i == 16)
//    {
//        continue;
//    }

//    Console.WriteLine($"i = {i}");
//}

//for (int i = 10; ; i += 2)
//{
//    if (i == 16)
//    {
//        continue;
//    }

//    if (i > 20)
//    {
//        break;
//    }

//    Console.WriteLine($"i = {i}");
//}

//7. Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco 

//Console.Write("Digite o número de linhas: ");
//int numero = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= numero; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.Write("\n");
//}

//Console.ReadKey();

//8. Escreva um programa para calcular o fatorial de um número inteiro. 

//Console.Write("Digite um número: ");
//int numero = Convert.ToInt32(Console.ReadLine());

//int fatorial = 1;

////for (int i = numero; i >= 1; --i)
////{
////    fatorial = fatorial * i;
////}

//for (int i = 1; i <= numero; i++)
//{
//    Console.WriteLine($"{i} {fatorial}");
//    fatorial = fatorial * i;
//}


//Console.WriteLine($"O fatorial de {numero} é {fatorial}");
//Console.ReadKey();

//9. Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

//int i = 2;
//do
//{
//    int multiplicador = 1;
//    do
//    {
//        Console.WriteLine($"{i} x {multiplicador} = {i * multiplicador}");
//        multiplicador++;
//    } while (multiplicador <= 10);
//    Console.WriteLine("");
//    i++;
//} while (i <= 6);

//10.Crie um programa  que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um aluno

//int comando = 2;

//while (comando != 1)
//{
//    Console.Write("Informe a nota do aluno: ");
//    int nota = Convert.ToInt32(Console.ReadLine());

//    switch (nota)
//    {
//        case 10:
//            Console.WriteLine("A+");
//            break;
//        case 9:
//            Console.WriteLine("A");
//            break;
//        case 8: 
//        case 7:
//            Console.WriteLine("B");
//            break;
//        case 6:
//            Console.WriteLine("C");
//            break;
//        case 5:
//            Console.WriteLine("E");
//            break;
//        case 4:
//        case 3:
//        case 2:
//        case 1:
//            Console.WriteLine("F");
//            break;
//    }

//    Console.Write("Deseja continuar ou sair: [1]Sair [2]Continuar ");
//    comando = Convert.ToInt32(Console.ReadLine());
//}


//11.Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros
int num1;
int num2;
string operando;
float resposta;
Console.Write("\nInforme o primeiro número: \t");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nInforme o operando (+, -, /, *): ");
operando = Console.ReadLine();
Console.Write("\nInforme o segundo número: \t ");
num2 = Convert.ToInt32(Console.ReadLine());
switch (operando)
{
    case "-":
        resposta = num1 - num2;
        break;
    case "+":
        resposta = num1 + num2;
        break;
    case "/":
        resposta = (float)num1 / num2;
        break;
    case "*":
        resposta = num1 * num2;
        break;
    default:
        resposta = 0;
        break;
}
Console.WriteLine($"\n{num1} {operando}  {num2} =  {resposta}");
Console.ReadKey();
