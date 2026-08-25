Console.WriteLine("Directory Info");

var caminhoDiretorio = @"C:\Users\GabrielChagas\Desktop\poesia\MeuDiretorioNovo\";

DirectoryInfo dirOrigem = new(caminhoDiretorio);

Console.WriteLine($"Nome do diretório: {dirOrigem.Name}");
Console.WriteLine($"Caminho completo: {dirOrigem.FullName}");
Console.WriteLine($"Data de criação: {dirOrigem.CreationTime}");
Console.WriteLine($"Último acesso: {dirOrigem.LastAccessTime}");
Console.WriteLine($"Última modificação: {dirOrigem.LastWriteTime}");

Console.WriteLine("\nCriando um novo diretório");
DirectoryInfo novoDiretorio = new(@"C:\Users\GabrielChagas\Desktop\poesia\MeuDiretorioNovoDestino\");
try
{
    if(!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
        Console.WriteLine($"O diretório {novoDiretorio.FullName} foi criado com sucesso.");
    }
    else
    {
        Console.WriteLine($"O diretório {novoDiretorio.FullName} já existe.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine($"O diretório {novoDiretorio.FullName} foi excluído com sucesso.");
    }
    else
    {
        Console.WriteLine($"O diretório {novoDiretorio.FullName} não existe.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    foreach (var subdiretorio in dirOrigem.GetDirectories())
    {
        Console.WriteLine(subdiretorio.FullName);
    }
    foreach (var arquivo in dirOrigem.GetFiles())
    {
        Console.WriteLine(arquivo.FullName);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    dirOrigem.CreateSubdirectory("SubdiretorioCriado");
    Console.WriteLine("Subdiretório criado com sucesso.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();