Console.WriteLine("## Exercícios Finais ##");

//string caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\txt\exercicio.txt";
//FileInfo FileInfo = new(caminhoArquivo);

//1)

//try
//{
//	if(File.Exists(caminhoArquivo))
//	{
//		Console.WriteLine($"Data de criação: {FileInfo.CreationTime}");
//	}
//	else
//	{
//		Console.WriteLine("Arquivo não encontrado!");
//    }
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}


////2)

//string caminhoCopia = @"C:\Users\GabrielChagas\Desktop\poesia\txt\exercicio_copia.txt";
//try
//{
//	if(File.Exists(caminhoArquivo))
//	{
//		File.Copy(caminhoArquivo, caminhoCopia);
//		Console.WriteLine("\nArquivo copiado com sucesso!");
//    }
//	else
//	{
//		Console.WriteLine("\nArquivo não encontrado!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


////3)

//try
//{
//	if(File.Exists(caminhoArquivo))
//	{
//		File.AppendAllText(caminhoArquivo, "Exercício final de C#");
//		File.AppendAllText(caminhoCopia, "Exercício final de C#");
//		File.AppendAllText(caminhoArquivo, "Exercício final de C# - atualizado");

//		string[] lines = File.ReadAllLines(caminhoArquivo);
//		foreach (string line in lines) Console.WriteLine(line);

//    }
//	else
//	{
//		Console.WriteLine("\nArquivo não encontrado!");
//	}
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}

////6)

//string caminhoDiretorio = @"C:\Users\GabrielChagas\Desktop\poesia\txt";
//try
//{
//	if(Directory.Exists(caminhoDiretorio))
//	{
//		string[] arquivos = Directory.GetFiles(caminhoDiretorio);
//		foreach (var arquivo in arquivos) Console.WriteLine(arquivo);
//    }
//	else
//	{
//		Console.WriteLine("\nDiretório não encontrado!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nArquivo não encontrado!");
//}

////7)
//string caminhoDiretorio2 = @"C:\Users\GabrielChagas\Desktop\poesia\";
//try
//{
//    if (Directory.Exists(caminhoDiretorio))
//    {
//        Console.WriteLine("\nSubdiretorios");
//		DirectoryInfo directoryInfo = new(caminhoDiretorio2);
//		var sub = directoryInfo.GetDirectories().Select(d => d.FullName);
//        foreach (var diretorio in sub) Console.WriteLine(diretorio);
//    }
//    else
//    {
//        Console.WriteLine("\nDiretório não encontrado!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nArquivo não encontrado!");
//}

////8)

//string caminhoDiretorio3 = @"C:\Users\GabrielChagas\Desktop\poesia\NovoDiretorio\";

//try
//{
//	if (!Directory.Exists(caminhoDiretorio3))
//	{
//		Directory.CreateDirectory(caminhoDiretorio3);
//		Console.WriteLine("\nDiretório criado com sucesso!");
//        File.Create(caminhoDiretorio3 + "novoArquivo.txt");
//    }
//    else
//	{
//		Console.WriteLine("\nDiretório já existe!");
//	}
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nArquivo não encontrado!");
//}

////9)

//try
//{
//	if (Directory.Exists(caminhoDiretorio3))
//	{
//		File.Copy(caminhoDiretorio3 + "novoArquivo.txt", caminhoDiretorio2 + "novoArquivoCopia.txt");
//    }
//	else
//	{
//		Console.WriteLine("\nDiretório não encontrado!");
//	}
//}
//catch (Exception ex)
//{
//	Console.WriteLine("\nArquivo não encontrado!");
//}

////10)

//try
//{
//	if (Directory.Exists(caminhoDiretorio3))
//	{
//		File.Move(caminhoDiretorio3 + "novoArquivo.txt", caminhoDiretorio2 + "novoArquivoMovido.txt");
//		Console.WriteLine("\nArquivo movido com sucesso!");
//	}
//	else
//	{
//		Console.WriteLine("\nDiretório não encontrado!");
//	}
//}
//catch (Exception ex)
//{
//	Console.WriteLine("\nArquivo não encontrado!");
//}

//11)
//string caminho = @"C:\Users\GabrielChagas\Desktop\poesia\";
//DirectoryInfo diretorio = new(caminho);
//foreach (var arquivo in diretorio.GetFiles("*", SearchOption.AllDirectories))
//{
//    Console.WriteLine(arquivo.FullName);
//}

//foreach (var subdiretorio in diretorio.GetDirectories("*", SearchOption.AllDirectories))
//{
//    Console.WriteLine(subdiretorio.FullName);
//}


//12)

//string caminhoDiretorio = @"C:\Users\GabrielChagas\Desktop\poesia\NovoDiretorio\";
//string caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\NovoDiretorio\NovoNome.txt";
//// Exclui o arquivo 
//File.Delete(caminhoArquivo);
//// Exclui o diretório 
//Directory.Delete(caminhoDiretorio, true);

//13)

//string caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\NovoDiretorio\poesia-copia.txt";
//string novoNome = "NovoNome.txt";
//string caminhoCompleto = Path.Combine(Path.GetDirectoryName(caminhoArquivo), novoNome);
//File.Move(caminhoArquivo, caminhoCompleto);


////14)

//string diretorio = @"C:\Users\GabrielChagas\Downloads";

//// Chama o método GetDirectorySize e imprime o resultado 
//long tamanhoTotal = GetDirectorySize(diretorio);
//Console.WriteLine($"Tamanho total do diretório {diretorio}: { tamanhoTotal} bytes");

//Console.ReadKey();

//static long GetDirectorySize(string diretorio)
//{
//    // Verifica se o diretório existe 
//    if (!Directory.Exists(diretorio))
//    {
//        throw new DirectoryNotFoundException($"Diretório {diretorio} não encontrado.");
//    }

//    // Recupera o tamanho de todos os arquivos no diretório 
//    long tamanhoTotal = 0;
//    foreach (string arquivo in Directory.GetFiles(diretorio, "*",
//         SearchOption.AllDirectories))
//    {
//        FileInfo info = new FileInfo(arquivo);
//        tamanhoTotal += info.Length;
//    }
//    return tamanhoTotal;
//}

////15)

//// Diretório que você deseja pesquisar 
//string diretorio = @"C:\Users\GabrielChagas\Downloads";

//// Cria um objeto DirectoryInfo para o diretório 
//DirectoryInfo dirInfo = new DirectoryInfo(diretorio);

//// Obtém todos os arquivos no diretório 
//FileInfo[] arquivos = dirInfo.GetFiles();


//// Inicializa a data de modificação mais recente e o nome do arquivo correspondente 
//DateTime ultimaModificacao = DateTime.MinValue;
//string nomeArquivoMaisRecente = string.Empty;

//// Percorre todos os arquivos para encontrar o mais recente 
//foreach (FileInfo arquivo in arquivos)
//{
//    if (arquivo.LastWriteTime > ultimaModificacao)
//    {
//        ultimaModificacao = arquivo.LastWriteTime;
//        nomeArquivoMaisRecente = arquivo.Name;
//    }
//}
//// Verifica se algum arquivo foi encontrado e imprime o nome do arquivo mais recente 
//if (!string.IsNullOrEmpty(nomeArquivoMaisRecente))
//{
//    Console.WriteLine($"O arquivo mais recente em {diretorio} é: {Path.Combine(diretorio, nomeArquivoMaisRecente)}");
//}
//else
//{
//    Console.WriteLine($"Não foi encontrado nenhum arquivo em {diretorio}");
//}