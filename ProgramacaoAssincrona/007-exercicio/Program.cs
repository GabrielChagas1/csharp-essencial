Console.WriteLine("## Exercicio 007 - Programacao Assincrona");

await ExecutaOperacaoAsync();
Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    var tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    var cancellationToken = cancellationTokenSource.Token;

    Console.WriteLine("\nIniciando download");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

	try
	{
		using var httpClient = new HttpClient();
        string destino = @"C:\Users\GabrielChagas\Desktop\poesia\poesia.txt";

        var response = await httpClient.GetAsync(
			"https://www.macoratti.net/dados/poesia.txt", 
			HttpCompletionOption.ResponseHeadersRead, 
			cancellationToken
		);

		var totalBytes = response.Content.Headers.ContentLength ?? 0;
		var readBytes = 0L;

		await using var fileStream = new FileStream(destino, FileMode.Create, FileAccess.Write, FileShare.None);

		await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationToken);

		var buffer = new byte[81920];
		int bytesRead;
		while ((bytesRead = await contentStream.ReadAsync(buffer, cancellationToken)) > 0)
		{
			await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
			readBytes += bytesRead;
			Console.WriteLine($"Progresso: {readBytes} de {totalBytes} bytes ({(double)readBytes / totalBytes:P2})");
        }

    }
	catch(OperationCanceledException ex)
	{
		if(cancellationToken.IsCancellationRequested)
		{
			Console.WriteLine($"Operação cancelada pelo tempo limite. {ex.Message}");
		}
		else
		{
			Console.WriteLine("Operação cancelada devido a um timeout.");
        }
    }
	catch(HttpRequestException ex)
	{
		Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
    }
    catch (Exception ex)
	{
        Console.WriteLine($"Mensagem: {ex.Message}");
		throw;
	}
	finally
	{
        Console.WriteLine("\nDownload finalizado!");
		cancellationTokenSource.Dispose();
    }

}
