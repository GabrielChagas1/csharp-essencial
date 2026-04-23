using System.Text;

Console.WriteLine("## Exercício ##");

try
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados");
    Console.Write("Informe o nome do arquivo: ");
    string? arquivo = Console.ReadLine();
    Console.Write("Informe a url do site: ");
    string? url = Console.ReadLine();

    HttpClient client = new();
    HttpResponseMessage response = await client.GetAsync($"{ url }/{ arquivo }");
    response.EnsureSuccessStatusCode();

    string texto = await response.Content.ReadAsStringAsync();
    Console.WriteLine("\nAcesso ao arquivo feito com sucesso");
    Console.WriteLine($"\nCódigo de status: {response.StatusCode}");
    Console.WriteLine($"\n{texto}");

    Console.ReadKey();
}
catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
{
    ExceptionLogger.Log(ex, "Página não encontrada");
}
catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
{
    ExceptionLogger.Log(ex, "Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.BadRequest)
{
    ExceptionLogger.Log(ex, "Requisição inválida");
}
catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.InternalServerError)
{
    ExceptionLogger.Log(ex, "Erro interno do servidor");
}
catch(Exception ex)
{
    ExceptionLogger.Log(ex, ex.Message);
}
finally
{
    Console.WriteLine("\n🏁 Processamento concluído");
}