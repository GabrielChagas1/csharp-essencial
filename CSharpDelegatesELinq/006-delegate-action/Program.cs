Console.WriteLine("Delegate Action");

Console.Write("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine()!);

Action<int> duplicar = x => Console.Write(x * 2);

duplicar(numero);

Console.ReadKey();

static void Duplicar(int num)
{
    int resultado = num * 2;
    Console.WriteLine(resultado);
}