Console.WriteLine("## Task.WhenEach ##");

List<Task<int>> listaTarefas =
[
    SimulaOperacaoAsync(1000),
    SimulaOperacaoAsync(2000),
    SimulaOperacaoAsync(3000),
    SimulaOperacaoAsync(5000)
];

//var tarefas = await Task.WhenAll(listaTarefas);


await foreach (var resultado in Task.WhenEach(listaTarefas))
{
    Console.WriteLine($"Resultado: {await resultado}");
}

Console.ReadLine();

Console.ReadKey();

static async Task<int> SimulaOperacaoAsync(int delay)
{
    await Task.Delay(delay);
    return delay;
}