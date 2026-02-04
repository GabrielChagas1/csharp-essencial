Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme seu nome");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O seu nome é {nome} e sua idade é {idade}");

Console.ReadKey();