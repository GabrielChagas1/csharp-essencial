Console.WriteLine("Delegate Func");

Console.Write("Informe um número: ");
double numero = double.Parse(Console.ReadLine()!);

Console.WriteLine($"\nA raiz quadrada de {numero} é: {CalculaRaiz(numero)}");

Func<double, double> raizQuadrada = x => Math.Sqrt(x);
Console.WriteLine($"\nA raiz quadrada de {numero} é: {raizQuadrada(numero)}");


Console.ReadKey();

static double CalculaRaiz(double num)
{
    return Math.Sqrt(num);
}
