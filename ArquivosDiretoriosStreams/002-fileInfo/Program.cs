Console.WriteLine("## FileInfo ##");

string caminhoOrigem = @"C:\Users\GabrielChagas\Desktop\poesia\poesia.txt";
string caminhoDestino = @"C:\Users\GabrielChagas\Desktop\poesia\txt\poesia.txt";
string caminhoCopia = @"C:\Users\GabrielChagas\Desktop\poesia\poesia-copia.txt";

FileInfo arquivo = new(caminhoOrigem);

Console.WriteLine($"\nNome do arquivo: {arquivo.Name}");
Console.WriteLine($"\nCaminho completo do arquivo: {arquivo.FullName}");
Console.WriteLine($"\nO arquivo é somente leitura: {arquivo.IsReadOnly}");

DirectoryInfo diretorioPai = arquivo.Directory;
Console.WriteLine($"\nNome do diretorio: {diretorioPai.Name}");
Console.WriteLine($"\nTamanho do arquivo: {arquivo.Length} bytes");
Console.WriteLine($"Última gravação: {arquivo.LastWriteTime}");

if (arquivo.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivo.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"O {caminhoOrigem} não existe");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
arquivo.MoveTo(caminhoDestino);

Console.ReadKey();