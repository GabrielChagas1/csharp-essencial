Console.WriteLine("## Tratamento de Exceções ##");

TesteAsync teste = new();
await teste.ChamaTarefaAsync();


class TesteAsync
{
    public static Task MinhaTarefaAsync()
    {
        return Task.Run(async () =>
        {
            await Task.Delay(2000);
            throw new Exception("Ocorreu um erro na tarefa assíncrona.");
        });
    }

    public async Task ChamaTarefaAsync()
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Este bloco não será executado");
            Console.WriteLine(ex.Message);
        }
    }
}