Console.WriteLine("## Modificador Params ##");

Console.WriteLine("\nSoma de números inteiros\n");

Calculadora calculadora = new ();
int resultadoSoma = calculadora.Somar(1, 2, 3, 4, 5);
Console.WriteLine($"O resultado da soma é: {resultadoSoma}");

Console.ReadKey();

public class Calculadora
{
    public int Somar(params int[] numeros)
    {
        //int resultado = 0;
        //foreach (int numero in numeros)
        //{
        //    resultado += numero;
        //}
        //return resultado;
        return numeros.Sum();
    }
}
