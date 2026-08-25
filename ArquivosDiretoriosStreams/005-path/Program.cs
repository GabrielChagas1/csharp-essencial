Console.WriteLine("## Path ##");

//string caminho = "d:\\dados\\txt\\poesia.txt";

//char dirSeparator = Path.DirectorySeparatorChar;

//Console.WriteLine($"Separador de diretórios: {dirSeparator}");

//string[] diretorios = caminho.Split(dirSeparator);
//foreach (var dir in diretorios)
//{
//    Console.WriteLine(dir);
//}

string path1 = "c:\\dados";
string path2 = "txt\\poesia.txt";

string pathCompleto = Path.Combine(path1, path2);
Console.WriteLine($"Caminho completo: {pathCompleto}");

Console.WriteLine($"\nNome do diretório: {Path.GetDirectoryName(pathCompleto)}");
Console.WriteLine($"Nome do arquivo: {Path.GetFileName(pathCompleto)}");
Console.WriteLine($"Extensão do arquivo: {Path.GetExtension(pathCompleto)}");
Console.WriteLine($"Nome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(pathCompleto)}");
Console.WriteLine($"Raiz do caminho: {Path.GetPathRoot(pathCompleto)}");
Console.WriteLine($"Possui extensão: {Path.HasExtension(pathCompleto)}");
Console.WriteLine($"Contém raiz: {Path.IsPathRooted(pathCompleto)}");
Console.WriteLine($"Nova extensão do arquivo: {Path.ChangeExtension(pathCompleto, ".md")}");
Console.WriteLine($"Raiz do caminho: {Path.GetPathRoot(pathCompleto)}");

Console.WriteLine($"Nome de arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"Nome do arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"Caminho temporário: {Path.GetTempPath()}");

char[] caracteresInvalidos = Path.GetInvalidFileNameChars();
Console.WriteLine($"Caracteres inválidos para nomes de arquivos: {new string(caracteresInvalidos)}");

Console.ReadLine();
