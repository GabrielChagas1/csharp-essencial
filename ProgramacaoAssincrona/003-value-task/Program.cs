Console.WriteLine("## Value Task ##");

Console.WriteLine("\nIniciando a operação assíncrona");
await MetodoSemRetornoAsync();

Console.WriteLine("\nIniciando a operação assíncrona");
var resultado = await MetodoRetornaValorAsync(10);
Console.WriteLine($"Resultado: {resultado}");

Console.ReadKey();

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("-Método sem retorno");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("-Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}
