Console.WriteLine("## Atributos estáticos ##");

Calculadora.Multiplicar(10, 20);
Calculadora.Somar(10, 20);
Calculadora.Subtrair(10, 20);
Calculadora.Dividir(10, 20);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public static double Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return 0; // Retorna 0 ou você pode lançar uma exceção
        }
        return (double)num1 / num2;
    }