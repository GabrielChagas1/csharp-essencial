Console.WriteLine("Execessões");


try
{
    Console.Write("Informe o valor de x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Informe o valor de y: ");
    int y = int.Parse(Console.ReadLine());

    int z = x / y;

    Console.WriteLine($"O resultado de {x} / {y} é: {z}");
}
catch (Exception ex)
{
    Console.WriteLine(ex?.StackTrace?.ToString());

	Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Fim do programa");
}

Console.ReadKey();
