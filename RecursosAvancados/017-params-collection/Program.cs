Console.WriteLine("## Params e Collections ##");

ContadorNumeros(1, 2, 3, 4, 5);


Console.ReadKey();

static void ContadorNumeros(params int[] numeros)
{
    Console.WriteLine($"Quantidade de números: {numeros.Length}");
    //foreach (var numero in numeros)
    //{
    //    Console.WriteLine(numero);
    //}
}