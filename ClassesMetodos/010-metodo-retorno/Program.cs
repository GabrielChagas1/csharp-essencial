Console.WriteLine("## Métodos com retorno ##");

Calculadora calc = new();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Subtrair(10, 20));
Console.WriteLine(calc.Multiplicar(10, 20));
Console.WriteLine(calc.Dividir(10, 20));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public double Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return 0; // Retorna 0 ou você pode lançar uma exceção
        }
        return (double)num1 / num2;
    }
}
