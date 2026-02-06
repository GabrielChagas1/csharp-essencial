Console.WriteLine("## Break e continue ##\n");

//for (; ; )
//{
//    Console.Write("Tecle algo (X sai): ");
//    var opcao = Console.ReadLine();
//    Console.WriteLine(opcao.ToUpper());
//    if (opcao.Equals("X", StringComparison.CurrentCultureIgnoreCase))
//        break;
//}

//for (int x = 0; x <= 10; x++)
//{
//    if(x == 4 || x == 7)
//        continue;
//    Console.WriteLine(x);
//}

//int n = 1;
//while (n <= 10)
//{
//    if(n == 5)
//    {
//        n++;
//        continue;
//    }
//    Console.WriteLine($"n={n}");
//    n++;
//}

for (int i = 0; i < 10; i++)
{
    if (i == 5)
        continue;
    if(i == 8)
        break;

    Console.WriteLine($"i = {i}");
}

Console.ReadKey();
