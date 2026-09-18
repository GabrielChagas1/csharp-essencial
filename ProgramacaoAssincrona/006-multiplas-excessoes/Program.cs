Console.WriteLine("## Múltiplas Exceções ##");

await LancaMultiplasExcessoesAsync();

static async Task LancaMultiplasExcessoesAsync()
{
	Task tarefas = null!;
    try
	{
		var primeiraTask = Task.Run(async () =>
		{
			await Task.Delay(2000);
			throw new IndexOutOfRangeException("Index fora do intervalo.");
		});

		var segundaTask = Task.Run(async () =>
		{
			await Task.Delay(3000);
			throw new InvalidOperationException("Operação inválida.");
		});

		tarefas = Task.WhenAll(primeiraTask, segundaTask);
		await tarefas;
    }
	catch
	{
		if(tarefas?.Exception != null)
		{
            foreach (var ex in tarefas.Exception.InnerExceptions)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine("Exceção agregada capturada: " + ex.Message);
            }
        }
        
    }
}