using System.Diagnostics;

Console.WriteLine("## Cancelamento Operacoes ##");

CancellationTokenSource cancellationToken = new();

var stopwatch = new Stopwatch();
stopwatch.Start();

try
{
    cancellationToken = new CancellationTokenSource();
    cancellationToken.Cancel();

    //var resultado = await OperacaoLongaDuracao(100, cancellationToken.Token);
    //Console.WriteLine($"Resultado: {resultado}");

    //await ExecutaCancelamentoComTimeout(5000);
    await ExecutaCancelamentoManual(5000);


}
catch (Exception ex)
{
    Console.WriteLine($"Tarefa cancelada: tempo expirado após {stopwatch.Elapsed}");
}

Console.ReadKey();

static Task<int> OperacaoLongaDuracao(int valor, CancellationToken cancellationToken = default)
{
    Task<int> task = null;
    task = Task.Run(() =>
    {
       int resultado = 0;
        for (int i = 0; i < valor; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Thread.Sleep(1000);
            resultado += i;
        }
        return resultado;
    }, cancellationToken);
    return task;
}

static async Task ExecutaCancelamentoComTimeout(int tempo)
{
    using var cancellationToken = new CancellationTokenSource(tempo);
    try
    {
        var resultado = await OperacaoLongaDuracao(100, cancellationToken.Token);
        Console.WriteLine($"Resultado: {resultado}");
    }
    catch (Exception ex)
    {
        throw;
    }
}

static async Task ExecutaCancelamentoManual(int tempo)
{
    using var cancellationToken = new CancellationTokenSource();
    try
    {
        cancellationToken.CancelAfter(tempo);
        var resultado = await OperacaoLongaDuracao(100, cancellationToken.Token);
        Console.WriteLine($"Resultado: {resultado}");
    }
    catch (Exception ex)
    {
        throw;
    }
}