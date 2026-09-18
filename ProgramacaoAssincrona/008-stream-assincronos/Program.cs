
Console.WriteLine("streams assíncronos ");

await foreach (var mes in GeraMeses())
{
    Console.WriteLine(mes);
}

Console.ReadLine();

static async IAsyncEnumerable<string> GeraMeses()
{
    yield return "Janeiro";
    yield return "Fevereiro";
    yield return "Março";
    yield return "Abril";
    yield return "Maio";
    yield return "Junho";
    yield return "Julho";
    yield return "Agosto";
    await Task.Delay(1000); // Simula uma operação assíncrona
    yield return "Setembro";
    yield return "Outubro";
    yield return "Novembro";
    yield return "Dezembro";
}